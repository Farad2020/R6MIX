#pragma checksum "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bec9748640e2912c23327dd9251d7ae653eefda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operators_Details), @"mvc.1.0.view", @"/Views/Operators/Details.cshtml")]
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
#line 1 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\_ViewImports.cshtml"
using R6MIX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\_ViewImports.cshtml"
using R6MIX.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bec9748640e2912c23327dd9251d7ae653eefda", @"/Views/Operators/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e4945d7d445eb4a85c0d58350fb6f7a369188a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Operators_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<R6MIX.Models.Operator>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-5\">\r\n        <div class=\"d-flex align-items-center justify-content-start text-center m-0\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 271, "\"", 294, 1);
#nullable restore
#line 11 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
WriteAttributeValue("", 277, Model.OpIconLink, 277, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 80px; width: auto;\" />\r\n            <h1 class=\"text-uppercase font-italic\">");
#nullable restore
#line 12 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n\r\n        <hr class=\"m-0 ml-2 mb-3\" style=\"background-color: white; height: 1px;\" />\r\n\r\n        <div class=\"pl-2\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <h5>");
#nullable restore
#line 20 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.OpSide));

#line default
#line hidden
#nullable disable
            WriteLiteral(": <img");
            BeginWriteAttribute("src", " src=\"", 675, "\"", 699, 1);
#nullable restore
#line 20 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
WriteAttributeValue("", 681, Model.OpSide.Icon, 681, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 30px; width: auto;\" /> ");
#nullable restore
#line 20 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                                                                                                                                    Write(Model.OpSide.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h6>");
#nullable restore
#line 21 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Origin));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 21 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                                                                Write(Model.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <hr class=\"m-0 ml-2 mb-3\" style=\"background-color: white; height: 1px;\" />\r\n\r\n        <div class=\"pl-2\">\r\n            <h5>");
#nullable restore
#line 29 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral(":<br> ");
#nullable restore
#line 29 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                                                          Write(Model.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n\r\n        <hr class=\"m-0 ml-2 mb-3\" style=\"background-color: white; height: 1px;\" />\r\n\r\n        <div class=\"pl-2\">\r\n            <div class=\"row\">\r\n                <div class=\"col-4\">\r\n                    <h5>");
#nullable restore
#line 37 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Armor));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 37 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                                                               Write(Model.Armor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    <h5>");
#nullable restore
#line 40 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Speed));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 40 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                                                               Write(Model.Speed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <h5>");
#nullable restore
#line 43 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Difficulty));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 43 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                                                                    Write(Model.Difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                </div>
            </div>
        </div>

        <hr class=""m-0 ml-2 mb-3"" style=""background-color: white; height: 1px;"" />
    </div>
    <div class=""col"">
        <div class=""d-flex align-items-center justify-content-end text-center"">
            <img");
            BeginWriteAttribute("src", " src=\"", 1979, "\"", 2001, 1);
#nullable restore
#line 52 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
WriteAttributeValue("", 1985, Model.OpImgLink, 1985, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""height:500px; width: auto;"" />
        </div>
    </div>
</div>

<hr class=""m-0 ml-2 mb-3"" style=""background-color: white; height: 1px;"" />

<div class=""row"">
    <div class=""col"">
        <h3 class=""text-center"">UNIQUE ABILITIES AND PLAYSTYLE</h3>
    </div>
    <div class=""w-100""></div>

    <div class=""col-5"">
        <iframe width=""560"" height=""315""");
            BeginWriteAttribute("src", " \r\n                src=\"", 2379, "\"", 2455, 2);
            WriteAttributeValue("", 2403, "https://www.youtube.com/embed/", 2403, 30, true);
#nullable restore
#line 67 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
WriteAttributeValue("", 2433, Model.AbilityDemoLink, 2433, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" 
                title=""YouTube video player"" frameborder=""0"" 
                allow=""accelerometer; autoplay; clipboard-write; 
                encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
    </div>
    <div class=""col"">
        <h6>");
#nullable restore
#line 73 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
       Write(Model.AbilityTLDR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n\r\n</div>\r\n\r\n<div>\r\n\r\n");
            WriteLiteral("</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bec9748640e2912c23327dd9251d7ae653eefda11407", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 171 "C:\Users\Faraby\Desktop\Gafar\R6MIX\Views\Operators\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bec9748640e2912c23327dd9251d7ae653eefda13538", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<R6MIX.Models.Operator> Html { get; private set; }
    }
}
#pragma warning restore 1591
