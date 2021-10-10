#pragma checksum "D:\WorkNew\StorePromotion\StorePromotion\StorePromotion.UI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83d84c18151ce3449698978111879123e4572ada"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\WorkNew\StorePromotion\StorePromotion\StorePromotion.UI\Views\_ViewImports.cshtml"
using StorePromotion.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkNew\StorePromotion\StorePromotion\StorePromotion.UI\Views\_ViewImports.cshtml"
using StorePromotion.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83d84c18151ce3449698978111879123e4572ada", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f9ecccaf3ab1fa8ab3421cf4d23a0172ec43800", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("overflow-x-hidden antialiased"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83d84c18151ce3449698978111879123e4572ada4864", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Store Promotion</title>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/tailwindcss/1.9.2/tailwind.min.css"">
    <!--<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">-->

    <!-- jQuery library -->
");
                WriteLiteral("\r\n    <!-- Latest compiled JavaScript -->\r\n    <!--<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js\"></script>-->\r\n    <!-- Small CSS to Hide elements at 1520px size -->\r\n");
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83d84c18151ce3449698978111879123e4572ada6524", async() => {
                WriteLiteral(@"
    <header class=""relative z-50 w-full h-24"">
        <div class=""container flex items-center justify-center h-full max-w-6xl px-8 mx-auto sm:justify-between xl:px-0"">

            <a href=""/"" class=""relative flex items-center inline-block h-5 h-full font-black leading-none"">
");
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83d84c18151ce3449698978111879123e4572ada7122", async() => {
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
                WriteLiteral(@"
            </a>    

            <nav id=""nav""
                 class=""absolute top-0 left-0 z-50 flex flex-col items-center justify-between hidden w-full h-64 pt-5 mt-24 text-sm text-gray-800 bg-white border-t border-gray-200 md:w-auto md:flex-row md:h-24 lg:text-base md:bg-transparent md:mt-0 md:border-none md:py-0 md:flex md:relative"">
                <a");
                BeginWriteAttribute("href", " href=\"", 2736, "\"", 2771, 1);
#nullable restore
#line 57 "D:\WorkNew\StorePromotion\StorePromotion\StorePromotion.UI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2743, Url.Action("Index", "Home"), 2743, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                   class=\"ml-0 mr-0 font-bold duration-100 md:ml-12 md:mr-3 lg:mr-8 transition-color hover:text-indigo-600\">Home</a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 2926, "\"", 2967, 1);
#nullable restore
#line 59 "D:\WorkNew\StorePromotion\StorePromotion\StorePromotion.UI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2933, Url.Action("Index", "StoreOwner"), 2933, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                   class=""mr-0 font-bold duration-100 md:mr-3 lg:mr-8 transition-color hover:text-indigo-600"">Register</a>
                <a href=""#pricing""
                   class=""mr-0 font-bold duration-100 md:mr-3 lg:mr-8 transition-color hover:text-indigo-600"">Pricing</a>
                <a href=""#testimonials""
                   class=""font-bold duration-100 transition-color hover:text-indigo-600"">Testimonials</a>
                <div class=""flex flex-col block w-full font-medium border-t border-gray-200 md:hidden"">
                    <a href=""#_"" class=""w-full py-2 font-bold text-center text-pink-500"">Login</a>
                    <a href=""#_"" ");
                WriteLiteral(@"
                       class=""relative inline-block w-full px-5 py-3 text-sm leading-none text-center text-white bg-indigo-700 fold-bold"">
                        Get
                        Started
                    </a>
                </div>
            </nav>

            <div class=""absolute left-0 flex-col items-center justify-center hidden w-full pb-8 mt-48 border-b border-gray-200 md:relative md:w-auto md:bg-transparent md:border-none md:mt-0 md:flex-row md:p-0 md:items-end md:flex md:justify-between"">
                <a href=""#_""
                   class=""relative z-40 px-3 py-2 mr-0 text-sm font-bold text-pink-500 md:px-5 lg:text-white sm:mr-3 md:mt-0"">Login</a>
                <a href=""#_"" data-toggle=""modal"" data-target=""#exampleModal""
                   class=""relative z-40 inline-block w-auto h-full px-5 py-3 text-sm font-bold leading-none text-white transition-all transition duration-100 duration-300 bg-indigo-700 rounded shadow-md fold-bold lg:bg-white lg:text-indigo-700 sm:w-fu");
                WriteLiteral(@"ll lg:shadow-none hover:shadow-xl"">
                    Get
                    Started
                </a>
                <svg class=""absolute top-0 left-0 hidden w-screen max-w-3xl -mt-64 -ml-12 lg:block""
                     viewBox=""0 0 818 815"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
                    <defs>
                        <linearGradient x1=""0%"" y1=""0%"" x2=""100%"" y2=""100%"" id=""c"">
                            <stop stop-color=""#E614F2"" offset=""0%"" />
                            <stop stop-color=""#FC3832"" offset=""100%"" />
                        </linearGradient>
                        <linearGradient x1=""0%"" y1=""0%"" x2=""100%"" y2=""100%"" id=""f"">
                            <stop stop-color=""#657DE9"" offset=""0%"" />
                            <stop stop-color=""#1C0FD7"" offset=""100%"" />
                        </linearGradient>
                        <filter x=""-4.7%"" y=""-3.3%"" width=""109.3%"" height=""109.3%"" filterUnits=""objectBoundingBox""");
                WriteLiteral(@"
                                id=""a"">
                            <feOffset dy=""8"" in=""SourceAlpha"" result=""shadowOffsetOuter1"" />
                            <feGaussianBlur stdDeviation=""8"" in=""shadowOffsetOuter1"" result=""shadowBlurOuter1"" />
                            <feColorMatrix values=""0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0.15 0"" in=""shadowBlurOuter1"" />
                        </filter>
                        <filter x=""-4.7%"" y=""-3.3%"" width=""109.3%"" height=""109.3%"" filterUnits=""objectBoundingBox""
                                id=""d"">
                            <feOffset dy=""8"" in=""SourceAlpha"" result=""shadowOffsetOuter1"" />
                            <feGaussianBlur stdDeviation=""8"" in=""shadowOffsetOuter1"" result=""shadowBlurOuter1"" />
                            <feColorMatrix values=""0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0.2 0"" in=""shadowBlurOuter1"" />
                        </filter>
                        <path d=""M160.52 108.243h497.445c17.83 0 24.296 1.856 30.814 5.342 6.519");
                WriteLiteral(@" 3.486 11.635 8.602 15.12 15.12 3.487 6.52 5.344 12.985 5.344 30.815v497.445c0 17.83-1.857 24.296-5.343 30.814-3.486 6.519-8.602 11.635-15.12 15.12-6.52 3.487-12.985 5.344-30.815 5.344H160.52c-17.83 0-24.296-1.857-30.814-5.343-6.519-3.486-11.635-8.602-15.12-15.12-3.487-6.52-5.343-12.985-5.343-30.815V159.52c0-17.83 1.856-24.296 5.342-30.814 3.486-6.519 8.602-11.635 15.12-15.12 6.52-3.487 12.985-5.343 30.815-5.343z""
                              id=""b"" />
                        <path d=""M159.107 107.829H656.55c17.83 0 24.296 1.856 30.815 5.342 6.518 3.487 11.634 8.602 15.12 15.12 3.486 6.52 5.343 12.985 5.343 30.816V656.55c0 17.83-1.857 24.296-5.343 30.815-3.486 6.518-8.602 11.634-15.12 15.12-6.519 3.486-12.985 5.343-30.815 5.343H159.107c-17.83 0-24.297-1.857-30.815-5.343-6.519-3.486-11.634-8.602-15.12-15.12-3.487-6.519-5.343-12.985-5.343-30.815V159.107c0-17.83 1.856-24.297 5.342-30.815 3.487-6.519 8.602-11.634 15.12-15.12 6.52-3.487 12.985-5.343 30.816-5.343z""
                              id=""e"" />
     ");
                WriteLiteral(@"               </defs>
                    <g fill=""none"" fill-rule=""evenodd"" opacity="".9"">
                        <g transform=""rotate(65 416.452 409.167)"">
                            <use fill=""#000"" filter=""url(#a)"" xlink:href=""#b"" />
                            <use fill=""url(#c)"" xlink:href=""#b"" />
                        </g>
                        <g transform=""rotate(29 421.929 414.496)"">
                            <use fill=""#000"" filter=""url(#d)"" xlink:href=""#e"" />
                            <use fill=""url(#f)"" xlink:href=""#e"" />
                        </g>
                    </g>
                </svg>
            </div>

            <div id=""nav-mobile-btn""
                 class=""absolute top-0 right-0 z-50 block w-6 mt-8 mr-10 cursor-pointer select-none md:hidden sm:mt-10"">
                <span class=""block w-full h-1 mt-2 duration-200 transform bg-gray-800 rounded-full sm:mt-1""></span>
                <span class=""block w-full h-1 mt-1 duration-200 transform bg-gray-800");
                WriteLiteral(" rounded-full\"></span>\r\n            </div>\r\n");
                WriteLiteral("        </div>\r\n    </header>\r\n    <div class=\"container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            ");
#nullable restore
#line 152 "D:\WorkNew\StorePromotion\StorePromotion\StorePromotion.UI\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <footer class=""px-4 pt-12 pb-8 text-white bg-white border-t border-gray-200"">
        <div class=""container flex flex-col justify-between max-w-6xl px-4 mx-auto overflow-hidden lg:flex-row"">
            <div class=""w-full pl-12 mr-4 text-left lg:w-1/4 sm:text-center sm:pl-0 lg:text-left"">
                <a href=""/""
                   class=""flex justify-start block text-left sm:text-center lg:text-left sm:justify-center lg:justify-start"">
                    <span class=""flex items-start sm:items-center"">
                        <svg class=""w-auto h-6 text-gray-800 fill-current"" viewBox=""0 0 194 116""
                             xmlns=""http://www.w3.org/2000/svg"">
                            <g fill-rule=""evenodd"">
                                <path d=""M96.869 0L30 116h104l-9.88-17.134H59.64l47.109-81.736zM0 116h19.831L77 17.135 67.088 0z"">
                                </path>
                                <path d=""M87 68.732l9.926 17.143 29.893-51.59L1");
                WriteLiteral(@"74.15 116H194L126.817 0z""></path>
                            </g>
                        </svg>
                    </span>
                </a>
                <p class=""mt-6 mr-4 text-base text-gray-500"">
                    Crafting the next-level of user experience and engagement.
                </p>
            </div>
            <div class=""block w-full pl-10 mt-6 text-sm lg:w-3/4 sm:flex lg:mt-0"">
                <ul class=""flex flex-col w-full p-0 font-medium text-left text-gray-700 list-none"">
                    <li class=""inline-block px-3 py-2 mt-5 font-bold tracking-wide text-gray-800 uppercase md:mt-0"">
                        Product
                    </li>
                    <li>
                        <a href=""#_""
                           class=""inline-block px-3 py-2 text-gray-500 no-underline hover:text-gray-600"">Features</a>
                    </li>
                    <li>
                        <a href=""#_""
                           class=""inline-block px-");
                WriteLiteral(@"3 py-2 text-gray-500 no-underline hover:text-gray-600"">Integrations</a>
                    </li>
                    <li>
                        <a href=""#_""
                           class=""inline-block px-3 py-2 text-gray-500 no-underline hover:text-gray-600"">Pricing</a>
                    </li>
                    <li>
                        <a href=""#_""
                           class=""inline-block px-3 py-2 text-gray-500 no-underline hover:text-gray-600"">FAQ</a>
                    </li>
                </ul>
                <ul class=""flex flex-col w-full p-0 font-medium text-left text-gray-700 list-none"">
                    <li class=""inline-block px-3 py-2 mt-5 font-bold tracking-wide text-gray-800 uppercase md:mt-0"">
                        Company
                    </li>
                    <li>
                        <a href=""#_""
                           class=""inline-block px-3 py-2 text-gray-500 no-underline hover:text-gray-600"">Privacy</a>
                    </li>");
                WriteLiteral(@"
                    <li>
                        <a href=""#_"" class=""inline-block px-3 py-2 text-gray-500 no-underline hover:text-gray-600"">
                            Terms
                            of
                            Service
                        </a>
                    </li>
                </ul>
                <ul class=""flex flex-col w-full p-0 font-medium text-left text-gray-700 list-none"">
                    <li class=""inline-block px-3 py-2 mt-5 font-bold tracking-wide text-gray-800 uppercase md:mt-0"">
                        TailwindCSS
                    </li>
                    <li>
                        <a href=""https://devdojo.com/tailwindcss/components""
                           class=""inline-block px-3 py-2 text-gray-500 no-underline hover:text-gray-600"">
                            Tailwind
                            Components
                        </a>
                    </li>
                    <li>
                        <a href=""https://");
                WriteLiteral(@"devdojo.com/tailwindcss/templates""
                           class=""inline-block px-3 py-2 text-gray-500 no-underline hover:text-gray-600"">
                            Tailwind
                            Templates
                        </a>
                    </li>
                    <li>
                        <a href=""https://devdojo.com/tails""
                           class=""inline-block px-3 py-2 text-gray-500 no-underline hover:text-gray-600"">Tails</a>
                    </li>
                </ul>
                <div class=""flex flex-col w-full text-gray-700"">
                    <div class=""inline-block px-3 py-2 mt-5 font-bold text-gray-800 uppercase md:mt-0"">Follow Us</div>
                    <div class=""flex justify-start pl-4 mt-2"">
                        <a class=""flex items-center block mr-6 text-gray-400 no-underline hover:text-gray-600""
                           target=""_blank"" rel=""noopener noreferrer"" href=""https://devdojo.com"">
                            <svg v");
                WriteLiteral(@"iewBox=""0 0 24 24"" class=""w-5 h-5 fill-current"" xmlns=""http://www.w3.org/2000/svg"">
                                <path d=""M23.998 12c0-6.628-5.372-12-11.999-12C5.372 0 0 5.372 0 12c0 5.988 4.388 10.952 10.124 11.852v-8.384H7.078v-3.469h3.046V9.356c0-3.008 1.792-4.669 4.532-4.669 1.313 0 2.686.234 2.686.234v2.953H15.83c-1.49 0-1.955.925-1.955 1.874V12h3.328l-.532 3.469h-2.796v8.384c5.736-.9 10.124-5.864 10.124-11.853z"" />
                            </svg>
                        </a>
                        <a class=""flex items-center block mr-6 text-gray-400 no-underline hover:text-gray-600""
                           target=""_blank"" rel=""noopener noreferrer"" href=""https://devdojo.com"">
                            <svg viewBox=""0 0 24 24"" class=""w-5 h-5 fill-current"" xmlns=""http://www.w3.org/2000/svg"">
                                <path d=""M23.954 4.569a10 10 0 01-2.825.775 4.958 4.958 0 002.163-2.723c-.951.555-2.005.959-3.127 1.184a4.92 4.92 0 00-8.384 4.482C7.691 8.094 4.066 6.13 1.64 3.161a4.");
                WriteLiteral(@"822 4.822 0 00-.666 2.475c0 1.71.87 3.213 2.188 4.096a4.904 4.904 0 01-2.228-.616v.061a4.923 4.923 0 003.946 4.827 4.996 4.996 0 01-2.212.085 4.937 4.937 0 004.604 3.417 9.868 9.868 0 01-6.102 2.105c-.39 0-.779-.023-1.17-.067a13.995 13.995 0 007.557 2.209c9.054 0 13.999-7.496 13.999-13.986 0-.209 0-.42-.015-.63a9.936 9.936 0 002.46-2.548l-.047-.02z"" />
                            </svg>
                        </a>
                        <a class=""flex items-center block text-gray-400 no-underline hover:text-gray-600""
                           target=""_blank"" rel=""noopener noreferrer"" href=""https://devdojo.com"">
                            <svg viewBox=""0 0 24 24"" class=""w-5 h-5 fill-current"" xmlns=""http://www.w3.org/2000/svg"">
                                <path d=""M12 .297c-6.63 0-12 5.373-12 12 0 5.303 3.438 9.8 8.205 11.385.6.113.82-.258.82-.577 0-.285-.01-1.04-.015-2.04-3.338.724-4.042-1.61-4.042-1.61C4.422 18.07 3.633 17.7 3.633 17.7c-1.087-.744.084-.729.084-.729 1.205.084 1.838 1.236 1.838 1.");
                WriteLiteral(@"236 1.07 1.835 2.809 1.305 3.495.998.108-.776.417-1.305.76-1.605-2.665-.3-5.466-1.332-5.466-5.93 0-1.31.465-2.38 1.235-3.22-.135-.303-.54-1.523.105-3.176 0 0 1.005-.322 3.3 1.23.96-.267 1.98-.399 3-.405 1.02.006 2.04.138 3 .405 2.28-1.552 3.285-1.23 3.285-1.23.645 1.653.24 2.873.12 3.176.765.84 1.23 1.91 1.23 3.22 0 4.61-2.805 5.625-5.475 5.92.42.36.81 1.096.81 2.22 0 1.606-.015 2.896-.015 3.286 0 .315.21.69.825.57C20.565 22.092 24 17.592 24 12.297c0-6.627-5.373-12-12-12"" />
                            </svg>
                        </a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""pt-4 pt-6 mt-10 text-center text-gray-500 border-t border-gray-100"">
            © 2020 Landmark. All rights
            reserved.
        </div>

        <div class=""pt-2 pt-4 mt-2 text-center text-gray-600 border-t border-gray-100"">Distributed By <a href=""https://themewagon.com/"">Themewagon</a></div>
    </footer>
    <script>
        if (document.getElemen");
                WriteLiteral(@"tById('nav-mobile-btn')) {
            document.getElementById('nav-mobile-btn').addEventListener('click', function () {
                if (this.classList.contains('close')) {
                    document.getElementById('nav').classList.add('hidden');
                    this.classList.remove('close');
                } else {
                    document.getElementById('nav').classList.remove('hidden');
                    this.classList.add('close');
                }
            });
        }
    </script>

");
                WriteLiteral("    ");
#nullable restore
#line 287 "D:\WorkNew\StorePromotion\StorePromotion\StorePromotion.UI\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
