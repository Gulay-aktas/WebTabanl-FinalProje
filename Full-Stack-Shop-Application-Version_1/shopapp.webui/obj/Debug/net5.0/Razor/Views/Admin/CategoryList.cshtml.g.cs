#pragma checksum "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7e5593ec847f630d5d1aeea3bed491c048bf87f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryList), @"mvc.1.0.view", @"/Views/Admin/CategoryList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e5593ec847f630d5d1aeea3bed491c048bf87f", @"/Views/Admin/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf6643d11f24c1a9db4b2ce2d237e0d4499f410", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
  
    Layout="_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-2"">
    <h2>Admin Kategoriler</h2>
    <hr>
    <div class=""mb-3 d-flex align-items-end"">
        <a href=""/admin/panel"" class=""btn btn-secondary btn-sm ""><i class=""fas fa-arrow-circle-left""></i> Panele Geri Dön</a>
        <i class=""fal fa-grip-lines-vertical mx-1"" style=""font-size: 28px;""></i>
        <a href=""/admin/category/create""");
            BeginWriteAttribute("class", " class=\"", 420, "\"", 490, 4);
            WriteAttributeValue("", 428, "btn", 428, 3, true);
            WriteAttributeValue(" ", 431, "btn-primary", 432, 12, true);
            WriteAttributeValue(" ", 443, "btn-sm", 444, 7, true);
#nullable restore
#line 12 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
WriteAttributeValue(" ", 450, User.IsInRole("admin")?"":"disabled", 451, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-plus-circle\"></i> Kategori Ekle</a>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-12 col-sm-6 col-lg-8 order-2\">\n");
#nullable restore
#line 17 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
             if (TempData["message"] != null)
            {
                var message = JsonConvert.DeserializeObject<AlertMessage>(TempData["message"] as String);
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
           Write(await Html.PartialAsync("_alert", message));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
                                                           ;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"card col-12 col-sm-6 col-lg-3 mb-3 order-1 p-0 cardInformation\">\n            <div class=\"card-header\">Kategori Bilgileri</div>\n            <div class=\"card-body\">\n                <h6>Toplam Kategori: ");
#nullable restore
#line 26 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
                                Write(Model.Categories.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
            </div>
        </div>
    </div>

    <div class=""table-responsive-sm"">
        <table class=""table table-bordered table-hover"">
            <thead class=""table-secondary"">
                <tr>
                    <th style=""width: 50px;"">Id</th>
                    <th>İsim</th>
                    <th>Url</th>
                    <th style=""width: 130px;"">İşlemler</th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 43 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
                 foreach (var item in Model.Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 46 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
                       Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 47 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 48 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
                       Write(item.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1886, "\"", 1930, 2);
            WriteAttributeValue("", 1893, "/admin/category/edit/", 1893, 21, true);
#nullable restore
#line 50 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 1914, item.CategoryId, 1914, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 1945, "\"", 2015, 4);
            WriteAttributeValue("", 1953, "btn", 1953, 3, true);
            WriteAttributeValue(" ", 1956, "btn-primary", 1957, 12, true);
            WriteAttributeValue(" ", 1968, "btn-sm", 1969, 7, true);
#nullable restore
#line 50 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
WriteAttributeValue(" ", 1975, User.IsInRole("admin")?"":"disabled", 1976, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Düzenle</a>\n                            <button data-target=\"/admin/CategoryDelete/");
#nullable restore
#line 51 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
                                                                  Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 2117, "\"", 2218, 6);
            WriteAttributeValue("", 2125, "btn", 2125, 3, true);
            WriteAttributeValue(" ", 2128, "btn-danger", 2129, 11, true);
            WriteAttributeValue(" ", 2139, "btn-sm", 2140, 7, true);
            WriteAttributeValue(" ", 2146, "d-inline", 2147, 9, true);
            WriteAttributeValue(" ", 2155, "categoryDeleteModalBtn", 2156, 23, true);
#nullable restore
#line 51 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
WriteAttributeValue(" ", 2178, User.IsInRole("admin")?"":"disabled", 2179, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""modal"" data-bs-target=""#categoryDeleteModal"">Sil</button>

                            <div class=""modal fade"" id=""categoryDeleteModal"" data-bs-backdrop=""static"">
                                <div class=""modal-dialog"">
                                    <div class=""modal-content"">

                                        <div class=""modal-header bg-danger text-white"">
                                            <h4 class=""modal-title"">Kategori Silinsin mi ?</h4>
                                            <button type=""button"" class=""btn-close btn-close-white text-white"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                                        </div>
                                        
                                        <div class=""modal-body text-center"">
                                                <i class=""bi bi-x-octagon-fill text-danger"" style=""font-size: 35px;""></i>
                                                
                                    ");
            WriteLiteral(@"            <p class=""modalBodyText""> <strong>Dikkat !</strong> Bu kategoriyi kalıcı olarak silmek istediğinize emin misiniz ?</p>
                                        </div>

                                        <div class=""modal-footer"">
                                            <button class=""btn btn-secondary"" data-bs-dismiss=""modal""><i class=""fas fa-arrow-circle-left""></i> Vazgeç</button>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 3694, "\"", 3701, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger categoryDeleteButon""><i class=""far fa-trash-alt""></i> Sil</a>
                                        </div>

                                    </div>
                                </div>
                            </div>

                        </td>
                    </tr>
");
#nullable restore
#line 79 "C:\Users\Serap\Desktop\Full-Stack-Shop-Application-Version_1\Full-Stack-Shop-Application-Version_1\shopapp.webui\Views\Admin\CategoryList.cshtml"
                }                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591