#pragma checksum "C:\Users\USER\Desktop\Projects\SchoolWebsite-master\SchoolWebsite\schoolwebsite\Views\Attendances\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "136b940aab36e1c27eba2d5bf65ec0af8affbe96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendances_Index2), @"mvc.1.0.view", @"/Views/Attendances/Index2.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\Projects\SchoolWebsite-master\SchoolWebsite\schoolwebsite\Views\_ViewImports.cshtml"
using schoolwebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\Projects\SchoolWebsite-master\SchoolWebsite\schoolwebsite\Views\_ViewImports.cshtml"
using schoolwebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"136b940aab36e1c27eba2d5bf65ec0af8affbe96", @"/Views/Attendances/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcc2e22182cca0b826adabff00e8be3f7030b854", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendances_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\USER\Desktop\Projects\SchoolWebsite-master\SchoolWebsite\schoolwebsite\Views\Attendances\Index2.cshtml"
  
    ViewData["Title"] = "Searchbox";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <div class=\"row\">\r\n        <label class=\"form-group\">Class</label>\r\n        <input type=\"search\" class=\"form-group col-4\" name=\"name\" id=\"class\"");
            BeginWriteAttribute("value", " value=\"", 251, "\"", 259, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"row\">\r\n        <label class=\"form-group\">Roll</label>\r\n        <input type=\"search\" class=\"form-group col-4\" name=\"name\" id=\"roll\"");
            BeginWriteAttribute("value", " value=\"", 423, "\"", 431, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
    <input type=""button"" class=""btn btn-dark"" name"" id=""searchbutton"" value=""Search"" />
</div>



<div style=""margin-bottom:50px;display:none;"" class=""card"" id=""main"">
    <h3 style=""padding-bottom:50px;"">Personal Information</h3>
    <div class=""row"">
        <p class=""titleheading col-3"">Name:</p>
        <h2 class=""title col-4"" style=""color:red;"" id=""name""></h2>
    </div>
    <div class=""row"">
        <p class=""titleheading col-3"">Class:</p>
        <p class=""title col-4"" id=""class""></p>
    </div>
    <div class=""row"">
        <p class=""titleheading col-3"">Section:</p>
        <p class=""title col-4"" id=""section""></p>
    </div>
    <div class=""row"">
        <p class=""titleheading col-3"">Roll:</p>
        <p class=""title col-4"" id=""roll""></p>
    </div>
    <div class=""row"">
        <p class=""titleheading col-3"">Parent's Contact:</p>
        <p class=""title col-4"" id=""parentscontact""></p>
    </div>

    <div class=""row"">
        <p class=""titleheading col-3"">");
            WriteLiteral("Address:</p>\r\n        <p class=\"title col-4\" id=\"address\"></p>\r\n    </div>\r\n\r\n\r\n\r\n\r\n    \r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        $(document).ready(function () {

            $(""#searchbutton"").click(function () {
                let classinfo = $(""#class"").val();
                let roll = $(""#roll"").val();
                console.log(classinfo, roll);
                //$(""#main"").css(""display"", ""block"");


                $.post(""/Attendances/Individual"",
                    {
                        classinfo: classinfo,
                        roll: roll
                    },

                    function (data, status) {
                        console.log(""Data: "" + data + ""\nStatus: "" + status);
                    }
                );
            });
        });
    </script>
");
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