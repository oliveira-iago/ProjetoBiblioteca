#pragma checksum "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34c428f58dfcd1da7776e758f573283e24363cca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListaUsuarios.cshtml")]
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
#line 1 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34c428f58dfcd1da7776e758f573283e24363cca", @"/Views/Usuario/ListaUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListaUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"text-center\">Usuários cadastrados no sistema</h1>\r\n<p class=\"text-center text-danger\">");
#nullable restore
#line 4 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                              Write(ViewData["mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<a style=\"padding: 10px;\" href=\"CadastrarUsuario\">Cadastrar um novo usuário</a>\r\n<br/><br/>\r\n<!-- Tabela-->\r\n<table class=\"table\">\r\n    <!-- Se houverem valores na tabela-->\r\n");
#nullable restore
#line 11 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
     if(Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!-- Cabeçalho -->
        <thead>
            <!-- Linha -->
            <tr>
                <!-- Colunas -->
                <th scope=""row"">Nome</th>
                <th scope=""row"">Login</th>
                <th scope=""row"">Tipo</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
");
#nullable restore
#line 25 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br><br>\r\n        <h4 class=\"text-center\">Não há valores para serem exibidos</h4>\r\n");
#nullable restore
#line 30 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- Corpo -->\r\n    <tbody>\r\n        <!-- Loop onde são preenchidos os usuários -->\r\n");
#nullable restore
#line 35 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
         foreach(Usuario usuario in Model)
        {
            //Linha

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <!--Colunas-->\r\n                <td>");
#nullable restore
#line 40 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
               Write(usuario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
               Write(usuario.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <!--Se o usuario for admin-->\r\n");
#nullable restore
#line 44 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                 if (usuario.Tipo == Usuario.admin)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 47 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\r\n");
#nullable restore
#line 51 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!-- Campos de edição e exclusão-->\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1482, "\"", 1517, 2);
            WriteAttributeValue("", 1489, "EditarUsuario?id=", 1489, 17, true);
#nullable restore
#line 54 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
WriteAttributeValue("", 1506, usuario.Id, 1506, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1558, "\"", 1594, 2);
            WriteAttributeValue("", 1565, "ExcluirUsuario?id=", 1565, 18, true);
#nullable restore
#line 55 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
WriteAttributeValue("", 1583, usuario.Id, 1583, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\iagol\OneDrive\Pastas\Estudos\SENAC\01. Aulas\2021\09. Dez - Manutenção de Projetos Web\Atividade 02\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
