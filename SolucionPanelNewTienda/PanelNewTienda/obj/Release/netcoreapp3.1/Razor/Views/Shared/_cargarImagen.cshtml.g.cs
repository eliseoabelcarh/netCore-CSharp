#pragma checksum "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Shared\_cargarImagen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16c5d9d54d521b0bab3ba5983c17d6e9c64374c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__cargarImagen), @"mvc.1.0.view", @"/Views/Shared/_cargarImagen.cshtml")]
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
#line 1 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\_ViewImports.cshtml"
using PanelNewTienda;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\_ViewImports.cshtml"
using PanelNewTienda.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c5d9d54d521b0bab3ba5983c17d6e9c64374c6", @"/Views/Shared/_cargarImagen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f3af84fa591e5b560de313dc5399b428462846", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__cargarImagen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PanelNewTienda.Models.ProdAux>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CargarImagen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Productos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Shared\_cargarImagen.cshtml"
  
    string n1 = Model.IdDeTienda.ToString();
    string n2 = Model.IdDelProducto.ToString();
    string name = n1 + n2;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16c5d9d54d521b0bab3ba5983c17d6e9c64374c64959", async() => {
                WriteLiteral("\r\n\r\n\r\n    <div class=\"card\">\r\n\r\n\r\n\r\n\r\n\r\n        <div class=\"form-group card-body\">\r\n            <label class=\"btn btn-dark\" style=\"cursor: pointer\"");
                BeginWriteAttribute("for", " for=\"", 428, "\"", 439, 1);
#nullable restore
#line 22 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Shared\_cargarImagen.cshtml"
WriteAttributeValue("", 434, name, 434, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Elegir Imagen</label>\r\n            <input style=\"position:absolute; width:0.1px; height:0.1px ;overflow:hidden; opacity:0\" type=\"file\"");
                BeginWriteAttribute("id", " id=\"", 575, "\"", 585, 1);
#nullable restore
#line 23 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Shared\_cargarImagen.cshtml"
WriteAttributeValue("", 580, name, 580, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 586, "\"", 598, 1);
#nullable restore
#line 23 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Shared\_cargarImagen.cshtml"
WriteAttributeValue("", 593, name, 593, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" accept=""image/*"" />
        </div>
        <div class=""form-group"">
            <span id=""nombreArchivo""></span>
        </div>
        <div class=""form-group"">
            <input formaction=""/Productos/CargarImagen"" formmethod=""post"" type=""submit"" value=""Guardar Cambios"" class=""btn btn-primary"" />

        </div>



    </div>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n\r\n\r\n\r\n   \r\n\r\n    var input = document.getElementById(");
#nullable restore
#line 46 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Shared\_cargarImagen.cshtml"
                                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
    input.addEventListener(""change"", function actuar() {
      
        var span = document.getElementById(""nombreArchivo"");
        var file = this.files[0].name;
        span.innerHTML = ""<div>Archivo: "" + file +""</br>. </div>"";

    })

   


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PanelNewTienda.Models.ProdAux> Html { get; private set; }
    }
}
#pragma warning restore 1591
