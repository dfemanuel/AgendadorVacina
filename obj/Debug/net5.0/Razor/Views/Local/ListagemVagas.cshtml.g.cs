#pragma checksum "C:\Users\emanueldantas\Desktop\Emanuel\Estudos\uni7\Integração Contínua\AgendadorVacina\Views\Local\ListagemVagas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03775838e19ff8e69d04094a305bf28c34371874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Local_ListagemVagas), @"mvc.1.0.view", @"/Views/Local/ListagemVagas.cshtml")]
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
#line 1 "C:\Users\emanueldantas\Desktop\Emanuel\Estudos\uni7\Integração Contínua\AgendadorVacina\Views\_ViewImports.cshtml"
using AgendadorVacina;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emanueldantas\Desktop\Emanuel\Estudos\uni7\Integração Contínua\AgendadorVacina\Views\_ViewImports.cshtml"
using AgendadorVacina.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03775838e19ff8e69d04094a305bf28c34371874", @"/Views/Local/ListagemVagas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b54996958fab0edfda6292681def1657f875f0e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Local_ListagemVagas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AgendadorVacina.Models.Local>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emanueldantas\Desktop\Emanuel\Estudos\uni7\Integração Contínua\AgendadorVacina\Views\Local\ListagemVagas.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Quantidades Vagas do Posto</h2>\r\n\r\n<ul>\r\n");
#nullable restore
#line 10 "C:\Users\emanueldantas\Desktop\Emanuel\Estudos\uni7\Integração Contínua\AgendadorVacina\Views\Local\ListagemVagas.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 12 "C:\Users\emanueldantas\Desktop\Emanuel\Estudos\uni7\Integração Contínua\AgendadorVacina\Views\Local\ListagemVagas.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "C:\Users\emanueldantas\Desktop\Emanuel\Estudos\uni7\Integração Contínua\AgendadorVacina\Views\Local\ListagemVagas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgendadorVacina.Models.Local> Html { get; private set; }
    }
}
#pragma warning restore 1591