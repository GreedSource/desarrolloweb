#pragma checksum "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Home\Sopa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60f2f933f861b3ca7f555eb909df1fae43650b1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sopa), @"mvc.1.0.view", @"/Views/Home/Sopa.cshtml")]
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
#line 1 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\_ViewImports.cshtml"
using desarrolloweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\_ViewImports.cshtml"
using desarrolloweb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60f2f933f861b3ca7f555eb909df1fae43650b1f", @"/Views/Home/Sopa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5678c6a96673004094b629d7c22a40a890cdd1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sopa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("generarInput(event, this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("postData(event, this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-dinamic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Home\Sopa.cshtml"
  
    ViewData["Title"] = "Sopa de letras";
    Layout = "~/Views/Shared/_MasterView.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .p {\r\n        /* 16 * 0.0625 = 1px */\r\n        letter-spacing: 1em;\r\n    }\r\n</style>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60f2f933f861b3ca7f555eb909df1fae43650b1f5049", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-4"">
                Número de filas
                <input type=""number"" name=""nf"" id=""nf"" class=""form-control"" value=""1"" />
            </div>
            <div class=""col-md-4"">
                Número de columnas
                <input type=""number"" id=""nc"" name=""nc"" class=""form-control"" value=""1"" />
            </div>
            <div class=""col-md-4"">
                Número de palabras a buscar:
                <input type=""number"" id=""np"" name=""np"" class=""form-control"" value=""1"" />
            </div>
        </div>
        <br />
        <div class=""row"">
            <div class=""col-md-3""></div>
            <div class=""col-md-3""><input type=""submit"" value=""Crear sopa de letras"" class=""btn btn-primary form-control"" /></div>
            <div class=""col-md-3""><input type=""button"" value=""Ejemplo"" onclick=""example()"" class=""btn btn-primary form-control"" /></div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <hr />\r\n    <div class=\"container-fluid\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60f2f933f861b3ca7f555eb909df1fae43650b1f7536", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-6"">
                    <div id=""input"" class=""input"">

                    </div>
                </div>
                <div class=""col-md-6"">
                    <div id=""buscar"">

                    </div>
                </div>
            </div>
            <br />
            <div class=""row"" id=""data"">
                <div class=""col-md-3""></div>
                <div class=""col-md-6""><input type=""submit"" value=""Procesar información"" class=""btn btn-primary form-control"" /></div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n");
            DefineSection("js", async() => {
                WriteLiteral(@" 
    <script>
        $(document).ready(function(){
            $('#data').hide();
        })

        

        function generarInput(e, form) {
            e.preventDefault();
            var column = $('#nc').val();
            var row = $('#nf').val();
            var search = $('#np').val();
            $(""#input"").empty();
            for (var i = 0; i < row; i++) {
                var fila = i + 1;
                var input = ""<div class='col-md-12'>Fila "" + fila + "":<input type='text' name='row[]' id='row[]' class='form-control' maxlength='"" + column + ""' minlength='"" + column +""' required/></div>"";
                $(""#input"").append(input);
            }
            $(""#buscar"").empty();
            for (var i = 0; i < search; i++) {
                var fila = i + 1;
                var input = ""<div class='col-md-12'>Palabra "" + fila + "":<input type='text' name='search[]' id='search[]' class='form-control' maxlength='"" + column + ""' required /></div>"";
                $(""#bus");
                WriteLiteral(@"car"").append(input);
            }
            $('#data').show();
        }

        function example() {
            const rows = [""foktaicergniica"", ""grtcuyagtreuniv"", ""rtaathurdtcmcbf"", ""einntcflouheior"", ""cliacivomprsaba"", ""iytdyiitageuron"", ""ffpasiatdbfwcnc"", ""rawtkilvhsbcaai"", ""axwsfdaudqdxnhn"", ""nzxibdaiutvaajd"", ""cekmaeyiefdgdei"", ""irondssrlakbaaa"", ""tcayrurnoruegai"", ""sgrecianoruegaa"", ""agailatitaliatr""];
            var busqueda = [""italia"", ""grecia"", ""canada"", ""india"", ""peru"", ""francia"", ""noruega""];
            
            
            var column = 15;
            var fila = 1;
            $(""#input"").empty();
            rows.forEach(function (element) {
                var input = ""<div class='col-md-12'>Fila "" + fila + "":<input type='text' name='row[]' id='row[]' class='form-control' maxlength='"" + column + ""' minlength='"" + column + ""' value='"" + element + ""' required/></div>"";
                //console.log(element); // $(this).val()}
                $(""#input"").append(input);");
                WriteLiteral(@"
                fila++;
            });
            fila = 1;
            $(""#buscar"").empty();
            busqueda.forEach(function (element) {
                var input = ""<div class='col-md-12'>Palabra "" + fila + "":<input type='text' name='search[]' id='search[]' class='form-control' maxlength='"" + column + ""' value='"" + element + ""' required/></div>""; // $(this).val()}
                $(""#buscar"").append(input);
                fila++;
            });
            $('#data').show();
        }
        function postData(e, form) {
            e.preventDefault();
            /*var arr = $('input[name=""row[]""]').map(function () {
                console.log(this.value); // $(this).val()
            }).get();*/

            var formData = new FormData(form);
            
            $.ajax({
                // la URL para la petición
                url: '");
#nullable restore
#line 119 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Home\Sopa.cshtml"
                 Write(Url.Action("Test", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                // la información a enviar
                // (también es posible utilizar una cadena de datos)
                data: formData,

                // especifica si será una petición POST o GET
                type: 'POST',

                // el tipo de información que se espera de respuesta
                // dataType : 'json',

                // código a ejecutar si la petición es satisfactoria;
                // la respuesta es pasada como argumento a la función
                async: false,
                success: function (data) {
                    //alert(data);
                    console.log(data);
                    resultado(data);

                },
                // código a ejecutar si la petición falla;
                // son pasados como argumentos a la función
                // el objeto de la petición en crudo y código de estatus de la petición
                error: function (xhr, status) {
                    alert(""error de solicitud"");
  ");
                WriteLiteral(@"              },
                cache: false,
                contentType: false,
                processData: false
                // código a ejecutar sin importar si la petición falló o no
                //complete : function(xhr, status) {
                //alert('Petición realizada');
                //}
            });
        }

        function resultado(data) {
            $(""#input"").empty();
            $(""#buscar"").empty();
            $(""#input"").append(""<h1>Sopa de letras</h1>"");
            data[""sopa""].forEach(function (element) {
                
                $(""#input"").append('<label class=""p"">' + element + '</label>');
                $(""#input"").append(""<br>"");
            });
            $(""#buscar"").append('<h1>Resultado</h1>');
            $(""#buscar"").append('<ul class=""list-group"">');
            data[""Resultado""].forEach(function (element) {
                var item = '<li class=""list-group-item"">' + element + '</li>';
                $(""#buscar"").appen");
                WriteLiteral("d(item);\r\n            });\r\n            $(\"#buscar\").append(\'</ul>\');\r\n            $(\'#data\').hide();\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
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
