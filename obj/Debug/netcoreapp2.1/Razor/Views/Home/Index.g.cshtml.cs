#pragma checksum "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e424c36a7eca3ae95a2f46142bc7bb6b8bf5aa1"
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
#line 1 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\_ViewImports.cshtml"
using PayRollV1;

#line default
#line hidden
#line 2 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\_ViewImports.cshtml"
using PayRollV1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e424c36a7eca3ae95a2f46142bc7bb6b8bf5aa1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a2de95301afd8cee1c7e86e0daa8bcf2ab1b8b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PayRollV1.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("EmployeeGet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(84, 177, true);
            WriteLiteral("\n<style>\n    \n\nh2\n{\ncolor:deepskyblue;\n}\nth{\n    color:forestgreen;\n}\n.EmployeeGet\n{\n    color:orangered;\n}\n.Sal\n{\n    color:orangered;\n}\n.Pay\n{\n    color:seagreen;\n}\n </style>\n");
            EndContext();
            BeginContext(323, 51, true);
            WriteLiteral("    <h2>PAY ROLL MANAGEMENT</h2>\n\n    <p>\n\n        ");
            EndContext();
            BeginContext(374, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17de7193054b4ab4acc9c981e8bee70b", async() => {
                BeginContext(422, 16, true);
                WriteLiteral("Add New Employee");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(442, 268, true);
            WriteLiteral(@"
    </p>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Employee Name
                </th>

                <th>
                    Designation Name
                </th>
                <th>
                    ");
            EndContext();
            BeginContext(711, 42, false);
#line 48 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(753, 322, true);
            WriteLiteral(@"
                </th>
                <th>
                    Age
                </th>
                <th>
                    Contact Number
                </th>
                <th>
                    Email Address
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 63 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1130, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(1189, 39, false);
#line 67 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1293, 50, false);
#line 70 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DesignationName));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1408, 41, false);
#line 73 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1514, 38, false);
#line 76 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1552, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1617, 40, false);
#line 79 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 65, true);
            WriteLiteral("\n                </td>\n                <td>\n\n                    ");
            EndContext();
            BeginContext(1723, 40, false);
#line 83 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1763, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1828, 56, false);
#line 86 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.EmpID }));

#line default
#line hidden
            EndContext();
            BeginContext(1884, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(1906, 62, false);
#line 87 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.EmpID }));

#line default
#line hidden
            EndContext();
            BeginContext(1968, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(1990, 60, false);
#line 88 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.EmpID }));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 22, true);
            WriteLiteral("\n\n                    ");
            EndContext();
            BeginContext(2073, 109, false);
#line 90 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Salary Details", "SalaryDetails", "Salary", new { id = item.EmpID }, new { @class = "Sal" }));

#line default
#line hidden
            EndContext();
            BeginContext(2182, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2204, 98, false);
#line 91 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Pay Roll", "PayRoll", "PayRoll", new { id = item.EmpID }, new { @class = "Pay" }));

#line default
#line hidden
            EndContext();
            BeginContext(2302, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 94 "C:\Users\Githin.jose\Desktop\PayRoll-master\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2357, 30, true);
            WriteLiteral("        </tbody>\n    </table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PayRollV1.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
