#pragma checksum "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce2b663abfd644f4ba16b85ecc6b36439e16da1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2b663abfd644f4ba16b85ecc6b36439e16da1e", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7d1b39857e58ad58f2ff12973d600cce7c27b0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SanalSatis.WebUI.Models.VehicleAndBrandListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(145, 128, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <h2>Ürün Listesi</h2>\r\n            ");
            EndContext();
            BeginContext(273, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4760f0f2f7848ee90834f046185821b", async() => {
                BeginContext(347, 15, true);
                WriteLiteral("Yeni Marka Ekle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(366, 476, true);
            WriteLiteral(@"
        </div>
        <div class=""row"">
            <table class=""table table-striped table-bordered"">
                <tr>
                    <td>Marka Adı</td>
                    <td>Ülke</td>
                    <td>En çok Satan Model</td>
                    <td>Marka Piyasa Değeri</td>
                    <td>Toplam Çalışan</td>
                    <td>Lokasyon</td>
                    <td></td>
                    <td></td>
                </tr>

");
            EndContext();
#line 26 "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml"
                 foreach (var product in Model.Vehicles)
                {

#line default
#line hidden
            BeginContext(919, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(974, 17, false);
#line 29 "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml"
                       Write(product.BrandName);

#line default
#line hidden
            EndContext();
            BeginContext(991, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1027, 15, false);
#line 30 "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml"
                       Write(product.Country);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1078, 18, false);
#line 31 "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml"
                       Write(product.BestSeller);

#line default
#line hidden
            EndContext();
            BeginContext(1096, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1132, 34, false);
#line 32 "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml"
                       Write(product.MarketValue.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1202, 21, false);
#line 33 "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml"
                       Write(product.PersonelCount);

#line default
#line hidden
            EndContext();
            BeginContext(1223, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1259, 16, false);
#line 34 "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml"
                       Write(product.Locasyon);

#line default
#line hidden
            EndContext();
            BeginContext(1275, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1340, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55c38203e0a44d18be3a5cbe8af46e1", async() => {
                BeginContext(1453, 7, true);
                WriteLiteral("Düzenle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml"
                                                                                                               WriteLiteral(product.BrandId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1464, 237, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-xs btn-danger DeleteItem\" id=\"DeleteItem\" data-target=\"#basic2\" data-toggle=\"modal\"\r\n                               data-path2=\"");
            EndContext();
            BeginContext(1702, 66, false);
#line 40 "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml"
                                      Write(Url.Action("Delete", "Admin", new { productId = product.BrandId }));

#line default
#line hidden
            EndContext();
            BeginContext(1768, 71, true);
            WriteLiteral("\">Sil</a>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 44 "C:\Users\SedatErgül\Desktop\özel sağlık sigortası\SanalSatis\SanalSatis.WebUI\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1858, 2021, true);
            WriteLiteral(@"            </table>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""basic"" tabindex=""-1"" role=""basic"" aria-hidden=""true"" style=""display: none;"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true""></button>
                <h4 class=""modal-title"">Sepet Bilgisi</h4>
            </div>
            <div class=""modal-body"">
                Ürün Sepete Eklendi
            </div>
            <div class=""modal-footer"">
                <button id=""btnContinueSales"" type=""button"" class=""btn btn-primary"">Alışverişe Devam Et</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""basic2"" tabindex=""-1"" role=""basic2"" aria-hidden=""true"" style=""display: none;"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=");
            WriteLiteral(@"""close"" data-dismiss=""modal"" aria-hidden=""true""></button>
                <h4 class=""modal-title"">Uyarı</h4>
            </div>
            <div class=""modal-body"">
                Ürün Silinecek Emin misin?
            </div>
            <div class=""modal-footer"">
                <button data-dismiss=""modal"" type=""button"" class=""btn btn-default"">Kapat</button>
                <button id=""btnContinueDelete"" type=""button"" class=""btn btn-primary"">Evet</button>
            </div>
        </div>
    </div>
</div>

<script>
    var path_to_add;
    var path_to_delete;

    $("".AddItem"").click(function (e) {
        path_to_add = $(this).data('path');
    });

    $('#btnContinueSales').click(function () {
        window.location = path_to_add;
    });
    $("".DeleteItem"").click(function (e) {
        path_to_delete = $(this).data('path2');
    });

    $('#btnContinueDelete').click(function () {
        window.location = path_to_delete;
    });
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SanalSatis.WebUI.Models.VehicleAndBrandListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
