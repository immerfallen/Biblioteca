#pragma checksum "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b88c8244a035e49bf16c1f8f1d2475ab5c03ddc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b88c8244a035e49bf16c1f8f1d2475ab5c03ddc4", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empréstimos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88c8244a035e49bf16c1f8f1d2475ab5c03ddc45145", async() => {
                WriteLiteral("\r\n        <div class=\"form-group mb-2\">\r\n            <select name=\"TipoFiltro\" class=\"form-control\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88c8244a035e49bf16c1f8f1d2475ab5c03ddc45529", async() => {
                    WriteLiteral("Usuário");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88c8244a035e49bf16c1f8f1d2475ab5c03ddc46769", async() => {
                    WriteLiteral("Livro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
        </div>
        <div class=""form-group mb-2 mx-sm-3"">
            <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
        </div>
        <button type=""submit"" class=""btn btn-primary mb-2"">Pesquisar</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <table > 
            <thead>
                <tr><th>Id</th>
                <th>Usuario</th>
                <th>Data Empréstimo</th>
                <th>Data Devolução</th>
                <th>Livro</th>
                <th>Autor</th>
                <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 37 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                 foreach(Emprestimo e in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 40 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(e.Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1530, "\"", 1561, 2);
            WriteAttributeValue("", 1537, "/Emprestimo/Edicao/", 1537, 19, true);
#nullable restore
#line 46 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 1556, e.Id, 1556, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 48 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\trabalho\Modificado\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
