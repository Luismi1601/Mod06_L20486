#pragma checksum "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f3d8f182416200583dbf776f55c1dc0dc2f079d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Butterfly_Index), @"mvc.1.0.view", @"/Views/Butterfly/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Butterfly/Index.cshtml", typeof(AspNetCore.Views_Butterfly_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3d8f182416200583dbf776f55c1dc0dc2f079d", @"/Views/Butterfly/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Butterfly_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ButterfliesShop.Models.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/butterflies-shop-styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
   Layout = null; 

#line default
#line hidden
            BeginContext(65, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(90, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "230aea0072a9490ea902e6b9079238cd", async() => {
                BeginContext(96, 88, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Index</title>\n    ");
                EndContext();
                BeginContext(184, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "40b302f345fc4e16b19684605864d22b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(266, 1, true);
                WriteLiteral("\n");
                EndContext();
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
            EndContext();
            BeginContext(274, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(275, 2377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb51ac2f25c46569f53ad05745ab42d", async() => {
                BeginContext(281, 257, true);
                WriteLiteral(@"
    <div class=""container"">
        <h1 class=""main-title"">Butterflies Shop</h1>
        <p class=""into"">Welcome to our Web Store, Enjoy a Wide Variety of Butterflies</p>
        <p class=""into"">Our Butterflies in the Shop</p>
        <button type=""button""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 538, "\"", 598, 3);
                WriteAttributeValue("", 548, "location.href=\'", 548, 15, true);
#line 17 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
WriteAttributeValue("", 563, Url.Action("Create", "Butterfly"), 563, 34, false);

#line default
#line hidden
                WriteAttributeValue("", 597, "\'", 597, 1, true);
                EndWriteAttribute();
                BeginContext(599, 62, true);
                WriteLiteral(">Add Butterflies</button>\n        <div class=\"img-container\">\n");
                EndContext();
#line 19 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
             foreach (var item in Model.Butterflies)
            {

#line default
#line hidden
                BeginContext(728, 115, true);
                WriteLiteral("            <div class=\"photo-index-card\">\n                <h3 class=\"display-picture-title\">\n                    \"");
                EndContext();
                BeginContext(844, 45, false);
#line 23 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.CommonName));

#line default
#line hidden
                EndContext();
                BeginContext(889, 24, true);
                WriteLiteral("\"\n                </h3>\n");
                EndContext();
#line 25 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
                 if (item.ImageName != null)
                {

#line default
#line hidden
                BeginContext(976, 102, true);
                WriteLiteral("                    <div class=\"photo-display\">\n                        <img class=\"photo-display-img\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1078, "\"", 1142, 1);
#line 28 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
WriteAttributeValue("", 1084, Url.Action("GetImage", "Butterfly", new { Id = item.Id }), 1084, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1143, 47, true);
                WriteLiteral(" />\n                    </div>                \n");
                EndContext();
#line 30 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1208, 92, true);
                WriteLiteral("                <div>\n                    <p class=\"display-label\">\n                        ");
                EndContext();
                BeginContext(1301, 50, false);
#line 33 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
                   Write(Html.DisplayNameFor(model => item.ButterflyFamily));

#line default
#line hidden
                EndContext();
                BeginContext(1351, 123, true);
                WriteLiteral("\n                    </p>\n                    <br />\n                    <p class=\"display-field\">\n                        ");
                EndContext();
                BeginContext(1475, 46, false);
#line 37 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
                   Write(Html.DisplayFor(model => item.ButterflyFamily));

#line default
#line hidden
                EndContext();
                BeginContext(1521, 162, true);
                WriteLiteral("\n                    </p>\n                </div>\n                <div class=\"display-info\">\n                    <p class=\"display-label\">\n                        ");
                EndContext();
                BeginContext(1684, 50, false);
#line 42 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
                   Write(Html.DisplayNameFor(model => item.Characteristics));

#line default
#line hidden
                EndContext();
                BeginContext(1734, 96, true);
                WriteLiteral("\n                    </p>\n                    <p class=\"display-field\">\n                        ");
                EndContext();
                BeginContext(1831, 46, false);
#line 45 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
                   Write(Html.DisplayFor(model => item.Characteristics));

#line default
#line hidden
                EndContext();
                BeginContext(1877, 141, true);
                WriteLiteral("\n                    </p>\n                </div>\n                <div>\n                    <p class=\"display-label\">\n                        ");
                EndContext();
                BeginContext(2019, 43, false);
#line 50 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
                   Write(Html.DisplayNameFor(model => item.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(2062, 96, true);
                WriteLiteral("\n                    </p>\n                    <p class=\"display-field\">\n                        ");
                EndContext();
                BeginContext(2159, 39, false);
#line 53 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
                   Write(Html.DisplayFor(model => item.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(2198, 141, true);
                WriteLiteral("\n                    </p>\n                </div>\n                <div>\n                    <p class=\"display-label\">\n                        ");
                EndContext();
                BeginContext(2340, 46, false);
#line 58 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
                   Write(Html.DisplayNameFor(model => item.CreatedDate));

#line default
#line hidden
                EndContext();
                BeginContext(2386, 96, true);
                WriteLiteral("\n                    </p>\n                    <p class=\"display-field\">\n                        ");
                EndContext();
                BeginContext(2483, 42, false);
#line 61 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
                   Write(Html.DisplayFor(model => item.CreatedDate));

#line default
#line hidden
                EndContext();
                BeginContext(2525, 80, true);
                WriteLiteral("\n                    </p>\n                </div>\n            </div>            \n");
                EndContext();
#line 65 "C:\Curso\20486\Luismi\LabFiles\Mod06\Labfiles\01_ButterfliesShop_begin\ButterfliesShop\Views\Butterfly\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2619, 26, true);
                WriteLiteral("        </div>\n    </div>\n");
                EndContext();
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
            EndContext();
            BeginContext(2652, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ButterfliesShop.Models.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
