#pragma checksum "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Address\AddAddress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fbc8761e24b0a90eee9757f42a663e79dc06f71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_AddAddress), @"mvc.1.0.view", @"/Views/Address/AddAddress.cshtml")]
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
#line 1 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\_ViewImports.cshtml"
using PortalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\_ViewImports.cshtml"
using PortalStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fbc8761e24b0a90eee9757f42a663e79dc06f71", @"/Views/Address/AddAddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528ff14f7e118acc0eb7c763f2db4cb5be1a910f", @"/Views/_ViewImports.cshtml")]
    public class Views_Address_AddAddress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Address>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Address\AddAddress.cshtml"
  
    ViewData["Title"] = "AddAddress";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Address\AddAddress.cshtml"
 using (Html.BeginForm("AddAddress", "Address", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-6\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <p class=\"card-description\">ADD ADDRESS PANEL</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fbc8761e24b0a90eee9757f42a663e79dc06f714411", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Address Line </label>
                        <input type=""text"" class=""form-control"" name=""Address Line"">
                    </div>
                    <div class=""form-group"">
                        <label>Country</label>
                        <input type=""text"" class=""form-control"" name=""Country "">
                    </div>
                    <div class=""form-group"">
                        <label>City</label>
                        <input type=""text"" class=""form-control"" name=""City"">
                    </div>
                    <div class=""form-group"">
                        <label>District</label>
                        <input type=""text"" class=""form-control"" name=""District"">
                    </div>
                    <div class=""form-group"">
                        <label>Zip Code</label>
                        <input type=""text"" class=""form-control"" name=""Zip Code "">
                    </di");
                WriteLiteral(@"v>
                    <div class=""form-group"">
                        <label>Customer ID</label>
                        <input type=""text"" class=""form-control"" name=""Customer ID "">
                    </div>
                    <div class=""form-group"">
                        <label>Status </label>
                        <input type=""text"" class=""form-control"" name=""Status"">
                    </div>
                    <div class=""form-group"">
                        <label>Creation Date </label>
                        <input type=""text"" class=""form-control"" name=""Date"">
                    </div>

                    <button type=""submit"" class=""btn btn-success"">Save</button>
                    <button class=""btn btn-primary"">Cancel</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 53 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Address\AddAddress.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Address> Html { get; private set; }
    }
}
#pragma warning restore 1591
