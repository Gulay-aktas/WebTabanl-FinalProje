#pragma checksum "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_alert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a3252654d5e1c0b178254721d7055b123c6a5c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__alert), @"mvc.1.0.view", @"/Views/Shared/_alert.cshtml")]
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
#line 3 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a3252654d5e1c0b178254721d7055b123c6a5c2", @"/Views/Shared/_alert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf6643d11f24c1a9db4b2ce2d237e0d4499f410", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__alert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlertMessage>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div");
            BeginWriteAttribute("class", " class=\"", 25, "\"", 89, 6);
            WriteAttributeValue("", 33, "alert", 33, 5, true);
            WriteAttributeValue(" ", 38, "alert-", 39, 7, true);
#nullable restore
#line 3 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_alert.cshtml"
WriteAttributeValue("", 45, Model.AlertType, 45, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 61, "alert-dismissible", 62, 18, true);
            WriteAttributeValue(" ", 79, "fade", 80, 5, true);
            WriteAttributeValue(" ", 84, "show", 85, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 4 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_alert.cshtml"
     if (Model.AlertType == "success")
    {        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <svg xmlns=""http://www.w3.org/2000/svg"" width=""18"" height=""18"" fill=""currentColor"" class=""bi bi-check-circle-fill text-success me-2 accountMessageImage"" viewBox=""0 0 16 16"">
            <path d=""M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z""/>
        </svg>
");
#nullable restore
#line 9 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_alert.cshtml"
    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"19\" height=\"19\" fill=\"currentColor\"");
            BeginWriteAttribute("class", " class=\"", 653, "\"", 732, 5);
            WriteAttributeValue("", 661, "bi", 661, 2, true);
            WriteAttributeValue(" ", 663, "bi-exclamation-circle-fill", 664, 27, true);
            WriteAttributeValue(" ", 690, "text-", 691, 6, true);
#nullable restore
#line 10 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_alert.cshtml"
WriteAttributeValue("", 696, Model.AlertType, 696, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 712, "accountMessageImage", 713, 20, true);
            EndWriteAttribute();
            WriteLiteral(" viewBox=\"0 0 16 16\">\n            <path d=\"M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM8 4a.905.905 0 0 0-.9.995l.35 3.507a.552.552 0 0 0 1.1 0l.35-3.507A.905.905 0 0 0 8 4zm.002 6a1 1 0 1 0 0 2 1 1 0 0 0 0-2z\"/>\n        </svg>\n");
#nullable restore
#line 13 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_alert.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <strong>");
#nullable restore
#line 14 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_alert.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> ");
#nullable restore
#line 14 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Shared\_alert.cshtml"
                            Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <button class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlertMessage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591