#pragma checksum "C:\Users\tshep\Documents\School\DISD3\2nd Semester\APPR6312\Task 2 -Github\DisasterAlleviationFoundation\DisasterAlleviationFoundation\Pages\adminHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a4d4da1fc6d702d83a844b21b17486c583fe018"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DisasterAlleviationFoundation.Pages.Pages_adminHome), @"mvc.1.0.razor-page", @"/Pages/adminHome.cshtml")]
namespace DisasterAlleviationFoundation.Pages
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
#line 1 "C:\Users\tshep\Documents\School\DISD3\2nd Semester\APPR6312\Task 2 -Github\DisasterAlleviationFoundation\DisasterAlleviationFoundation\Pages\_ViewImports.cshtml"
using DisasterAlleviationFoundation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a4d4da1fc6d702d83a844b21b17486c583fe018", @"/Pages/adminHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff5d3e8bdaabf1c630cca732c6177d1f6c84757", @"/Pages/_ViewImports.cshtml")]
    public class Pages_adminHome : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleSheetNew"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\tshep\Documents\School\DISD3\2nd Semester\APPR6312\Task 2 -Github\DisasterAlleviationFoundation\DisasterAlleviationFoundation\Pages\adminHome.cshtml"
 if (Logic.Users.Message.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\'alert-warning alert-dismissible fade show\' role=\"alert\">\r\n        <strong>");
#nullable restore
#line 9 "C:\Users\tshep\Documents\School\DISD3\2nd Semester\APPR6312\Task 2 -Github\DisasterAlleviationFoundation\DisasterAlleviationFoundation\Pages\adminHome.cshtml"
           Write(Logic.Users.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\tshep\Documents\School\DISD3\2nd Semester\APPR6312\Task 2 -Github\DisasterAlleviationFoundation\DisasterAlleviationFoundation\Pages\adminHome.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a4d4da1fc6d702d83a844b21b17486c583fe0185391", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<section class=""text-center"">
    <div class="" py-1 h-100"">
        <div class=""row d-flex justify-content-center align-items-center h-100"">
            <div class=""form-row"">
                <!--Card 1 - Allocate Funds card-->
                <div class=""col-12 col-md-8 col-lg-6 col-xl-5 p-5"">
                    <div class=""card shadow-2-strong "" style=""border-radius: 1rem; background: hsla(0, 0%, 100%, 0.3); backdrop-filter: blur(30px); "">
                        <div class=""card-body p-5 text-center"">
                            <!--Allocate Funds-->
                            <span class=""mb-5"" style=""font-size: 43px; color: white"">Goods </span><span class=""mb-5"" style=""font-size: 43px; color: #bd1ad5;""></span>
                            <!--Available Funds-->

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a4d4da1fc6d702d83a844b21b17486c583fe0187347", async() => {
                WriteLiteral(@"
                                <!-- Allocate amount button-->
                                <input type=""hidden"" name=""inputByUser"" value=""goods"" class=""form-control"" />
                                <button class=""btn btn-primary btn-lg btn-block"" type=""submit"">Click to allocate</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        </div>
                    </div>
                </div>
                <div class=""col-12 col-md-8 col-lg-6 col-xl-5 p-5"">
                    <div class=""card shadow-2-strong "" style=""border-radius: 1rem; background: hsla(0, 0%, 100%, 0.3); backdrop-filter: blur(30px); "">
                        <div class=""card-body p-5 text-center"">
                            <!--Allocate Funds-->
                            <span class=""mb-5"" style=""font-size: 43px; color: white"">Funds </span><span class=""mb-5"" style=""font-size: 43px; color: #bd1ad5;""></span>

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a4d4da1fc6d702d83a844b21b17486c583fe0189750", async() => {
                WriteLiteral(@"
                                <!-- Allocate amount button-->
                                <input type=""hidden"" name=""inputByUser"" value=""funds"" class=""form-control"" />
                                <button class=""btn btn-primary btn-lg btn-block"" type=""submit"">Click to allocate</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        </div>
                    </div>
                </div>
                <!--card 2 -Allocate Goods card-->
                <div class=""col-12 col-md-8 col-lg-6 col-xl-5 p-5"">
                    <div class=""card shadow-2-strong "" style=""border-radius: 1rem; background: hsla(0, 0%, 100%, 0.3); backdrop-filter: blur(30px); "">
                        <div class=""card-body p-5 text-center"">
                            <!--Alloocate Funds-->
                            <span class=""mb-5"" style=""font-size: 40px; color: white"">Purchase Goods </span><span class=""mb-5"" style=""font-size: 43px; color: #bd1ad5;""></span>

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a4d4da1fc6d702d83a844b21b17486c583fe01812215", async() => {
                WriteLiteral(@"

                                <!--Select disaster-->
                                <input type=""hidden"" name=""inputByUser"" value=""purchase"" class=""form-control"" />
                                <button class=""btn btn-primary btn-lg btn-block"" type=""submit"">Purchase</button>

                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!--History page goes here-->\r\n\r\n        </div>\r\n    </div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DisasterAlleviationFoundation.Pages.adminHomeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DisasterAlleviationFoundation.Pages.adminHomeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DisasterAlleviationFoundation.Pages.adminHomeModel>)PageContext?.ViewData;
        public DisasterAlleviationFoundation.Pages.adminHomeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
