#pragma checksum "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3893b2d5e0dace4d247e4d733449142fcb0f28a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_SimpleSearch), @"mvc.1.0.view", @"/Views/SalesRecords/SimpleSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/SimpleSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_SimpleSearch))]
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
#line 1 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\_ViewImports.cshtml"
using SaleWebMvc;

#line default
#line hidden
#line 2 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\_ViewImports.cshtml"
using SaleWebMvc.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3893b2d5e0dace4d247e4d733449142fcb0f28a", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b2a6ec266116b5ec2769a6ef2c41d2853b4d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SaleWebMvc.Models.SalesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
  
    ViewData["Title"] = "Simple Search";

#line default
#line hidden
            BeginContext(100, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(107, 17, false);
#line 6 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(124, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(213, 668, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3893b2d5e0dace4d247e4d733449142fcb0f28a4877", async() => {
                BeginContext(265, 216, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                 <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 481, "", 488, 0);
                EndWriteAttribute();
                BeginContext(488, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(490, 19, false);
#line 14 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                                                                             Write(ViewData["minDate"]);

#line default
#line hidden
                EndContext();
                BeginContext(509, 204, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 713, "", 720, 0);
                EndWriteAttribute();
                BeginContext(720, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(722, 19, false);
#line 18 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                                                                             Write(ViewData["maxDate"]);

#line default
#line hidden
                EndContext();
                BeginContext(741, 133, true);
                WriteLiteral(" />\r\n\r\n                </div>\r\n            </div>\r\n           <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
                EndContext();
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
            EndContext();
            BeginContext(881, 133, true);
            WriteLiteral(" \r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n    <dv class=\"panel-body\">\r\n        <h3 class=\"panel-title\">Total sales = ");
            EndContext();
            BeginContext(1015, 41, false);
#line 28 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                                         Write(Model.Sum(obj=>obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 214, true);
            WriteLiteral("</h3>\r\n    </dv>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-houver\">\r\n            <thead>\r\n                <tr class=\"sucess\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1271, 37, false);
#line 35 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model=> model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1388, 38, false);
#line 38 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model=>model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1506, 40, false);
#line 41 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model=>model.Seller));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1626, 51, false);
#line 44 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model=>model.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1757, 40, false);
#line 47 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model=>model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1877, 40, false);
#line 50 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model=>model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1917, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 55 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
            BeginContext(2076, 85, true);
            WriteLiteral("                    <tr>\r\n                         <th>\r\n                            ");
            EndContext();
            BeginContext(2162, 37, false);
#line 59 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2199, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2291, 39, false);
#line 62 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2330, 92, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                             ");
            EndContext();
            BeginContext(2423, 46, false);
#line 65 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                        Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2469, 92, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                             ");
            EndContext();
            BeginContext(2562, 57, false);
#line 68 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                        Write(Html.DisplayFor(modelItem => item.Seller.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2619, 92, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                             ");
            EndContext();
            BeginContext(2712, 41, false);
#line 71 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                        Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2753, 92, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                             ");
            EndContext();
            BeginContext(2846, 41, false);
#line 74 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                        Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2887, 60, true);
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n");
            EndContext();
#line 77 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(2966, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SaleWebMvc.Models.SalesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
