#pragma checksum "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d9d88363340c1d244dd758c96e192e2ce6a5599"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PastorsView), @"mvc.1.0.view", @"/Views/Home/PastorsView.cshtml")]
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
#line 1 "C:\Users\AfeKunle\source\repos\GospelCares\Views\_ViewImports.cshtml"
using GospelCares;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AfeKunle\source\repos\GospelCares\Views\_ViewImports.cshtml"
using GospelCares.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AfeKunle\source\repos\GospelCares\Views\_ViewImports.cshtml"
using GospelCares.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AfeKunle\source\repos\GospelCares\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AfeKunle\source\repos\GospelCares\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore.Internal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9d88363340c1d244dd758c96e192e2ce6a5599", @"/Views/Home/PastorsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5575c9fcf165c5d857e7dc88edcb8432afb24057", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PastorsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PastorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PastorProcessSingleUnconfirmed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
  
    ViewBag.Title = "Pastors DashBoard";
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<!--UnConfirmed Table-->\r\n<span style=\"font-size:20px\">Unconfirmed Request </span>\r\n<input type=\"text\" name=\"name\" id=\"userInput\"");
            BeginWriteAttribute("value", " value=\"", 230, "\"", 238, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter Your Branch here..."" class=""form-control"" />
<br />
<table class=""table table-striped table-bordered w-100"" id=""DT_load"">

    <!--Table head-->
    <thead>
        <tr>
            <th>No</th>
            <th>Full Name</th>
            <th>Branch</th>
            <th>Pastor's Name</th>
            <th>Need</th>
            <th>Phone</th>
            <th>Address</th>
            <th>Action</th>
        </tr>
    </thead>
    <!--Table head-->
    <!--Table body-->
    <tbody>
");
#nullable restore
#line 31 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
         foreach (var req in Model.UnConfirmedRequest)
        {
            i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-info\">\r\n                <input hidden");
            BeginWriteAttribute("value", " value=\"", 911, "\"", 933, 1);
#nullable restore
#line 35 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
WriteAttributeValue("", 919, req.RequestId, 919, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <th scope=\"row\">");
#nullable restore
#line 36 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
               Write(req.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
               Write(req.Branch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
               Write(req.PastorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
               Write(req.Need);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
               Write(req.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
               Write(req.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d9d88363340c1d244dd758c96e192e2ce6a55997841", async() => {
                WriteLiteral("Process");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
                                                                                           WriteLiteral(req.RequestId);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\AfeKunle\source\repos\GospelCares\Views\Home\PastorsView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <!--Table body-->\r\n</table>\r\n<!--Table-->\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"
    <script>
        let table = document.getElementById('DT_load');
        let input = document.getElementById('userInput');

        input.addEventListener('keyup', filterTable);

        function filterTable() {
            let input = document.getElementById('userInput').value;
            let filter, tr, td, i, txtValue;

            filter = input.toUpperCase();
            tr = table.getElementsByTagName(""tr"");

            //loop through table
            for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagName(""td"")[1];
                if (td) {
                    txtValue = td.textContent || td.innerText;
                    if (txtValue.toUpperCase().indexOf(filter) > -1) {
                        tr[i].style.display = """";
                    } else {
                        tr[i].style.display = ""none"";
                    }
                }
            }

            console.log(input);

        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PastorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
