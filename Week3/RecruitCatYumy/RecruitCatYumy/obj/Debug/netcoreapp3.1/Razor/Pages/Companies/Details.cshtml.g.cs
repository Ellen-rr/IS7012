#pragma checksum "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac480ecd204c1e0b19a85a71f9cc6c4caf03d562"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecruitCatYumy.Pages.Companies.Pages_Companies_Details), @"mvc.1.0.razor-page", @"/Pages/Companies/Details.cshtml")]
namespace RecruitCatYumy.Pages.Companies
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
#line 1 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\_ViewImports.cshtml"
using RecruitCatYumy;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac480ecd204c1e0b19a85a71f9cc6c4caf03d562", @"/Pages/Companies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a95df01cbfbad92ceb8e4f81a38b1c39be3777d9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Companies_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Companies Details</h1>\r\n\r\n<div>\r\n   \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.MinimumSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.MinimumSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.MaximumSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.MaximumSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.Industry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.Industry.IndustryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.Income));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.Income));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company.NumberOfEmployee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company.NumberOfEmployee));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
</div>






<div>
    <table class=""table table-bordered"">
        <thead>

            <tr>

                <th>Employee FirstName</th>
                <th>Employee Last Name</th>
                <th>Employee Salary</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 89 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
             foreach(var emp in Model.Company.Candidates)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 92 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
               Write(Html.DisplayFor(modelItem => emp.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 93 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
               Write(Html.DisplayFor(modelItem => emp.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 94 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
               Write(Html.DisplayFor(modelItem => emp.TargetSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 97 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            \r\n\r\n        </tbody>\r\n    </table>\r\n\r\n</div>\r\n  \r\n    \r\n\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac480ecd204c1e0b19a85a71f9cc6c4caf03d56211887", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\75074\Desktop\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Companies\Details.cshtml"
                           WriteLiteral(Model.Company.CompanyId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac480ecd204c1e0b19a85a71f9cc6c4caf03d56214054", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecruitCatYumy.Pages.Companies.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecruitCatYumy.Pages.Companies.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecruitCatYumy.Pages.Companies.DetailsModel>)PageContext?.ViewData;
        public RecruitCatYumy.Pages.Companies.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
