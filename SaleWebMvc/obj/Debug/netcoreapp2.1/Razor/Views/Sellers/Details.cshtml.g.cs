#pragma checksum "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d863e86b9080e10355f223f1f412f871a854f59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_Details), @"mvc.1.0.view", @"/Views/Sellers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sellers/Details.cshtml", typeof(AspNetCore.Views_Sellers_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d863e86b9080e10355f223f1f412f871a854f59", @"/Views/Sellers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b2a6ec266116b5ec2769a6ef2c41d2853b4d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SaleWebMvc.Models.Seller>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(76, 85, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n<div>\r\n    <d1 class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(162, 38, false);
#line 10 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(200, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(244, 34, false);
#line 13 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model=>model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(278, 44, true);
            WriteLiteral("\r\n        </dd>\r\n         <dt>\r\n            ");
            EndContext();
            BeginContext(323, 39, false);
#line 16 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(362, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(406, 35, false);
#line 19 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model=>model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(441, 44, true);
            WriteLiteral("\r\n        </dd>\r\n         <dt>\r\n            ");
            EndContext();
            BeginContext(486, 43, false);
#line 22 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(529, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(573, 39, false);
#line 25 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model=>model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(612, 44, true);
            WriteLiteral("\r\n        </dd>\r\n         <dt>\r\n            ");
            EndContext();
            BeginContext(657, 44, false);
#line 28 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(701, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(745, 40, false);
#line 31 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model=>model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(785, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(829, 49, false);
#line 34 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(878, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(922, 45, false);
#line 37 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
       Write(Html.DisplayFor(model=>model.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(967, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </d1>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1014, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d863e86b9080e10355f223f1f412f871a854f598571", async() => {
                BeginContext(1084, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Sellers\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1092, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1098, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d863e86b9080e10355f223f1f412f871a854f5910977", async() => {
                BeginContext(1120, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1136, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaleWebMvc.Models.Seller> Html { get; private set; }
    }
}
#pragma warning restore 1591