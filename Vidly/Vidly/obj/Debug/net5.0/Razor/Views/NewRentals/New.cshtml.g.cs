#pragma checksum "D:\Courses\Asp.net Mosh\Vidly\Vidly\Views\NewRentals\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "557dc5afd7ad7677b3354d5d75fc49f79c4894a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewRentals_New), @"mvc.1.0.view", @"/Views/NewRentals/New.cshtml")]
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
#line 1 "D:\Courses\Asp.net Mosh\Vidly\Vidly\Views\_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Courses\Asp.net Mosh\Vidly\Vidly\Views\_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557dc5afd7ad7677b3354d5d75fc49f79c4894a9", @"/Views/NewRentals/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_NewRentals_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("rentalForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formr"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/additional-methods.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Courses\Asp.net Mosh\Vidly\Vidly\Views\NewRentals\New.cshtml"
  
    ViewData["Title"] = "New Rental";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>New Rental</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557dc5afd7ad7677b3354d5d75fc49f79c4894a95498", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label>Customer</label>
        <input id=""cust"" data-rule-validateCustomer=""true"" name=""customer"" required type=""text"" class=""form-control"" />
    </div>
    <div id=""custr"" class=""custr""></div>
    <ul id=""custlist"" class=""mb-3 list-group""></ul>
    <div class=""form-group"">
        <label>Movie</label>
        <input data-rule-validateMovie=""true"" name=""movie"" id=""movieI"" type=""text"" class=""form-control"" />
    </div>

    <div id=""movier"" class=""movier""></div>
    <ul id=""movlist"" class=""mb-3 list-group""></ul>

    <button type=""submit"" class=""btn btn-primary"">Submit</button>
");
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
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557dc5afd7ad7677b3354d5d75fc49f79c4894a97678", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557dc5afd7ad7677b3354d5d75fc49f79c4894a98777", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557dc5afd7ad7677b3354d5d75fc49f79c4894a99876", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        var vm = {
            CustomerId: """",
            MoviesId: []
        }
        var customer = document.getElementById(""cust"");
        var check = true;
        customer.addEventListener(""keyup"", function (event) {
            let text = event.target.value.length;

            if (text >= 3 && check) {
                var xhr = new XMLHttpRequest();
                xhr.open(""GET"", ""https://localhost:44301/api/CustomersApi?query="" + event.target.value);
                xhr.send();
                xhr.onreadystatechange = function () {
                    if (xhr.readyState == xhr.DONE) {
                        if (xhr.status == 200) {
                            var arr = JSON.parse(xhr.responseText);
                            let custr = document.getElementById(""custr"");
                            if (arr.length != 0)
                                custr.style.visibility = ""visible"";


                            arr.forEach(obj => {
                     ");
                WriteLiteral(@"           custr.innerHTML += ""<a class='suggest' onClick='select(event,"" + obj.id + "")' value='"" + obj.id + ""'>"" + obj.name + ""</a>""
                            })

                            //check = false;


                        }
                    }
                }
            }
            if (!event.target.value) {
                check = true;
                let custr = document.getElementById(""custr"");
                custr.innerHTML = """";
                custr.style.visibility = ""hidden"";
            }
        });
        function select($event, dd) {
            let custr = document.getElementById(""custr"");
            custr.innerHTML = """";
            custr.style.visibility = ""hidden"";
            let list = document.getElementById(""custlist"");
            list.innerHTML = """";
            let id = dd;
            let name = $event.target.innerText;
            document.getElementById(""cust"").value = name;
            list.innerHTML += ""<li value='"" + id + ""' clas");
                WriteLiteral(@"s='list-group-item disabled'>"" + name + ""</li>"";
            vm.CustomerId = id;

        }
        function select2($event, dd) {
            let custr = document.getElementById(""movier"");
            custr.innerHTML = """";
            custr.style.visibility = ""hidden"";
            let list = document.getElementById(""movlist"");

            let id = dd;
            let name = $event.target.innerText;
            list.innerHTML += ""<li value='"" + id + ""' class='list-group-item disabled'>"" + name + ""</li>"";
            vm.MoviesId.push(id);
        }
        var checks = true;
        $(""#movieI"").on(""keyup"", function (event) {


            if (event.target.value.length >= 3 && checks) {
                $.ajax({
                    url: ""https://localhost:44301/api/Movies?query="" + event.target.value,
                    success: function (result) {

                        var arr = result;
                        var movier = document.getElementById(""movier"");
                      ");
                WriteLiteral(@"  movier.style.visibility = ""visible"";
                        movier.innerHTML = """";
                        arr.forEach(obj => {
                            movier.innerHTML += ""<a class='suggest' onClick='select2(event,"" + obj.id + "")' value='"" + obj.id + ""'>"" + obj.name + ""</a>""
                        });
                        //checks = false;
                    }
                });
            }
            console.log(event.target.value);
            if (!event.target.value) {
                movier.innerHTML = """";
                movier.style.visibility = ""hidden"";

                checks = true;
            }
        })
       
       $(document).ready(function () {
           console.log(""hello"");

           $.validator.addMethod(""validateMovie"", function () {
               return vm.MoviesId.length > 0;
           }, ""Please select at least one Movie"");

           $.validator.addMethod(""validateCustomer"", function () {
               return vm.CustomerId && vm.Cust");
                WriteLiteral(@"omerId > 0;
           }, ""Please enter a valid customer"");

           $(""#rentalForm"").validate({
               submitHandler: function (e) {
                   // e.preventDefault();
                    fetch(""https://localhost:44301/api/Rentals"", {
                        method: ""POST"", body: JSON.stringify(vm), headers: {
                            'Content-Type': 'application/json'
                        }
                    }).then(response => {
                        toastr.success(""New Rental Was added Successfully"");
                        console.log(response);
                    }).catch(err => toastr.error(""An unexpected error has occured""));
                   return false;
                }
            });
        });
        document.addEventListener(""click"", function () {

            let custr = document.getElementById(""custr"");
            custr.innerHTML = """";
            custr.style.visibility = ""hidden"";

            
            let movier = document.get");
                WriteLiteral("ElementById(\"movier\");\r\n            movier.innerHTML = \"\";\r\n            movier.style.visibility = \"hidden\";\r\n\r\n\r\n        });\r\n                    //$(\"#rentalForm\").on(\"submit\", function (e) {\r\n\r\n                    //});\r\n    </script>\r\n\r\n");
            }
            );
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