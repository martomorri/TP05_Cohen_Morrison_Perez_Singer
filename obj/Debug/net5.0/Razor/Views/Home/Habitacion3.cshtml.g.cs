#pragma checksum "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4efa14961235d1d2693d52137fe1dbfcd4ce8704"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Habitacion3), @"mvc.1.0.view", @"/Views/Home/Habitacion3.cshtml")]
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
#line 1 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\_ViewImports.cshtml"
using TP5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\_ViewImports.cshtml"
using TP5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4efa14961235d1d2693d52137fe1dbfcd4ce8704", @"/Views/Home/Habitacion3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b06fb0270ead3c4973f8bf6c0bd73aa0070f600", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Habitacion3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4efa14961235d1d2693d52137fe1dbfcd4ce87043781", async() => {
                WriteLiteral("\r\n    <title>Habitacion 3</title>\r\n");
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
            WriteLiteral(@"
<h1 class=""display-4"">Habitacion 3</h1>
<p>¡Muy bien! Encontraste el código. Ahora tendras que resolver 3 minijuegos de 4 fotos 1 palabra. Cada una de las respuestas tendra que ver ocn el codigo. Separa las tres por un guion - sin espacio. Si logras encontrar el código, pasarás a la última habitacion.</p>
<img src=""/img/nairobi.jpg"">
<p></p>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4efa14961235d1d2693d52137fe1dbfcd4ce87045133", async() => {
                WriteLiteral(@"
    <input type=""hidden"" name=""pregunta"" value=""0"">
    <div class=""form-row"">
        <div class=""col-2"">
            <input required type=""text"" class=""form-control"" name=""incognita"" placeholder=""Respuesta"" size=""20""/>
        </div>
        <div class=""col-2"">
            <input class=""btn btn-outline-light"" type=""submit"" value=""Comprobar"">
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 8 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
AddHtmlAttributeValue("", 426, Url.Action("hab3","Home"), 426, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
  
    if(ViewBag.estado0 == "¡CORRECTO!")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"correcto\">");
#nullable restore
#line 22 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
                       Write(ViewBag.Estado0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 23 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
    }
    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"incorrecto\">");
#nullable restore
#line 25 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
                         Write(ViewBag.Estado0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 26 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("<img src=\"/img/rio.jpg\">\r\n<p></p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4efa14961235d1d2693d52137fe1dbfcd4ce87048941", async() => {
                WriteLiteral(@"
    <input type=""hidden"" name=""pregunta"" value=""1"">
    <div class=""form-row"">
        <div class=""col-2"">
            <input required type=""text"" class=""form-control"" name=""incognita"" placeholder=""Respuesta"" size=""20""/>
        </div>
        <div class=""col-2"">
            <input class=""btn btn-outline-light"" type=""submit"" value=""Comprobar"">
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 30 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
AddHtmlAttributeValue("", 1093, Url.Action("hab3","Home"), 1093, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
  
    if(ViewBag.estado1 == "¡CORRECTO!")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"correcto\">");
#nullable restore
#line 44 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
                       Write(ViewBag.Estado1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 45 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
    }
    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"incorrecto\">");
#nullable restore
#line 47 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
                         Write(ViewBag.Estado1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("<img src=\"/img/denver.jpg\">\r\n<p></p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4efa14961235d1d2693d52137fe1dbfcd4ce870412755", async() => {
                WriteLiteral(@"
    <input type=""hidden"" name=""pregunta"" value=""2"">
    <div class=""form-row"">
        <div class=""col-2"">
            <input required type=""text"" class=""form-control"" name=""incognita"" placeholder=""Respuesta"" size=""20""/>
        </div>
        <div class=""col-2"">
            <input class=""btn btn-outline-light"" type=""submit"" value=""Comprobar"">
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 52 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
AddHtmlAttributeValue("", 1763, Url.Action("hab3","Home"), 1763, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
  
    if(ViewBag.estado2 == "¡CORRECTO!")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"correcto\">");
#nullable restore
#line 66 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
                       Write(ViewBag.Estado2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 67 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
    }
    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"incorrecto\">");
#nullable restore
#line 69 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
                         Write(ViewBag.Estado2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 70 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("<p></p>\r\n<p>CLAVE:</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4efa14961235d1d2693d52137fe1dbfcd4ce870416554", async() => {
                WriteLiteral(@"
    <input type=""hidden"" name=""sala"" value=""3""/>
    <div class=""form-row"">
        <div class=""col-2"">
            <input required type=""text"" class=""form-control"" name=""incognita"" placeholder=""Clave"" size=""20""/>
        </div>
        <div class=""col-2"">
            <input class=""btn btn-outline-light"" type=""submit"" value=""Comprobar"">
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 74 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
AddHtmlAttributeValue("", 2419, Url.Action("Habitacion","Home"), 2419, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<p></p>
<button class=""btn btn-primary"" onclick=""alert('Cada minijuego contiene una parte del codigo final')""> Pista 1 </button>
<button class=""btn btn-primary"" onclick=""alert('Las primeras 3 letras de cada respuesta son partes del codigo')""> Pista 2 </button>
<p class=""incorrecto"">");
#nullable restore
#line 88 "C:\Users\marto\Documents\MARTIN ORT\4IB\Programacion 4IB\TP05_Cohen_Morrison_Perez_Singer\Views\Home\Habitacion3.cshtml"
                 Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
