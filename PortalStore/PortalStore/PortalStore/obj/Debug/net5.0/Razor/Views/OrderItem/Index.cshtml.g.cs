#pragma checksum "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91dcc6c3d8a505d4a7b13e35c13cea2bb1ed547a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderItem_Index), @"mvc.1.0.view", @"/Views/OrderItem/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91dcc6c3d8a505d4a7b13e35c13cea2bb1ed547a", @"/Views/OrderItem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528ff14f7e118acc0eb7c763f2db4cb5be1a910f", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderItem>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91dcc6c3d8a505d4a7b13e35c13cea2bb1ed547a3795", async() => {
                WriteLiteral(@"
    <title>Bootstrap Example</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91dcc6c3d8a505d4a7b13e35c13cea2bb1ed547a5211", async() => {
                WriteLiteral(@"

    <div class=""container"">
        <h2>Order Item Page</h2>
        <table class=""table"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>SKU ID</th>
                    <th>ORDER ID</th>
                    <th>UNIT PRICE</th>
                    <th>QUANTITY</th>
                    <th>STATUS</th>
                    <th>CREATION DATE</th>
                    <th>DELETE</th>
                    <th>UPDATE</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 37 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr class=\"success\">\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml"
                       Write(item.SkuId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml"
                       Write(item.OrderID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml"
                       Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml"
                       Write(item.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml"
                       Write(item.CreationDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td><a href=\"#\" class=\"btn btn-danger\">Delete</a></td>\r\n                        <td><a href=\"#\" class=\"btn btn-primary\">Update</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 50 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\OrderItem\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n        <a href=\"/OrderItem/AddOrderItem\" class=\"btn btn-success\">ADD</a>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
