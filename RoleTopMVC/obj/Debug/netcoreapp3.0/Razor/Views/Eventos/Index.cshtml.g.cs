#pragma checksum "C:\Users\48171009824\Desktop\RoleTopMVC\RoleTopMVC\Views\Eventos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57f33650edf1b58d725f8bc1d3d3c0d937836fa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_Index), @"mvc.1.0.view", @"/Views/Eventos/Index.cshtml")]
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
#line 1 "C:\Users\48171009824\Desktop\RoleTopMVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\48171009824\Desktop\RoleTopMVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f33650edf1b58d725f8bc1d3d3c0d937836fa9", @"/Views/Eventos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.EventoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<main>\r\n    <section id=\"titulo\">\r\n        <h1>Eventos</h1>\r\n    </section>\r\n        <div class=\"servicos\">\r\n");
#nullable restore
#line 8 "C:\Users\48171009824\Desktop\RoleTopMVC\RoleTopMVC\Views\Eventos\Index.cshtml"
         foreach (var item in @Model.Eventos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div id=\"fotoseventos\">\r\n                <div id=\"pai\">\r\n                <a><img");
            BeginWriteAttribute("src", " src=\"", 296, "\"", 321, 1);
#nullable restore
#line 11 "C:\Users\48171009824\Desktop\RoleTopMVC\RoleTopMVC\Views\Eventos\Index.cshtml"
WriteAttributeValue("", 302, item.URLFotoPerfil, 302, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"imagestratadas\"");
            BeginWriteAttribute("alt", " alt=\"", 345, "\"", 374, 2);
            WriteAttributeValue("", 351, "Evento", 351, 6, true);
#nullable restore
#line 11 "C:\Users\48171009824\Desktop\RoleTopMVC\RoleTopMVC\Views\Eventos\Index.cshtml"
WriteAttributeValue(" ", 357, item.NomeEvento, 358, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 375, "\"", 406, 2);
            WriteAttributeValue("", 383, "Evento", 383, 6, true);
#nullable restore
#line 11 "C:\Users\48171009824\Desktop\RoleTopMVC\RoleTopMVC\Views\Eventos\Index.cshtml"
WriteAttributeValue(" ", 389, item.NomeEvento, 390, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                <h3>");
#nullable restore
#line 12 "C:\Users\48171009824\Desktop\RoleTopMVC\RoleTopMVC\Views\Eventos\Index.cshtml"
               Write(item.NomeEvento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <!-- <p>Conte com nossa experiência de 35 anos<br>para o dia mais especial da sua vida.</p>  DESCRIÇAO-->\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57f33650edf1b58d725f8bc1d3d3c0d937836fa95801", async() => {
                WriteLiteral("<em>Saiba Mais</em>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>   \r\n");
#nullable restore
#line 17 "C:\Users\48171009824\Desktop\RoleTopMVC\RoleTopMVC\Views\Eventos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\48171009824\Desktop\RoleTopMVC\RoleTopMVC\Views\Eventos\Index.cshtml"
         if(@Model.Eventos.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <section id=\"titulo\">\r\n                        <h4 style=\"padding:0 0 44.3em 0\">Nenhum Evento</h4>\r\n                    </section>\r\n");
#nullable restore
#line 23 "C:\Users\48171009824\Desktop\RoleTopMVC\RoleTopMVC\Views\Eventos\Index.cshtml"
                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
