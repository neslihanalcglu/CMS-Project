#pragma checksum "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20c1d6cc32dfbe992eff14276a46781ac47f6472"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setting_Index), @"mvc.1.0.view", @"/Views/Setting/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\_ViewImports.cshtml"
using Cms.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\_ViewImports.cshtml"
using Cms.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c1d6cc32dfbe992eff14276a46781ac47f6472", @"/Views/Setting/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a692844e410b5d40ae988c28009e1eed8303dd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Setting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cms.Entities.DataContext.Setting>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered table-responsive table-hover"">
    <tr>
        <th>Id </th>
        <th>PageTitle </th>
        <th>PageDescription</th>
        <th>WebServerAddress</th>
        <th>WebServerPort</th>
        <th>SMTPServerAddress</th>
        <th>SMTPServerPort</th>
        <th>WebMailUserName </th>
        <th>WebMailPassword </th>
        <th>Tel</th>
        <th>Gsm</th>
        <th>Fax</th>
        <th>CompanyAddress</th>
        <th>Location_Lat</th>
        <th>Location_Lng </th>
        <th>CompanyLogo </th>
        <th>IsActive</th>
        <th>CreatedDate</th>
        <th>ModifiedDate</th>
        <th>IsDeleted</th>
    </tr>
");
#nullable restore
#line 29 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
     foreach (var d in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 33 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 34 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.PageDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 35 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.WebServerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 36 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.WebServerPort);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 37 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.SMTPServerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 38 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.SMTPServerPort);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 39 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.WebMailUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 40 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.WebMailPassword);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 41 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 42 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.Gsm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 43 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 44 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.CompanyAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 45 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.Location_Lat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 46 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.Location_Lng);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 47 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.CompanyLogo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 48 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 49 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 50 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.ModifiedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 51 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
   Write(d.IsDeleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 1406, "\"", 1439, 2);
            WriteAttributeValue("", 1413, "/Setting/EditSetting/", 1413, 21, true);
#nullable restore
#line 52 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
WriteAttributeValue("", 1434, d.Id, 1434, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Update</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 1492, "\"", 1527, 2);
            WriteAttributeValue("", 1499, "/Setting/DeleteSetting/", 1499, 23, true);
#nullable restore
#line 53 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
WriteAttributeValue("", 1522, d.Id, 1522, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n</tr>");
#nullable restore
#line 54 "C:\Users\NeslihanAlcglu\Desktop\CMSProject\Cms.WebUI\Views\Setting\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Setting/CreateSetting/\" class=\"btn btn-info\">New Setting</a>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cms.Entities.DataContext.Setting>> Html { get; private set; }
    }
}
#pragma warning restore 1591