#pragma checksum "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserOrganizationModels\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a6e9731206fd672b8987d48aa892e7bc9ab9557"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserOrganizationModels_Edit), @"mvc.1.0.view", @"/Views/UserOrganizationModels/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6e9731206fd672b8987d48aa892e7bc9ab9557", @"/Views/UserOrganizationModels/Edit.cshtml")]
    public class Views_UserOrganizationModels_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Iconnexz.Models.UserOrganizationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserOrganizationModels\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>UserOrganizationModel</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""UserId"" />
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
                <input asp-for=""Address"" class");
            WriteLiteral(@"=""form-control"" />
                <span asp-validation-for=""Address"" class=""text-danger""></span>
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
                <label asp-for=""PostalCode"" class=");
            WriteLiteral(@"""control-label""></label>
                <input asp-for=""PostalCode"" class=""form-control"" />
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
                <span asp-validation-for=""ContactNumber"" class=""t");
            WriteLiteral(@"ext-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\UserOrganizationModels\Edit.cshtml"
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
