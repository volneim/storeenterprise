#pragma checksum "C:\Users\vrmpr\OneDrive\Documentos\Projetos\Treinamento\WebApiEnterprise\NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Pedido\_ResumoFinanceiro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "279a9b81c7f33717627c4a401bd8d19796d60c57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido__ResumoFinanceiro), @"mvc.1.0.view", @"/Views/Pedido/_ResumoFinanceiro.cshtml")]
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
#line 1 "C:\Users\vrmpr\OneDrive\Documentos\Projetos\Treinamento\WebApiEnterprise\NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\_ViewImports.cshtml"
using NSE.WebApp.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vrmpr\OneDrive\Documentos\Projetos\Treinamento\WebApiEnterprise\NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\_ViewImports.cshtml"
using NSE.WebApp.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\vrmpr\OneDrive\Documentos\Projetos\Treinamento\WebApiEnterprise\NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Pedido\_ResumoFinanceiro.cshtml"
using NSE.WebApp.MVC.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"279a9b81c7f33717627c4a401bd8d19796d60c57", @"/Views/Pedido/_ResumoFinanceiro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d98b721f55057ac795973b9ba0afeeb6ca1d76", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido__ResumoFinanceiro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NSE.WebApp.MVC.Models.PedidoTransacaoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<article class=\"card-body border-top\">\r\n    <dl class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\vrmpr\OneDrive\Documentos\Projetos\Treinamento\WebApiEnterprise\NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Pedido\_ResumoFinanceiro.cshtml"
          
            if (Model.VoucherUtilizado)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-10\">Subtotal: <span class=\"float-right text-muted\">");
#nullable restore
#line 9 "C:\Users\vrmpr\OneDrive\Documentos\Projetos\Treinamento\WebApiEnterprise\NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Pedido\_ResumoFinanceiro.cshtml"
                                                                            Write(Model.Itens.Sum(i => i.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral(" itens</span></dt>\r\n            <dd class=\"col-sm-2 text-right\">\r\n                <strong>");
#nullable restore
#line 11 "C:\Users\vrmpr\OneDrive\Documentos\Projetos\Treinamento\WebApiEnterprise\NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Pedido\_ResumoFinanceiro.cshtml"
                   Write(this.FormatoMoeda(Model.ValorTotal + Model.Desconto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </dd>\r\n");
            WriteLiteral("            <dt class=\"col-sm-10\">Desconto: <span class=\"float-right text-muted\">");
#nullable restore
#line 14 "C:\Users\vrmpr\OneDrive\Documentos\Projetos\Treinamento\WebApiEnterprise\NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Pedido\_ResumoFinanceiro.cshtml"
                                                                            Write(Model.VoucherCodigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></dt>\r\n            <dd class=\"col-sm-2 text-danger text-right\">\r\n                <strong>");
#nullable restore
#line 16 "C:\Users\vrmpr\OneDrive\Documentos\Projetos\Treinamento\WebApiEnterprise\NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Pedido\_ResumoFinanceiro.cshtml"
                   Write(this.FormatoMoeda(Model.Desconto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </dd>\r\n");
#nullable restore
#line 18 "C:\Users\vrmpr\OneDrive\Documentos\Projetos\Treinamento\WebApiEnterprise\NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Pedido\_ResumoFinanceiro.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-10\">Total:</dt>\r\n        <dd class=\"col-sm-2 text-right\">\r\n            <strong class=\"h5 text-dark\">");
#nullable restore
#line 22 "C:\Users\vrmpr\OneDrive\Documentos\Projetos\Treinamento\WebApiEnterprise\NerdStoreEnterprise\src\web\NSE.WebApp.MVC\Views\Pedido\_ResumoFinanceiro.cshtml"
                                    Write(this.FormatoMoeda(Model.ValorTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        </dd>\r\n    </dl>\r\n</article>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NSE.WebApp.MVC.Models.PedidoTransacaoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
