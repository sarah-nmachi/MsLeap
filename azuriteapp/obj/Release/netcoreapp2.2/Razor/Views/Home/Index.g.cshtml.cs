#pragma checksum "C:\Users\sarah\source\repos\azuriteapp\azuriteapp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18049f122958d2a0ebb9e4d7f8907655995132d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\sarah\source\repos\azuriteapp\azuriteapp\Views\_ViewImports.cshtml"
using azuriteapp;

#line default
#line hidden
#line 2 "C:\Users\sarah\source\repos\azuriteapp\azuriteapp\Views\_ViewImports.cshtml"
using azuriteapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18049f122958d2a0ebb9e4d7f8907655995132d8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a380a07473544fa1ca36e3f54cb2cbc763e291", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString(".site-navbar-target"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-offset", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 838, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18049f122958d2a0ebb9e4d7f8907655995132d84689", async() => {
                BeginContext(43, 825, true);
                WriteLiteral(@"
    <title>Azurite- Home Page</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <link href=""https://fonts.googleapis.com/css?family=DM+Sans:300,400,700|Indie+Flower"" rel=""stylesheet"">


    <link rel=""stylesheet"" href=""fonts/icomoon/style.css"">

    <link rel=""stylesheet"" href=""css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/bootstrap-datepicker.css"">
    <link rel=""stylesheet"" href=""css/jquery.fancybox.min.css"">
    <link rel=""stylesheet"" href=""css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""css/owl.theme.default.min.css"">
    <link rel=""stylesheet"" href=""fonts/flaticon/font/flaticon.css"">
    <link rel=""stylesheet"" href=""css/aos.css"">


    <link rel=""stylesheet"" href=""css/style.css"">

");
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
            BeginContext(875, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(879, 6272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18049f122958d2a0ebb9e4d7f8907655995132d86744", async() => {
                BeginContext(955, 5180, true);
                WriteLiteral(@"


    <div class=""site-wrap"" id=""home-section"">

        <div class=""site-mobile-menu site-navbar-target"">
            <div class=""site-mobile-menu-header"">
                <div class=""site-mobile-menu-close mt-3"">
                    <span class=""icon-close2 js-menu-toggle""></span>
                </div>
            </div>
            <div class=""site-mobile-menu-body""></div>
        </div>



        <header class=""site-navbar site-navbar-target"" role=""banner"">

            <div class=""container mb-3"">
                <div class=""d-flex align-items-center"">
                    <div class=""site-logo mr-auto"">
                        <a href=""index.html"">Azurite<span class=""text-primary"">.</span></a>
                    </div>

                </div>
            </div>


            <div class=""container"">
                <div class=""menu-wrap d-flex align-items-center"">
                    <span class=""d-inline-block d-lg-none""><a href=""#"" class=""text-black site-menu-toggle js-");
                WriteLiteral(@"menu-toggle py-5""><span class=""icon-menu h3 text-black""></span></a></span>



                    <nav class=""site-navigation text-left mr-auto d-none d-lg-block"" role=""navigation"">
                        <ul class=""site-menu main-menu js-clone-nav mr-auto "">
                            <li class=""active""><a href="""" class=""nav-link"">Home</a></li>

                            <li><a href="""" class=""nav-link"">Contact</a></li>
                        </ul>
                    </nav>

                    <div class=""top-social ml-auto"">
                        <a href=""#""><span class=""icon-facebook text-teal""></span></a>
                        <a href=""#""><span class=""icon-twitter text-success""></span></a>
                        <a href=""#""><span class=""icon-linkedin text-yellow""></span></a>
                    </div>
                </div>
            </div>



        </header>

        <div class=""ftco-blocks-cover-1"">

            <div class=""site-section-cover overlay"">
         ");
                WriteLiteral(@"       <div class=""container"">
                    <div class=""row align-items-center "">
                        <div class=""col-md-5 mt-5 pt-5"">
                            <span class=""text-cursive h5 text-red"">Welcome To Our Website</span>
                            <h1 class=""mb-3 font-weight-bold text-teal"">We are the first Leap Cohort</h1>
                            <p class=""mt-5""><a href="""" class=""btn btn-primary py-4 btn-custom-1"">Learn More</a></p>
                        </div>
                        <div class=""col-md-6 ml-auto align-self-end"">
                            <img src=""IMG-20191008-WA0009.jpg"" alt=""Image"" class=""img-fluid"">

                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""site-section"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-4"">
                        <div class=""block-2 red"">

                          ");
                WriteLiteral(@"  <h2>Chiamaka Obitube</h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima nesciunt, mollitia, hic enim id culpa.</p>
                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <div class=""block-2 yellow"">
                            <h2>Enobong Okpongete</h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima nesciunt, mollitia, hic enim id culpa.</p>
                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <div class=""block-2 teal"">
                            <h2>Patience Bello</h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima nesciunt, mollitia, hic enim id culpa.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""site-secti");
                WriteLiteral(@"on"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-4"">
                        <div class=""block-2 red"">
                            <h2>Sarah Nmachi</h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima nesciunt, mollitia, hic enim id culpa.</p>
                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <div class=""block-2 yellow"">
                            <span class=""wrap-icon"">
                                <span class=""icon-person""></span>
                            </span>
                            <h2>Nicky Anya</h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima nesciunt, mollitia, hic enim id culpa.</p>
                        </div>
                    </div>

                </div>
            </div>
        </div>


        <div class=""site-sect");
                WriteLiteral("ion\">\r\n            <div class=\"container\">\r\n                ");
                EndContext();
                BeginContext(6135, 953, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18049f122958d2a0ebb9e4d7f8907655995132d812628", async() => {
                    BeginContext(6141, 940, true);
                    WriteLiteral(@"
                    <div class=""form-group "">
                        <label for=""exampleInputEmail1"">Email address</label>
                        <h3>Talk to us!</h3>
                        <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Enter email"">
                        <small id=""emailHelp"" class=""form-text text-muted"">We'll never share your email with anyone else.</small>
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">Phone Number</label>
                        <input type=""number"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""phone number"">
                    </div>
                    <div class=""form-group form-check"">
                    </div>
                    <button type=""submit"" class=""btn btn-primary"">Submit</button>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7088, 56, true);
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
            BeginContext(7151, 15, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
