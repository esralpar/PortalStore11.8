#pragma checksum "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec63f04e81f4002325ee48f86c9cc610ab84475f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec63f04e81f4002325ee48f86c9cc610ab84475f", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528ff14f7e118acc0eb7c763f2db4cb5be1a910f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
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
#line 3 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec63f04e81f4002325ee48f86c9cc610ab84475f3787", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec63f04e81f4002325ee48f86c9cc610ab84475f5203", async() => {
                WriteLiteral(@"

    <div class=""container"">
        <h2>Customer Page</h2>
        <table class=""table"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>FIRST NAME</th>
                    <th>LAST NAME</th>
                    <th>EMAIL</th>
                    <th>TC ID</th>
                    <th>BIRTHDATE</th>
                    <th>GSM</th>
                    <th>STATUS</th>
                    <th>CREATION DATE</th>
                    <th>DELETE</th>
                    <th>UPDATE</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 39 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr class=\"success\">\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
                       Write(item.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
                       Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
                       Write(item.TCID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
                       Write(item.Birthdate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
                       Write(item.Gsm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
                       Write(item.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
                       Write(item.CreationDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1826, "\"", 1866, 2);
                WriteAttributeValue("", 1833, "/Customer/DeleteCustomer/", 1833, 25, true);
#nullable restore
#line 51 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
WriteAttributeValue("", 1858, item.Id, 1858, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1938, "\"", 1976, 2);
                WriteAttributeValue("", 1945, "/Customer/EditCustomer/", 1945, 23, true);
#nullable restore
#line 52 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"
WriteAttributeValue("", 1968, item.Id, 1968, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">Update</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 54 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n        <a href=\"/Customer/AddCustomer\" class=\"btn btn-success\">ADD</a>\r\n\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
