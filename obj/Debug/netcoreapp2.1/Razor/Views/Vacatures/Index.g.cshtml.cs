#pragma checksum "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "915e0fb27810ff56739b28c4132d4cd1df743442"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vacatures_Index), @"mvc.1.0.view", @"/Views/Vacatures/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vacatures/Index.cshtml", typeof(AspNetCore.Views_Vacatures_Index))]
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
#line 1 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\_ViewImports.cshtml"
using Jobbook;

#line default
#line hidden
#line 2 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\_ViewImports.cshtml"
using Jobbook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"915e0fb27810ff56739b28c4132d4cd1df743442", @"/Views/Vacatures/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d3a6cc6e2e99150824e5fa17cba04b4c98ac381", @"/Views/_ViewImports.cshtml")]
    public class Views_Vacatures_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Jobbook.Models.JobbookVacatureModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
  
    ViewData["Title"] = "Vacatures";

#line default
#line hidden
            BeginContext(104, 31, true);
            WriteLiteral("\r\n<h2>Vacatures</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(135, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "035bd88751ba42c8809ab934c5e30f75", async() => {
                BeginContext(158, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(172, 69, true);
            WriteLiteral("\r\n</p>\r\n<div class=\"container\">\r\n    <div class=\"row vacatureCard\">\r\n");
            EndContext();
#line 13 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(290, 58, true);
            WriteLiteral("        <div class=\"col-md-6 col-sm-12\">\r\n            <h3>");
            EndContext();
            BeginContext(349, 43, false);
#line 16 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobTitle));

#line default
#line hidden
            EndContext();
            BeginContext(392, 22, true);
            WriteLiteral("</h3>\r\n            <p>");
            EndContext();
            BeginContext(415, 46, false);
#line 17 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
          Write(Html.DisplayFor(modelItem => item.JobLocation));

#line default
#line hidden
            EndContext();
            BeginContext(461, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(494, 104, true);
            WriteLiteral("    </div>\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(599, 48, false);
#line 26 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobCompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(647, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(703, 48, false);
#line 29 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobPublished));

#line default
#line hidden
            EndContext();
            BeginContext(751, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(807, 50, false);
#line 32 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobExpiredDate));

#line default
#line hidden
            EndContext();
            BeginContext(857, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(913, 44, false);
#line 35 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobTitle));

#line default
#line hidden
            EndContext();
            BeginContext(957, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1013, 50, false);
#line 38 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1119, 47, false);
#line 41 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1222, 51, false);
#line 44 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobContractType));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1329, 52, false);
#line 47 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobContractHours));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1437, 48, false);
#line 50 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobSeniority));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1541, 45, false);
#line 53 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobSalary));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1642, 46, false);
#line 56 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobDaysOff));

#line default
#line hidden
            EndContext();
            BeginContext(1688, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1744, 46, false);
#line 59 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobExpired));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1846, 51, false);
#line 62 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobContactEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1953, 49, false);
#line 65 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobContactTel));

#line default
#line hidden
            EndContext();
            BeginContext(2002, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 71 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2120, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2169, 47, false);
#line 74 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobCompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(2216, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2272, 47, false);
#line 77 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobPublished));

#line default
#line hidden
            EndContext();
            BeginContext(2319, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2375, 49, false);
#line 80 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobExpiredDate));

#line default
#line hidden
            EndContext();
            BeginContext(2424, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2480, 43, false);
#line 83 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobTitle));

#line default
#line hidden
            EndContext();
            BeginContext(2523, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2579, 49, false);
#line 86 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2628, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2684, 46, false);
#line 89 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobLocation));

#line default
#line hidden
            EndContext();
            BeginContext(2730, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2786, 50, false);
#line 92 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobContractType));

#line default
#line hidden
            EndContext();
            BeginContext(2836, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2892, 51, false);
#line 95 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobContractHours));

#line default
#line hidden
            EndContext();
            BeginContext(2943, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2999, 47, false);
#line 98 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobSeniority));

#line default
#line hidden
            EndContext();
            BeginContext(3046, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3102, 44, false);
#line 101 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobSalary));

#line default
#line hidden
            EndContext();
            BeginContext(3146, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3202, 45, false);
#line 104 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobDaysOff));

#line default
#line hidden
            EndContext();
            BeginContext(3247, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3303, 45, false);
#line 107 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobExpired));

#line default
#line hidden
            EndContext();
            BeginContext(3348, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3404, 50, false);
#line 110 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobContactEmail));

#line default
#line hidden
            EndContext();
            BeginContext(3454, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3510, 48, false);
#line 113 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobContactTel));

#line default
#line hidden
            EndContext();
            BeginContext(3558, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3613, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "826f42be05d14cc2ae602da9b6c95145", async() => {
                BeginContext(3658, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 116 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(3666, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3686, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b691b58dee6447d59761d5305be9e184", async() => {
                BeginContext(3734, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 117 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(3745, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3765, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01df11cc25e841ecb3e2273e2dab102b", async() => {
                BeginContext(3812, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(3822, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 121 "C:\Users\jasonslabbers\Documents\Projects\Jobbook\Views\Vacatures\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3861, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Jobbook.Models.JobbookVacatureModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
