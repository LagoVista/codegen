# Model Generation
These are the specs for the task to create an Entity in NuvIoT.


Using the Models project within the solution, create a file called EmailTemplateLayout.cs this should be a class that inherits from LagoVista.Core.Models.EntityBase.  It should include a namespace reference to the class that contains the resources that will be used in this class

Using other model files as an example add EntityDescription attribute to the class.  The first parameter of the EntityDescription attribute will be the domain   ContentManagementManagement. This will require adding the title of the class which should be "Email Template Layout" and the Description and Help parameters which should have the text "Email Template Layouts are used by Email Templates to render the HTML which makes up the email which will be sent out".  The Title, Description and Help parameters need to be added to the Resource or RESX file using the name of the resource with the following format ClassName_PropertyName the project using the same naming convention as other titles, names and descriptions.  

The following list of properties to the resource file (the one with extension RESX) with the form ClassName_PropertyName and ClassName_PropertyName_Help for the help text. 

PropertyName | PropertyLabel | Field Type    | Is Required  | Help Text
------------- | -------------- | ------------- | -----------  | ------------- 
Css | Email Common CSS | MultiLineText | false | CSS that is applied to all the email templates.
ButtonHtml    | Button HTML    | MultiLineText | false        | HTML Template used to render a button on the Email Template.  It should have tags for ~href~ and ~text~.
PageLinkHtml  | Page Link HTML | MultiLineText | false        | HTML Template used to render how buttons should be rendered on the email template, it should the tag ~html.button~ to bring in the html for the button.
SocialButtonHtml | Social Button HTML | MultiLineText | false | HTML to render a single social button.  It should include the tags for ~altText~, ~link~, ~icon~
SocialLinksSectionHtml | Social Links Section HTML | MultiLineText | false | HTML to render the section that will include the social buttons, Facebook, Linked In and X
OneColumnSectionHtml | One Column Section HTML | MultiLineText | false | HTML to render a section or row of the email template that has one area for provided text.
TwoColumnSectionHtml | Two Column Section HTML | MultiLineText | false | HTML to render a section or row of the email template that has two columns for provided text.
ThreeColumnSectionHtml | Three Column Section HTML | MultiLineText | false | HTML to render a section or row of the email template that has three columns for provided text.  It should have the tags ~col1~, ~col2~, ~col3~
SectionHtml | Section HTML | MultiLineText | false | HTML used to contain a section of the email, this is typically a row with some padding and contains the tag ~content~
HeroSectionHtml | Hero Section HTML | MultiLineText | HTML use to contain the large banner at the top of the email that will contain the following tags ~TitleBlockContent~, ~TitleBlockContentLine2~, ~TitleBlockMessage~, ~HeroImage~
FooterHtml | Footer HTML | MultiLineText | false | HTML that should display the footer of the email.  It can include the following tags ~



Have the class implement the interface IFormDescriptor and add the list of fields to the implementation.
Name,
Key,
Icon,
Css
HeroSectionHTML,
SectionHtml,
OneColumnSectionHtml,
TwoColumnSectionHtml,
ThreeColumnSectionHtml,
PageLinksHtml,
ButtonHtml,
SocialButtonHtml,
SocialLinksSectionHtml,
FooterHtml,
