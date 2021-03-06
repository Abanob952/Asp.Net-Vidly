#pragma checksum "D:\Courses\Asp.net Mosh\Vidly\Vidly\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16cc18dba78ad93502d43476795fdfb03bacd49e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16cc18dba78ad93502d43476795fdfb03bacd49e", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Courses\Asp.net Mosh\Vidly\Vidly\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "movies";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <h2>Movies</h2>\r\n            ");
#nullable restore
#line 11 "D:\Courses\Asp.net Mosh\Vidly\Vidly\Views\Movies\Index.cshtml"
       Write(Html.ActionLink("Add Movie", "New", "Movies","", new {@class="btn btn-primary mb-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\Courses\Asp.net Mosh\Vidly\Vidly\Views\Movies\Index.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>No Movies Found</h2>\r\n");
#nullable restore
#line 15 "D:\Courses\Asp.net Mosh\Vidly\Vidly\Views\Movies\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table id=""table"" class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"">ID</th>
                            <th scope=""col"">Movie</th>
                            <th>Genre</th>
                            <th>Action</th>

                        </tr>
                    </thead>
                    <tbody id=""Movies"">
");
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 44 "D:\Courses\Asp.net Mosh\Vidly\Vidly\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<div id=""modal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete this Movie ?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""confirm"" class=""btn btn-primary"">Delete</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>


         $(document).ready(function () {
             var table = $('#table').DataTable({
                ajax: {
                    url: ""api/Movies"",
                    dataSrc: """"
                },
                columns: [
                    {
                        data: ""id"",
                        render: function (data) {
                            return ""<th scope='row'>"" + data + ""</th>""
                        }
                    },
                    {
                        data: ""name""

                    },
                    {
                        data: ""genre.name"",

                    },
                    {
                        data: ""id"",
                        render: function (data) {
                            return ""<button class ='btn btn-danger js-delete' data-Movie-id="" + data + "">Delete</button>"";
                        }
                    }
                ]
            });

            var xhr = new XM");
                WriteLiteral(@"LHttpRequest();
            $('#table').on(""click"","".js-delete"", function() {
            $('#modal').modal('toggle')
                var btn = $(this);
                var id = btn.attr(""data-movie-id"");
                console.log(btn);
            $('#confirm').on(""click"", () => {
                xhr.open(""DELETE"", ""api/Movies/"" + id, true);
                xhr.send();
                xhr.onreadystatechange = function () {
                    if (xhr.readyState == xhr.DONE) {
                        if (xhr.status == 200) {
                            table.row(btn.parents(""tr"")).remove().draw();
                            $('#modal').modal('hide');
                        }
                        else {
                            $('#modal').modal('hide');

                            alert(""An Error has Occured"");
                        }
                    }
                }
               
            })

        })

        })
        
           
           

   ");
                WriteLiteral(" </script>\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
