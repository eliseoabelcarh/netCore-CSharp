#pragma checksum "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70511e45da1d8d7b9452cd884647640250dcbdd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Checkout), @"mvc.1.0.view", @"/Views/Home/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70511e45da1d8d7b9452cd884647640250dcbdd4", @"/Views/Home/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f3af84fa591e5b560de313dc5399b428462846", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PanelNewTienda.Models.CarritoItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetProductosAPI", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagenes/imagenDemo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:3rem;height:3rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PedirPorWhatsapp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
  
    ViewData["Title"] = "CarritoDeCompras";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Checkout</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70511e45da1d8d7b9452cd884647640250dcbdd47696", async() => {
                WriteLiteral("Seguir comprando");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 13 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
 if (Model.Count() <= 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>No hay Productos en tu Carrito</div>\r\n");
#nullable restore
#line 17 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"

}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70511e45da1d8d7b9452cd884647640250dcbdd49652", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 27 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
         foreach (var nroTienda in @ViewBag.listaNrosTiendas)
        {
            double totalTienda = 0;



#line default
#line hidden
#nullable disable
                WriteLiteral("            <table class=\"table table-striped table-responsive table-body\">\r\n\r\n                <thead>\r\n                    <tr>\r\n                        <th scope=\"col\"> Vendedor</th>\r\n                        <th scope=\"col\">  ");
#nullable restore
#line 37 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                                     Write(Html.DisplayNameFor(model => Model[0].Producto));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th scope=\"col\">");
#nullable restore
#line 38 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                                   Write(Html.DisplayNameFor(model => Model[0].Cantidad));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th scope=\"col\"> ");
#nullable restore
#line 39 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                                    Write(Html.DisplayNameFor(model => Model[0].PrecioCarritoItem));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n\r\n\r\n");
#nullable restore
#line 45 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                 for (var i = 0; i < Model.Count(); i++)
                {





                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                     if (@Model[i].IdTienda == nroTienda)
                    {







#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tbody>\r\n\r\n\r\n\r\n\r\n                            <tr>\r\n\r\n                                <th scope=\"row\">\r\n\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70511e45da1d8d7b9452cd884647640250dcbdd412358", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 69 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].IdTienda);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    Tienda ");
#nullable restore
#line 70 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                                      Write(Html.DisplayFor(modelItem => @Model[i].IdTienda));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                </th>\r\n\r\n                                <td>\r\n\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70511e45da1d8d7b9452cd884647640250dcbdd414545", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 76 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].Producto.Imagen1);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <div class=\"d-flex flex-row\">\r\n");
#nullable restore
#line 78 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                                          
                                            if (@Model[i].Producto.Imagen1 != null)
                                            {
                                                string imageBase64Data = Convert.ToBase64String(@Model[i].Producto.Imagen1);
                                                string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);



#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <div class=\"p-2 mr-2\"");
                BeginWriteAttribute("style", " style=\"", 2345, "\"", 2502, 8);
                WriteAttributeValue("", 2353, "background-image:url(", 2353, 21, true);
#nullable restore
#line 85 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
WriteAttributeValue("", 2374, imageDataURL, 2374, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2387, ");", 2387, 2, true);
                WriteAttributeValue(" ", 2389, "background-repeat:no-repeat;", 2390, 29, true);
                WriteAttributeValue(" ", 2418, "background-position:", 2419, 21, true);
                WriteAttributeValue(" ", 2439, "center", 2440, 7, true);
                WriteAttributeValue(" ", 2446, "center;background-size:cover;", 2447, 30, true);
                WriteAttributeValue(" ", 2476, "width:2.9rem;height:3rem;", 2477, 26, true);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n");
#nullable restore
#line 86 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "70511e45da1d8d7b9452cd884647640250dcbdd418449", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 90 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"

                                            }

                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70511e45da1d8d7b9452cd884647640250dcbdd420138", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 95 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].Producto.IdProducto);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 96 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                                   Write(Html.DisplayFor(modelItem => @Model[i].Producto.NombreProducto));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70511e45da1d8d7b9452cd884647640250dcbdd422387", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 102 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].Cantidad);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 103 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                               Write(Html.DisplayFor(modelItem => @Model[i].Cantidad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n\r\n                                    ");
#nullable restore
#line 108 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                               Write(Html.DisplayFor(modelItem => @Model[i].PrecioCarritoItem));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 109 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                                      totalTienda += @Model[i].PrecioCarritoItem;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </td>\r\n\r\n                                <td>\r\n                                </td>\r\n\r\n                            </tr>\r\n\r\n\r\n\r\n\r\n                        </tbody>\r\n");
#nullable restore
#line 121 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"




                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                     




                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                <tfoot>\r\n                    <tr>\r\n                        <td></td>\r\n                        <td></td>\r\n                        <th scope=\"row\">Total:</th>\r\n                        <th scope=\"row\">");
#nullable restore
#line 138 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                                   Write(totalTienda);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <td>\r\n                          \r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70511e45da1d8d7b9452cd884647640250dcbdd426419", async() => {
                    WriteLiteral("Pedir por Wsp");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 141 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"
                                                                                                             WriteLiteral(nroTienda);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n\r\n            </table>\r\n");
                WriteLiteral("            <br />\r\n");
#nullable restore
#line 151 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 156 "D:\ORT\netCore-CSharp\SolucionPanelNewTienda\PanelNewTienda\Views\Home\Checkout.cshtml"



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PanelNewTienda.Models.CarritoItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591