#pragma checksum "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95444846850320c74c74c36aebae7de5335b7894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_EditCustomer), @"mvc.1.0.view", @"/Views/Customer/EditCustomer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95444846850320c74c74c36aebae7de5335b7894", @"/Views/Customer/EditCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528ff14f7e118acc0eb7c763f2db4cb5be1a910f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_EditCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
  
    ViewData["Title"] = "EditCustomer";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
 using (Html.BeginForm("EditCustomer", "Customer", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-6\">\r\n    ");
#nullable restore
#line 10 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 12 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.Label("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.TextAreaFor(x => x.FirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 15 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.Label("Last Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 16 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.TextAreaFor(x => x.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 18 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.Label("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.TextAreaFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 21 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.Label("TC ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 22 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.TextAreaFor(x => x.TCID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 24 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.Label("Birthdate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 25 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.TextAreaFor(x => x.Birthdate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 27 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.Label("Gsm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 28 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.TextAreaFor(x => x.Gsm, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 30 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.Label("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 31 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.TextAreaFor(x => x.Status, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 33 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.Label("Creation Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 34 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"
Write(Html.TextAreaFor(x => x.CreationDate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n\r\n    <button type=\"submit\" class=\"btn btn-success\">Save</button>\r\n    <button class=\"btn btn-dark\">Cancel</button>\r\n</div>\r\n");
#nullable restore
#line 40 "C:\Users\esragul.alpar\Desktop\PortalStore\PortalStore\PortalStore\Views\Customer\EditCustomer.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591