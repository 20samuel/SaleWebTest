#pragma checksum "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d205c3693c3c9f0e924ab73923c5e56a7eeee6b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d205c3693c3c9f0e924ab73923c5e56a7eeee6b3", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b2a6ec266116b5ec2769a6ef2c41d2853b4d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Home\About.cshtml"
  
    
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(47, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(52, 17, false);
#line 5 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(69, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(81, 19, false);
#line 6 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(100, 32, true);
            WriteLiteral("</h3>\r\n\r\n<p>Programador Junior: ");
            EndContext();
            BeginContext(133, 16, false);
#line 8 "C:\Users\Samuel\Desktop\Seção 17\SaleWebMvc\SaleWebMvc\Views\Home\About.cshtml"
                  Write(ViewData["Nome"]);

#line default
#line hidden
            EndContext();
            BeginContext(149, 166, true);
            WriteLiteral("</p>\r\n<address>\r\n    <strong>More information: </strong><a href=\"https://github.com/20samuel/SaleWebTest/blob/master/SaleWebMvc/Program.cs\">GitHub</a>\r\n</address>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
