#pragma checksum "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c57f12887cff459ca0073faef0fbabc0c67eb84f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserIndividualModels_Index), @"mvc.1.0.view", @"/Views/UserIndividualModels/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c57f12887cff459ca0073faef0fbabc0c67eb84f", @"/Views/UserIndividualModels/Index.cshtml")]
    public class Views_UserIndividualModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Iconnexz.Models.UserIndividualModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1203, "\"", 1230, 1);
#nullable restore
#line 46 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
WriteAttributeValue("", 1218, item.UserId, 1218, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1283, "\"", 1310, 1);
#nullable restore
#line 47 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
WriteAttributeValue("", 1298, item.UserId, 1298, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1365, "\"", 1392, 1);
#nullable restore
#line 48 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
WriteAttributeValue("", 1380, item.UserId, 1380, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserIndividualModels\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Iconnexz.Models.UserIndividualModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
