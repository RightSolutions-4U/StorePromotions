#pragma checksum "D:\WorkNew\StorePromotion\StorePromotion\StorePromotion.UI\Views\Shared\register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5aa1cddd90ae579e0fb6b26189507da9ff710f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_register), @"mvc.1.0.view", @"/Views/Shared/register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5aa1cddd90ae579e0fb6b26189507da9ff710f8", @"/Views/Shared/register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f9ecccaf3ab1fa8ab3421cf4d23a0172ec43800", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"    <!-- Start Contact -->
<section class=""container py-5"">

    <h1 class=""col-12 col-xl-8 h2 text-left text-primary pt-3"">Store Owner</h1>
    <p class=""col-12 col-xl-8 text-left text-muted pb-5 light-300"">
        Please fill details to get register!
    </p>

    <div class=""row pb-4"">


        <!-- Start Contact Form -->
        <div class=""col-lg-12 "">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5aa1cddd90ae579e0fb6b26189507da9ff710f84653", async() => {
                WriteLiteral(@"

                <div class=""col-lg-6 mb-4"">
                    <div class=""form-floating"">
                        <input type=""text"" class=""form-control form-control-lg light-300"" id=""Fname"" name=""Fname"" placeholder=""First Name"">
                        <label for=""Fname light-300"">First Name</label>
                    </div>
                </div><!-- End Input Name -->
                <div class=""col-lg-6 mb-4"">
                    <div class=""form-floating"">
                        <input type=""text"" class=""form-control form-control-lg light-300"" id=""Lname"" name=""Lname"" placeholder=""Last Name"">
                        <label for=""Lname light-300"">Last Name</label>
                    </div>
                </div><!-- End Input Name -->
                <div class=""col-lg-6 mb-4"">
                    <div class=""form-floating"">
                        <input type=""text"" class=""form-control form-control-lg light-300"" id=""CellNo"" name=""CellNo"" placeholder=""CellNo"">
                       ");
                WriteLiteral(@" <label for=""CellNo light-300"">Cell No.</label>
                    </div>
                </div>
                <div class=""col-lg-6 mb-4"">
                    <div class=""form-floating"">
                        <input type=""text"" class=""form-control form-control-lg light-300"" id=""Email"" name=""Email"" placeholder=""Email"">
                        <label for=""Email light-300"">Email</label>
                    </div>
                </div><!-- End Input Email -->

                <div class=""col-lg-6 mb-4"">
                    <div class=""form-floating"">
                        <input type=""text"" class=""form-control form-control-lg light-300"" id=""UserId"" name=""UserId"" placeholder=""User Id"">
                        <label for=""UserId light-300"">User Id</label>
                    </div>
                </div><!-- End Input Phone -->

                <div class=""col-lg-6 mb-4"">
                    <div class=""form-floating"">
                        <input type=""text"" class=""form-control form-co");
                WriteLiteral(@"ntrol-lg light-300"" id=""Pwd"" name=""Pwd"" placeholder=""Pwd"">
                        <label for=""Pwd light-300"">Password</label>
                    </div>
                </div>

                <div class=""col-lg-6 mb-4"">
                    <div class=""form-floating"">
                        <input type=""text"" class=""form-control form-control-lg light-300"" id=""CPwd"" name=""CPwd"" placeholder=""CPwd"">
                        <label for=""CPwd light-300"">Confirm Password</label>
                    </div>
                </div>

                <div class=""col-md-12 col-12 m-auto text-end"">
                    <button type=""submit"" class=""btn btn-secondary rounded-pill px-md-5 px-4 py-2 radius-0 text-light light-300"">Save Info.</button>
");
                WriteLiteral(@"                </div>
                <script>
                    function Register1() {
                        var FName = $('#Fname').val();
                        var LName = $('#Lname').val();
                        var CellNo = $('#CellNo').val();
                        var Email1 = $('#Email').val();
                        var UserId = $('#UserId').val();
                        var Pwd1 = $('#Pwd').val();
                        var MyStoreOwner = {
                            FName: Fname,
                            LName: LName,
                            CellNo: CellNo,
                            Email: Email1,
                            UserId: UserId,
                            Pwd: Pwd1
                        }
                        $.ajax({
                            url: '/StoreOwner/Create',
                            type: 'POST',
                            dataType: 'json',
                            contentType: 'application/json; charset=utf-8',
   ");
                WriteLiteral(@"                         data: JSON.stringify(MyStoreOwner)
                            , success: function (result) {
                                alert(""Registered: "");
                            }
                            , error: function (result) {
                                alert(""err "" + result.responseText);
                            }
                        })
                    }
                </script>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "D:\WorkNew\StorePromotion\StorePromotion\StorePromotion.UI\Views\Shared\register.cshtml"
AddHtmlAttributeValue("", 452, Url.Action("Create", "StoreOwner"), 452, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <!-- End Contact Form -->\r\n\r\n\r\n    </div>\r\n</section>\r\n<!-- End Contact -->");
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
