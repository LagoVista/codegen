

using System.Text.RegularExpressions;
using System.Text;
using System.Xml;
using System;

StringBuilder generatedCode = new StringBuilder();

static string MakeIntoValidIdentifier(string arbitraryString)
{
    var validIdentifier = Regex.Replace(arbitraryString, @"[^A-Za-z0-9-._]", " ");
    validIdentifier = ConvertToPascalCase(validIdentifier);
    if (Regex.IsMatch(validIdentifier, @"^\d")) validIdentifier = "_" + validIdentifier;
    return validIdentifier;
}

static string ConvertToPascalCase(string phrase)
{
    string[] splittedPhrase = phrase.Split(' ', '-', '.');
    var sb = new StringBuilder();

    sb = new StringBuilder();

    foreach (var s in splittedPhrase)
    {
        char[] splittedPhraseChars = s.ToCharArray();
        if (splittedPhraseChars.Length > 0)
        {
            splittedPhraseChars[0] = ((new String(splittedPhraseChars[0], 1)).ToUpper().ToCharArray())[0];
        }
        sb.Append(new String(splittedPhraseChars));
    }
    return sb.ToString();
}
 void EmitNamesInnerClass(List<string> names)
{
    if (names.Any())
    {
        generatedCode.AppendLine("\r\n\t\tpublic static class Names");
        generatedCode.AppendLine("\t\t{");
        foreach (var name in names)
            generatedCode.AppendLine(string.Format("\t\t\tpublic const string {0} = \"{0}\";", name));
        generatedCode.AppendLine("\t\t}");

        names.Clear();
    }
}

static List<ResourceEntry> RecordEntriesInResourceFile(string resxFile)
{
    var xmlContents = System.IO.File.ReadAllText(resxFile);

    var resources = new List<ResourceEntry>();
    var xml = new XmlDocument();
    xml.LoadXml(xmlContents);
    var entries = xml.DocumentElement.SelectNodes("//data");

    var fileInfo = new System.IO.FileInfo(resxFile);

    foreach (XmlElement entryElement in entries)
    {
        var entry = new ResourceEntry
        {
            Directory = fileInfo.Directory.FullName,
            ClassName = fileInfo.Name.Replace(fileInfo.Extension, String.Empty),
            Name = MakeIntoValidIdentifier(entryElement.Attributes["name"].Value)
        };

        var valueElement = entryElement.SelectSingleNode("value");
        if (valueElement != null)
            entry.Value = valueElement.InnerText;
        var commentElement = entryElement.SelectSingleNode("comment");
        if (commentElement != null)
            entry.Comment = commentElement.InnerText;

        resources.Add(entry);
    }

    return resources;
}


static List<string> FindResourceFilesRecursivlyAndRecordEntries(string path)
{
    var resourceFiles = new List<string>();
 
    var folders = System.IO.Directory.GetDirectories(path);
    foreach(var folder in folders)
    {
        resourceFiles.AddRange(FindResourceFilesRecursivlyAndRecordEntries(folder));
    }

    var files = System.IO.Directory.GetFiles(path, "*.resx");
    resourceFiles.AddRange(files);
    return resourceFiles;
}

var projectFiles = System.IO.Directory.GetFiles(args[0], "*.csproj", System.IO.SearchOption.AllDirectories);
if(projectFiles.Length == 0)
{
    Console.WriteLine("No project files found");
    return 100;
}

if (projectFiles.Length > 1)
{
    Console.WriteLine("More than one project file found");
    return 101;
}

var fileInfo = new System.IO.FileInfo(projectFiles.First());
var RootNamespace = fileInfo.Name.Replace(fileInfo.Extension, String.Empty);

var resourceFiles = FindResourceFilesRecursivlyAndRecordEntries(args[0]);
var AllEntries = new List<ResourceEntry>();
foreach(var resourceFile in resourceFiles)
{
    AllEntries.AddRange(RecordEntriesInResourceFile(resourceFile));
    Console.WriteLine(resourceFile);
}

generatedCode.AppendLine($"/* {DateTime.Now} */");
generatedCode.AppendLine("using System.Globalization;");
generatedCode.AppendLine("using System.Reflection;");
generatedCode.AppendLine();

var namespaceFileEntries = AllEntries.GroupBy(grp => grp.Directory);


