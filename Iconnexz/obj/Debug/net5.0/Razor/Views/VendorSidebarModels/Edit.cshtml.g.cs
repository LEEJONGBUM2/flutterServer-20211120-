#pragma checksum "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\VendorSidebarModels\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a40c98dcfdf77faeaa477acec155dde0b8334b47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VendorSidebarModels_Edit), @"mvc.1.0.view", @"/Views/VendorSidebarModels/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a40c98dcfdf77faeaa477acec155dde0b8334b47", @"/Views/VendorSidebarModels/Edit.cshtml")]
    public class Views_VendorSidebarModels_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Iconnexz.Models.VendorSidebarModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\VendorSidebarModels\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>VendorSidebarModel</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""SidebarId"" />
            <div class=""form-group"">
                <label asp-for=""Item1"" class=""control-label""></label>
                <input asp-for=""Item1"" class=""form-control"" />
                <span asp-validation-for=""Item1"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Item2"" class=""control-label""></label>
                <input asp-for=""Item2"" class=""form-control"" />
                <span asp-validation-for=""Item2"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Item3"" class=""control-label""></label>
                <input asp-for=""Item3"" class=""form-control"" />
                <span asp-validatio");
            WriteLiteral(@"n-for=""Item3"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Item4"" class=""control-label""></label>
                <input asp-for=""Item4"" class=""form-control"" />
                <span asp-validation-for=""Item4"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Item5"" class=""control-label""></label>
                <input asp-for=""Item5"" class=""form-control"" />
                <span asp-validation-for=""Item5"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Item6"" class=""control-label""></label>
                <input asp-for=""Item6"" class=""form-control"" />
                <span asp-validation-for=""Item6"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Item7"" class=""control-label""></label>
                <input asp-for=""Item7"" ");
            WriteLiteral(@"class=""form-control"" />
                <span asp-validation-for=""Item7"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Item8"" class=""control-label""></label>
                <input asp-for=""Item8"" class=""form-control"" />
                <span asp-validation-for=""Item8"" class=""text-danger""></span>
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
#line 68 "C:\Users\note\source\repos\Iconnexz(1116)\Iconnexz\Iconnexz\Views\VendorSidebarModels\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Iconnexz.Models.VendorSidebarModel> Html { get; private set; }
    }
}
#pragma warning restore 1591