#pragma checksum "D:\Gaveta\Curso SINQIA .NET\Projeto-AspNet\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6378619ee4152449d88e4ff43bc90cffd764431"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
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
#line 1 "D:\Gaveta\Curso SINQIA .NET\Projeto-AspNet\Views\_ViewImports.cshtml"
using Projeto_Loja_Sapatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Gaveta\Curso SINQIA .NET\Projeto-AspNet\Views\_ViewImports.cshtml"
using Projeto_Loja_Sapatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6378619ee4152449d88e4ff43bc90cffd764431", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e7a2eb063062f5eebd9b0a2317786932c906de3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Gaveta\Curso SINQIA .NET\Projeto-AspNet\Views\Home\Menu.cshtml"
  
    ViewData["Title"] = "Loja Sapatos - Zerg";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6378619ee4152449d88e4ff43bc90cffd7644313399", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Sapatos Zerg</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6378619ee4152449d88e4ff43bc90cffd7644314649", async() => {
                WriteLiteral(@"

    <div class=""bg-success container-fluid p-5 bg-primary text-white text-center"">
        <h1>Loja de Sapatos - Zerg</h1>
        <p>Bem vindo!</p>
    </div>
    <br/>
    <div class=""row"">
        <div class=""card col-sm-2"" style=""width: 17rem;"" id=""card"">
            <img class=""card-img-top"" src=""https://i.ibb.co/zQvG9KD/Sapato-1.jpg"" alt=""Card image cap"">
            <div class=""card-body"">
                <h5 class=""card-title"">Sapato 1</h5>
                <p>R$10,00</p>
                <a href=""#"" class=""btn btn-success"">Mais detalhes aqui</a>
            </div>
        </div>
        <div class=""card col-sm-2"" style=""width: 17rem;"" id=""card"">
            <img class=""card-img-top"" src=""https://i.ibb.co/Hgv6wxT/Sapato-2.jpg"" alt=""Card image cap"">
            <div class=""card-body"">
                <h5 class=""card-title"">Sapato 2</h5>
                <p>R$10,00</p>
                <a href=""#"" class=""btn btn-success"">Mais detalhes aqui</a>
            </div>
        </div>
    ");
                WriteLiteral(@"    <div class=""card col-sm-2"" style=""width: 17rem;"" id=""card"">
            <img class=""card-img-top"" src=""https://i.ibb.co/5GhjX7y/Sapato-3.jpg"" alt=""Card image cap"">
            <div class=""card-body"">
                <h5 class=""card-title"">Sapato 3</h5>
                <p>R$10,00</p>
                <a href=""#"" class=""btn btn-success"">Mais detalhes aqui</a>
            </div>
        </div>
        <div class=""card col-sm-2"" style=""width: 17rem;"" id=""card"">
            <img class=""card-img-top"" src=""https://i.ibb.co/HxrCxnQ/Sapato-4.jpg"" alt=""Card image cap"">
            <div class=""card-body"">
                <h5 class=""card-title"">Sapato 4</h5>
                <p>R$10,00</p>
                <a href=""#"" class=""btn btn-success"">Mais detalhes aqui</a>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