foreach (var namespaceEntry in namespaceFileEntries)
{
    var folderPath = namespaceEntry.First().Directory;
    var rootPathLength = args[0].Length + 1;
    var ns = namespaceEntry.First().Directory.Substring(rootPathLength);
    ns = ns.Replace(@"\", ".");

    if (!String.IsNullOrEmpty(ns))
        ns = $"{RootNamespace}.{ns}";

    generatedCode.AppendLine($"namespace {ns}");
    generatedCode.AppendLine("{");
    
    var classFileEntries = namespaceFileEntries.First().GroupBy(grp => grp.ClassName);

    foreach (var classFile in classFileEntries)
    {
        var resources = classFile;

        generatedCode.AppendLine(string.Format("\tpublic class {0}", classFile.First().ClassName));
        generatedCode.AppendLine("\t{");

        generatedCode.Append("\t\tprivate static global::System.Resources.ResourceManager _resourceManager;");

        generatedCode.Append(@$"   
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private static global::System.Resources.ResourceManager ResourceManager
        {{
            get
            {{
                if (object.ReferenceEquals(_resourceManager, null))
                {{
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager(""{ns}.{resources.First().ClassName}"", typeof({resources.First().ClassName}).GetTypeInfo().Assembly);
                                _resourceManager = temp;
                }}
                return _resourceManager;
            }}
        }}");

        generatedCode.Append($@"
        /// <summary>
        ///   Returns the formatted resource string.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private static string GetResourceString(string key, params string[] tokens)
        {{
            var culture = CultureInfo.CurrentCulture; ;
            var str = ResourceManager.GetString(key, culture);

            for (int i = 0; i < tokens.Length; i += 2)
                str = str.Replace(tokens[i], tokens[i + 1]);

            return str;
        }}");

        generatedCode.Append($@"
        /// <summary>
        ///   Returns the formatted resource string.
        /// </summary>
        /*
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private static HtmlString GetResourceHtmlString(string key, params string[] tokens)
    	{{
    		var str = GetResourceString(key, tokens);

    		if(str.StartsWith(""HTML:""))
    			str = str.Substring(5);

    		return new HtmlString(str);
        }}*/");


        foreach (var entry in resources)
        {

            //Emit the static resource string access method for the current entry
            if (entry.Comment != null)
            {
                generatedCode.AppendLine(string.Format("\r\n\t\t///<summary>\r\n\t\t///{0}\r\n\t\t///</summary>", entry.Comment.Replace("\r\n", "\r\n\t\t///")));
            }
            else
                generatedCode.AppendLine("");

            ////Select all tokens between braces that constitute valid identifiers
            var tokens = Regex.Matches(entry.Value, @"{(([A-Za-z]{1}\w*?)|([A-Za-z_]{1}\w+?))?}").Cast<Match>().Select(m => m.Value);

            if (tokens.Any())
            {
                var inParams = tokens.Aggregate("", (list, value) => list += ", string " + value)
                    .Replace("{", "").Replace("}", "");
                if (inParams.Length > 0) inParams = inParams.Substring(1);
                var outParams = tokens.Aggregate("", (list, value) => list += ", \"" + value + "\", " + value.Replace("{", "").Replace("}", ""));

                if (entry.Value.StartsWith("HTML:"))
                    generatedCode.AppendLine(string.Format("\t\tpublic static HtmlString {0}({1}) {{ return GetResourceHtmlString(\"{0}\"{2}); }}", entry.Name, inParams, outParams));
                else
                    generatedCode.AppendLine(string.Format("\t\tpublic static string {0}({1}) {{ return GetResourceString(\"{0}\"{2}); }}", entry.Name, inParams, outParams));
            }
            else
            {
                if (entry.Value.StartsWith("HTML:"))
                    generatedCode.AppendLine(string.Format("\t\tpublic static HtmlString {0} {{ get {{ return GetResourceHtmlString(\"{0}\"); }} }}", entry.Name));
                else
                {
                    generatedCode.AppendLine(string.Format("\t\tpublic static string {0} {{ get {{ return GetResourceString(\"{0}\"); }} }}", entry.Name));
                    //WriteLine(string.Format("\t\tinternal static string V{0} {{ get {{ return GetResourceString(\"{0}\"); }} }}",  entry.Name));
                }
            }
        }

        generatedCode.AppendLine();
        generatedCode.AppendLine("\t\t\tpublic static class Names");
        generatedCode.AppendLine("\t\t\t{");

        foreach (var entry in resources)
        {
            generatedCode.AppendLine($"\t\t\t\tpublic const string {entry.Name} = \"{entry.Name}\";");
        }

        generatedCode.AppendLine("\t\t\t}");
    }
    generatedCode.AppendLine("\t}");
}
generatedCode.AppendLine("}");

System.IO.File.WriteAllText(@"D:\NuvIoT\codegen\Utils\ResourceGenerator\ExampleOut\Sample.cs", generatedCode.ToString());


//Project GetProjectContainingT4File(DTE dte)
//{

//// Find the .tt file's ProjectItem
//ProjectItem projectItem = dte.Solution.FindProjectItem(Host.TemplateFile);

//// If the .tt file is not opened, open it
////    if (projectItem.Document == null)
////      projectItem.Open(Constants.vsViewKindCode);

//if (AlwaysKeepTemplateDirty)
//{
//// Mark the .tt file as unsaved. This way it will be saved and update itself next time the
//// project is built. Basically, it keeps marking itself as unsaved to make the next build work.
//// Note: this is certainly hacky, but is the best I could come up with so far.
////    projectItem.Document.Saved = false;
//}

//return projectItem.ContainingProject;
//}


return 0;

struct ResourceEntry
{
    public string Directory { get; set; }
    public string ClassName { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
    public string Comment { get; set; }
}