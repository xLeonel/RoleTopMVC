#pragma checksum "C:\Users\48171009824\Desktop\RoleTopMVC\Views\SobreNos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d57f127c3e219448374bd7df78b1c8245bc29038"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SobreNos_Index), @"mvc.1.0.view", @"/Views/SobreNos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SobreNos/Index.cshtml", typeof(AspNetCore.Views_SobreNos_Index))]
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
#line 1 "C:\Users\48171009824\Desktop\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\48171009824\Desktop\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57f127c3e219448374bd7df78b1c8245bc29038", @"/Views/SobreNos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_SobreNos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.BaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/fachadaFirma.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 128, true);
            WriteLiteral("\r\n<main>\r\n    <section id=\"titulo-servicos\">\r\n        <h1>Sobre Nós</h1>\r\n    </section>\r\n\r\n    <div id=\"fotoFachada\">\r\n        ");
            EndContext();
            BeginContext(172, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "548aa45b6f564c1e8318d8bd088b0791", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(206, 667, true);
            WriteLiteral(@"
    </div>

    <section id=""aboutUs"">
        <p>Um espaço consolidado e responsável pela realização de eventos de grande prestígio em São Paulo. RolêTop tem forte presença no mercado pela qualidade dos produtos e serviços que oferece.</p>
        <p>Trabalhamos nos melhores  espaços , em regiões importantes da cidade; Contamos também com o serviço de som e iluminação se solicitados por nossos clientes. Nosso trabalho conquistou famílias e grandes empresas, não só pela excelência, mas pelo envolvimento que temos com cada festa que realizamos.</p>
    </section>

    <div id=""depoimentos"" >
        <h2 style=""padding:10px 0 5px 0"">Depoimentos</h2>
");
            EndContext();
#line 19 "C:\Users\48171009824\Desktop\RoleTopMVC\Views\SobreNos\Index.cshtml"
         foreach (var item in @Model.Depoimentos)
        {  

#line default
#line hidden
            BeginContext(937, 100, true);
            WriteLiteral("            <div id=\"foto-perfil-container\" class=\"mySlides\">\r\n                <img id=\"foto-perfil\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1037, "\"", 1070, 1);
#line 22 "C:\Users\48171009824\Desktop\RoleTopMVC\Views\SobreNos\Index.cshtml"
WriteAttributeValue("", 1043, item.Cliente.URLFotoPerfil, 1043, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1071, 43, true);
            WriteLiteral(" alt=\"foto_perfil\" />\r\n                <h3>");
            EndContext();
            BeginContext(1115, 17, false);
#line 23 "C:\Users\48171009824\Desktop\RoleTopMVC\Views\SobreNos\Index.cshtml"
               Write(item.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 55, true);
            WriteLiteral("</h3>\r\n                <p style=\"padding:5px 0 15px 0\">");
            EndContext();
            BeginContext(1188, 13, false);
#line 24 "C:\Users\48171009824\Desktop\RoleTopMVC\Views\SobreNos\Index.cshtml"
                                           Write(item.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 26, true);
            WriteLiteral("</p>\r\n            </div>\r\n");
            EndContext();
#line 26 "C:\Users\48171009824\Desktop\RoleTopMVC\Views\SobreNos\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1238, 1049, true);
            WriteLiteral(@"    </div>  
            
    <div id=""conquest"">
        <h2 style=""padding:10px 0 5px 0"" >Conquistas</h2>
        <div id=""diferencial"">
            <div class=""conquistas"" style=""padding: 0 20px 0 0"">
                <i class=""fas fa-trophy fa-3x""></i>
                <em><p style=""color:black"">Melhor espaço SP</p></em> 
            </div>
            <div class=""conquistas"" style=""padding: 0 0 0 20px"">
                <i class=""fas fa-clipboard-check fa-3x""></i>
                <em><p style=""color:black"">+1 mil de eventos</p></em> 
            </div>
        </div> 
    </div>

</main>

<script>
    var slideIndex = 1;
    showSlides();

function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName(""mySlides"");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = ""none"";
  }
  slideIndex++;
  if (slideIndex > slides.length) {slideIndex = 1}
  slides[slideIndex-1].style.display = ""block"";
  setTimeout(showSlides, 5500); // Change image ever");
            WriteLiteral("y 2 seconds\r\n}\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.BaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591