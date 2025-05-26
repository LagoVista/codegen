# Model Generation


Using the Models project within the solution, create a file called EmailTemplateColorPalette.cs this should be a class that inherits from LagoVista.Core.Models.EntityBase.  It should include a namespace reference to the class that contains the resources that will be used in this class

Using other model files as an example add EntityDescription attribute to the class.  The first parameter of the EntityDescription attribute will be the domain   ContentManagementManagement. This will require adding the title of the class which should be "Email Template Color Palette" and the Description and Help parameters which should have the text "Colors that can be shared across email templates."  The Title, Description and Help parameters need to be added to the Resource or RESX file using the name of the resource with the following format ClassName_PropertyName the project using the same naming convention as other titles, names and descriptions.  


Have the class implement the interface IFormDescriptor and add the list of fields to the implementation.
Name,
Key,
Icon,

Create a SummaryData version of the EmailTemplateColorPalette class and place it in the same files as the original class, it should inherit from SummaryData.  It should also have an EntityDescription similar to the original class, but it will use the plural for the object title.

Have the original object implement the ISummaryFactory interface.  That CreateSummary method should create a new instance of the summary data and call the Populate method on the original classes, base class to populate the summary object.