#pragma checksum "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "073855738da3de14d73af1fb34a01525feb491f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compra_Orcar), @"mvc.1.0.view", @"/Views/Compra/Orcar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Compra/Orcar.cshtml", typeof(AspNetCore.Views_Compra_Orcar))]
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
#line 1 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\_ViewImports.cshtml"
using ParqueWeb;

#line default
#line hidden
#line 2 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\_ViewImports.cshtml"
using ParqueWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"073855738da3de14d73af1fb34a01525feb491f0", @"/Views/Compra/Orcar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a76048edb0eb553df963a7f6c4425b5dec503d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Compra_Orcar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ParqueBLL.Passaporte>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmaCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml"
  
    ViewData["Title"] = "Orcar";

#line default
#line hidden
            BeginContext(85, 104, true);
            WriteLiteral("\r\n<h1>Orcar</h1>\r\n\r\n<h4>Passaporte</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(189, 1774, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "073855738da3de14d73af1fb34a01525feb491f04568", async() => {
                BeginContext(223, 159, true);
                WriteLiteral("\r\n            <table class=\"table\">\r\n                <thead float: rigth>\r\n                    <tr>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(383, 47, false);
#line 18 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml"
                       Write(Html.DisplayNameFor(model => model.NomeCliente));

#line default
#line hidden
                EndContext();
                BeginContext(430, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(522, 43, false);
#line 21 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml"
                       Write(Html.DisplayNameFor(model => model.NroDias));

#line default
#line hidden
                EndContext();
                BeginContext(565, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(657, 47, false);
#line 24 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml"
                       Write(Html.DisplayNameFor(model => model.DataInicial));

#line default
#line hidden
                EndContext();
                BeginContext(704, 91, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
                EndContext();
                BeginContext(796, 46, false);
#line 27 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml"
                       Write(Html.DisplayNameFor(model => model.ValorTotal));

#line default
#line hidden
                EndContext();
                BeginContext(842, 146, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
                EndContext();
#line 33 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
                BeginContext(1061, 109, true);
                WriteLiteral("                        <tr float: rigth>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(1171, 46, false);
#line 37 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NomeCliente));

#line default
#line hidden
                EndContext();
                BeginContext(1217, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(1321, 42, false);
#line 40 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NroDias));

#line default
#line hidden
                EndContext();
                BeginContext(1363, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(1467, 46, false);
#line 43 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DataInicial));

#line default
#line hidden
                EndContext();
                BeginContext(1513, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(1617, 45, false);
#line 46 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ValorTotal));

#line default
#line hidden
                EndContext();
                BeginContext(1662, 68, true);
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 49 "C:\Users\Administrador\Desktop\Parque-20190529T224530Z-001\Parque\ParqueWeb\Views\Compra\Orcar.cshtml"
                    }

#line default
#line hidden
                BeginContext(1753, 203, true);
                WriteLiteral("                </tbody>\r\n            </table>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Confirma Compra\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1963, 35, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1998, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "073855738da3de14d73af1fb34a01525feb491f011558", async() => {
                BeginContext(2020, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2036, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ParqueBLL.Passaporte>> Html { get; private set; }
    }
}
#pragma warning restore 1591
