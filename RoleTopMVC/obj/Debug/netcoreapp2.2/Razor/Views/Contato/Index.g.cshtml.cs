#pragma checksum "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c5f85ea0ae5621f99ed9f3581abbcfd2b133f3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contato/Index.cshtml", typeof(AspNetCore.Views_Contato_Index))]
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
#line 1 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c5f85ea0ae5621f99ed9f3581abbcfd2b133f3c", @"/Views/Contato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.EventoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 119, true);
            WriteLiteral("\r\n<main>\r\n    <div id=\"contato\">\r\n        <div id=\"formulario\">\r\n            <h2>Solicitar Orçamento</h2>\r\n            ");
            EndContext();
            BeginContext(165, 2047, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c5f85ea0ae5621f99ed9f3581abbcfd2b133f3c4215", async() => {
                BeginContext(213, 1094, true);
                WriteLiteral(@"
                <div class=""form-test"">
                    <label for=""name"">Nome</label>
                    <input type=""text"" placeholder=""Fulano Ciclano"">
                </div>
                
                <div class=""form-test"">
                    <label for=""email"">Email</label>
                    <input type=""text"" placeholder=""roletop@hotmail.com"" required>
                </div class=""form-test"">
            
                <div class=""form-test"">
                    <label for=""telefone"">Telefone</label>
                    <input type=""text"" placeholder=""(11) 91234-5678"" pattern=""[0-9]{2} [9]{1}[0-9]{4}-[0-9]{4}"">
                </div>

                <div class=""form-test"">
                    <label for=""telefone"">Dia do Evento</label>
                    <input type=""date"" placeholder="""" pattern=""[0-9]{2} [9]{1}[0-9]{4}-[0-9]{4}"">
                </div>

                <div class=""form-test"">
                    <label for=""evento"">Tipo de Evento</label>
     ");
                WriteLiteral("               <select id=\"evento\" required>\r\n                        ");
                EndContext();
                BeginContext(1307, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c5f85ea0ae5621f99ed9f3581abbcfd2b133f3c5772", async() => {
                    BeginContext(1342, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1360, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Contato\Index.cshtml"
                         foreach (var evento in Model.Eventos)
                        {

#line default
#line hidden
                BeginContext(1453, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1481, 112, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c5f85ea0ae5621f99ed9f3581abbcfd2b133f3c8241", async() => {
                    BeginContext(1508, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(1543, 11, false);
#line 35 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Contato\Index.cshtml"
                           Write(evento.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1554, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 34 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Contato\Index.cshtml"
                              WriteLiteral(evento.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1593, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 37 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Contato\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1622, 583, true);
                WriteLiteral(@"                    </select>
                </div>

                <div class=""form-test"">
                    <label for=""numeroConvidados"">Número de Convidados</label>
                    <input type=""text"" placeholder="""" >
                </div>
                
                <div class=""form-test"">
                    <label >Sua Mensagem</label>
                    <textarea></textarea>
                </div>
                
                <div id=""enviar"">
                    <button type=""submit"">Enviar</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 7 "C:\Users\48171009824\Documents\RoleTopMVC\RoleTopMVC\Views\Contato\Index.cshtml"
AddHtmlAttributeValue("", 193, Url.Action("",""), 193, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2212, 2635, true);
            WriteLiteral(@" 
        </div>

        <div id=""localizacao"">
            <div id=""mapa"">
                <h2>Localização</h2>
                <iframe src=""https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d914.4715869505721!2d-46.6466504!3d-23.5365898!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xb23619858bc7e63e!2sEscola%20SENAI%20de%20Inform%C3%A1tica!5e0!3m2!1spt-BR!2sbr!4v1574233948222!5m2!1spt-BR!2sbr"" width=""670"" height=""395"" frameborder=""0"" style=""border:0;"" allowfullscreen=""""></iframe>
            </div>

            <div id=""informacoes"">
                <div class=""informacao"">
                    <div class=""icones"">
                        <i class=""fas fa-home fa-lg""></i>
                        <p>Rua: Alameda Barão de Limeira, 132</p>
                    </div>
                    <div class=""icones"">
                        <i class=""fas fa-map-marker-alt fa-lg""></i>
                         <p>Campos Elíseos,  São Paulo - SP</p>
                    </div>
                    <div class=""");
            WriteLiteral(@"icones"">
                        <i class=""fas fa-search fa-lg""></i>
                        <p>CEP: 01202-000 </p>
                    </div>
                </div>
                <div class=""informacao"">
                    <div class=""icones"">
                        <i class=""fab fa-whatsapp fa-lg""></i>
                        <p>(11) 98574-8485 </p>
                    </div>
                    <div class=""icones"">
                        <i class=""fas fa-phone fa-lg""></i>
                        <p>(11) 4002-8922</p>
                    </div>
                    <div class=""icones"">
                        <i class=""fas fa-envelope fa-lg""></i>
                       <p>emaildecontato@hotmail.com</p>
                    </div>
                </div>
            </div>

            <div id=""faq"">
                <h2>Perguntas Frequentes</h2>
                <button class=""accordion"">Pergunta 1</button>
                <div class=""panel"">
                    <p>Lorem ipsum...</p");
            WriteLiteral(@">
                </div>
                <button class=""accordion"">Pergunta 2</button>
                <div class=""panel"">
                    <p>Lorem ipsum...</p>
                </div>
                <button class=""accordion"">Pergunta 3</button>
                <div class=""panel"">
                    <p>Lorem ipsum...</p>
                </div>
                <button class=""accordion"">Pergunta 4</button>
                <div class=""panel"">
                    <p>Lorem ipsum...</p>
                </div>
            </div>
        </div>
    </div>
</main>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
