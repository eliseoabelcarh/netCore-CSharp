#pragma checksum "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b3943911007495b15d8d0726daab6c6a485abbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetProductosAPI), @"mvc.1.0.view", @"/Views/Home/GetProductosAPI.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b3943911007495b15d8d0726daab6c6a485abbb", @"/Views/Home/GetProductosAPI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f3af84fa591e5b560de313dc5399b428462846", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetProductosAPI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PanelNewTienda.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagenes/imagenDemo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:18rem;height:18rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AgregarACarrito", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 8 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"
  
    ViewData["Title"] = "GetProductosAPI";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Productos - todas las tiendas</h1>\r\n<h4>GetProductosAPI </h4>\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 20 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"
 if (Model.Count() > 0)
{
    foreach (var prod in Model)
    {




#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-secondary mb-3 mr-3 d-inline-block\" style=\"width: 18rem;\">\r\n\r\n\r\n");
#nullable restore
#line 30 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"
              
                if (prod.Imagen1 != null)
                {
                    string imageBase64Data = Convert.ToBase64String(prod.Imagen1);
                    string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("style", " style=\"", 761, "\"", 920, 8);
            WriteAttributeValue("", 769, "background-image:url(", 769, 21, true);
#nullable restore
#line 37 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"
WriteAttributeValue("", 790, imageDataURL, 790, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 803, ");", 803, 2, true);
            WriteAttributeValue(" ", 805, "background-repeat:no-repeat;", 806, 29, true);
            WriteAttributeValue(" ", 834, "background-position:", 835, 21, true);
            WriteAttributeValue(" ", 855, "center", 856, 7, true);
            WriteAttributeValue(" ", 862, "center;background-size:cover;", 863, 30, true);
            WriteAttributeValue(" ", 892, "width:17.9rem;height:18rem;", 893, 28, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 38 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b3943911007495b15d8d0726daab6c6a485abbb7627", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"

                }

            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n            <div class=\"card-header\">\r\n                ");
#nullable restore
#line 52 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"
           Write(Html.DisplayFor(modelProd => prod.NombreProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"card-body\">\r\n                <p class=\"card-text\">");
#nullable restore
#line 56 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"
                                Write(Html.DisplayFor(modelProd => prod.DescripcionProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <div class=\"card-group\">\r\n                    <span class=\"badge badge-secondary h4\">$");
#nullable restore
#line 59 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"
                                                       Write(Html.DisplayFor(modelProd => prod.PrecioProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n\r\n                <div class=\"card-group\">\r\n                    <span class=\"badge badge-info\">Tienda: ");
#nullable restore
#line 63 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"
                                                      Write(service.ObtenerNombreDeTienda(prod.IdTienda));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n\r\n            <div class=\"card-footer\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b3943911007495b15d8d0726daab6c6a485abbb10965", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 74 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new CarritoItemAux { IdProducto = prod.IdProducto };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n        </div>\r\n");
#nullable restore
#line 84 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"


    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div> no hay productos</div>\r\n");
#nullable restore
#line 91 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\GetProductosAPI.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public PanelNewTienda.Services.NewTiendaService service { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PanelNewTienda.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591