#pragma checksum "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserOrganizationModels\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8210fbcd8ab273dc4a87752d75fb5fcd5f95c6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserOrganizationModels_Create), @"mvc.1.0.view", @"/Views/UserOrganizationModels/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8210fbcd8ab273dc4a87752d75fb5fcd5f95c6d", @"/Views/UserOrganizationModels/Create.cshtml")]
    public class Views_UserOrganizationModels_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Iconnexz.Models.UserOrganizationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserOrganizationModels\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>UserOrganizationModel</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""CompanyName"" class=""control-label""></label>
                <input asp-for=""CompanyName"" class=""form-control"" />
                <span asp-validation-for=""CompanyName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CompanyRocNumber"" class=""control-label""></label>
                <input asp-for=""CompanyRocNumber"" class=""form-control"" />
                <span asp-validation-for=""CompanyRocNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address"" class=""control-label""></label>
                <input asp-for=""Address"" class=""form-control"" />
                <span asp-vali");
            WriteLiteral(@"dation-for=""Address"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Country"" class=""control-label""></label>
                <input asp-for=""Country"" class=""form-control"" />
                <span asp-validation-for=""Country"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""State"" class=""control-label""></label>
                <input asp-for=""State"" class=""form-control"" />
                <span asp-validation-for=""State"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""City"" class=""control-label""></label>
                <input asp-for=""City"" class=""form-control"" />
                <span asp-validation-for=""City"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PostalCode"" class=""control-label""></label>
                <input a");
            WriteLiteral(@"sp-for=""PostalCode"" class=""form-control"" />
                <span asp-validation-for=""PostalCode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EmailAddress"" class=""control-label""></label>
                <input asp-for=""EmailAddress"" class=""form-control"" />
                <span asp-validation-for=""EmailAddress"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Password"" class=""control-label""></label>
                <input asp-for=""Password"" class=""form-control"" />
                <span asp-validation-for=""Password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ContactNumber"" class=""control-label""></label>
                <input asp-for=""ContactNumber"" class=""form-control"" />
                <span asp-validation-for=""ContactNumber"" class=""text-danger""></span>
            </div>
         ");
            WriteLiteral("   <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserOrganizationModels\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Iconnexz.Models.UserOrganizationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
