#pragma checksum "C:\Users\DELL\source\repos\ASP .Net Core\DemoSession10_WebApplication1\DemoSession10_WebApplication1\Views\Demo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb317c6d60a4df566816b16b5820600665aa83af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Index), @"mvc.1.0.view", @"/Views/Demo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb317c6d60a4df566816b16b5820600665aa83af", @"/Views/Demo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_Demo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.6.0.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb317c6d60a4df566816b16b5820600665aa83af3090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('#buttonDemo1').click(function () {
            $.ajax({
                type: 'GET',
                url: '/ajax/demo1',
                success: function (data) {
                    $('#result1').html(data);
                }
            });
        });

        $('#buttonDemo2').click(function () {
            $.ajax({
                type: 'POST',
                url: '/ajax/demo2',
                success: function (data) {
                    $('#result2').html(data);
                }
            });
        });

        $('#buttonDemo3').click(function () {
            var fullName = $('#textboxFullname').val();
            $.ajax({
                type: 'GET',
                data: {
                    name: fullName
                },
                url: '/ajax/demo3',
                success: function (data) {
                    $('#result3').html(data);
                }
            });
        });

  ");
            WriteLiteral(@"      $('#buttonDemo4').click(function () {
            var fullName = $('#textboxFullname2').val();
            $.ajax({
                type: 'POST',
                data: {
                    name1: fullName
                },
                url: '/ajax/demo4',
                success: function (data) {
                    $('#result4').html(data);
                }
            });
        });

        $('#buttonLogin').click(function () {
            var Username = $('#textboxUsername').val();
            var Password = $('#textboxPassword').val();
            $.ajax({
                type: 'POST',
                data: {
                    username: Username,
                    password: Password
                },
                url: '/ajax/login',
                success: function (data) {
                    $('#loginResult').html(data);
                }
            });
        });

        $('#buttonDemo6').click(function () {
            $.ajax({
               ");
            WriteLiteral(@" type: 'GET',
                url: '/ajax/demo6',
                success: function (product) {
                    var result = 'id: ' + product.id;
                    result += '<br>name: ' + product.name;
                    result += '<br>price: ' + product.price;
                    $('#result6').html(result);
                }
            });
        });

        $('#buttonDemo7').click(function () {
            $.ajax({
                type: 'GET',
                url: '/ajax/demo7',
                success: function (products) {
                    var result = """";
                    for (var i = 0; i < products.length; i++) {
                        result += 'id: ' + products[i].id;
                        result += '<br>name: ' + products[i].name;
                        result += '<br>price: ' + products[i].price;
                        result += '<br>-------------------------<br>';
                        $('#result7').html(result);
                    }
               ");
            WriteLiteral(@"    
                }
            });
        });

    });
</script>

<h3>Demo Session</h3>

<input type=""button"" value=""Demo 1"" id=""buttonDemo1"" />
<br />
<span id=""result1""></span>

<h3>Demo Session 2</h3>

<input type=""button"" value=""Demo 2"" id=""buttonDemo2"" />
<br />
<span id=""result2""></span>

<h3>Demo Session 3</h3>

Full Name
<input type=""text"" id=""textboxFullname"" />
<br />
<input type=""button"" value=""Demo3"" id=""buttonDemo3"" />
<br />
<span id=""result3""></span>

<h3>Demo Session 4</h3>

Full Name 2
<input type=""text"" id=""textboxFullname2"" />
<br />
<input type=""button"" value=""Demo3"" id=""buttonDemo4"" />
<br />
<span id=""result4""></span>

<h3>Login</h3>

Username
<input type=""text"" id=""textboxUsername"" />
<br />
Password
<input type=""password"" id=""textboxPassword"" />
<br />
<input type=""button"" value=""Login"" id=""buttonLogin"" />
<br />
<span id=""loginResult""></span>

<h3>Demo Session 6</h3>

<input type=""button"" value=""Demo 6"" id=""buttonDemo6"" />
<br ");
            WriteLiteral("/>\r\n<span id=\"result6\"></span>\r\n\r\n<h3>Demo Session 7</h3>\r\n\r\n<input type=\"button\" value=\"Demo 7\" id=\"buttonDemo7\" />\r\n<br />\r\n<span id=\"result7\"></span>  ");
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