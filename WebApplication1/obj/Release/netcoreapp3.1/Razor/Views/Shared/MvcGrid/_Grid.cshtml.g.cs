#pragma checksum "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e9a9f6ed8ab4002dde62497bae432544ade4bec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MvcGrid__Grid), @"mvc.1.0.view", @"/Views/Shared/MvcGrid/_Grid.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\ITransitions\Zadanie4\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITransitions\Zadanie4\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e9a9f6ed8ab4002dde62497bae432544ade4bec", @"/Views/Shared/MvcGrid/_Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b08011c1a23073dc9ba709a50f4b8c572a994b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MvcGrid__Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IGrid>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 8 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
  
    IGridRow<Object>[] rows = Model.Rows.ToArray();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div");
            BeginWriteAttribute("id", " id=\"", 208, "\"", 222, 1);
#nullable restore
#line 12 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 213, Model.Id, 213, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 223, "\"", 294, 4);
            WriteAttributeValue("", 231, "mvc-grid", 231, 8, true);
            WriteAttributeValue(" ", 239, "mvc-grid-", 240, 10, true);
#nullable restore
#line 12 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 249, Model.FilterMode.ToString().ToLower(), 249, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 289, "-mode", 289, 5, true);
            EndWriteAttribute();
            WriteLiteral(" data-name=\"");
#nullable restore
#line 12 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-filter-mode=\"");
#nullable restore
#line 12 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                                                                                 Write(Model.FilterMode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-url=\"");
#nullable restore
#line 12 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                                                                                                              Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n    <");
            WriteLiteral("table");
#nullable restore
#line 13 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
       Write(Model.Attributes);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n        <thead>\n            <tr");
            BeginWriteAttribute("class", " class=\"", 443, "\"", 542, 2);
            WriteAttributeValue("", 451, "mvc-grid-headers", 451, 16, true);
#nullable restore
#line 15 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 467, Model.FilterMode == GridFilterMode.Header ? " mvc-grid-row-filters" : "", 467, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 16 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
             foreach (IGridColumn column in Model.Columns)
            {
                String applied = (column.Filter.First ?? column.Filter.Second) == null ? "" : " applied";


#line default
#line hidden
#nullable disable
            WriteLiteral("                <th");
#nullable restore
#line 20 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
               Write(column.AsAttributes());

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n");
#nullable restore
#line 21 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                 if (column.Filter.IsEnabled == true && !String.IsNullOrEmpty(column.Filter.Name) && Model.FilterMode != GridFilterMode.Row)
                {
                    if (Model.FilterMode == GridFilterMode.Header)
                    {
                        String[] values = column.Filter.First?.Values ?? StringValues.Empty;
                        Int32 size = column.Title is String title && title.Length > 0 ? title.Length : 20;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\n");
#nullable restore
#line 29 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                         if (column.Filter.Options.Any())
                        {
                            values = column.Filter.Options.Where(option => values.Contains(option.Value)).Select(option => option.Text).ToArray();


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 1530, "\"", 1564, 1);
#nullable restore
#line 33 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1538, String.Join(", ", values), 1538, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("size", " size=\"", 1565, "\"", 1577, 1);
#nullable restore
#line 33 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1572, size, 1572, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1578, "\"", 1605, 1);
#nullable restore
#line 33 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1592, column.Title, 1592, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" readonly />\n");
#nullable restore
#line 34 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 1767, "\"", 1801, 1);
#nullable restore
#line 37 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1775, String.Join(", ", values), 1775, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("size", " size=\"", 1802, "\"", 1814, 1);
#nullable restore
#line 37 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1809, size, 1809, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1815, "\"", 1842, 1);
#nullable restore
#line 37 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1829, column.Title, 1829, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 38 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n");
#nullable restore
#line 40 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"mvc-grid-title\">");
#nullable restore
#line 43 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                            Write(column.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 44 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <select class=\"mvc-grid-options\">\n");
#nullable restore
#line 47 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                         foreach (SelectListItem option in column.Filter.Options)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9a9f6ed8ab4002dde62497bae432544ade4bec12384", async() => {
#nullable restore
#line 49 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                                 Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                           WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 50 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\n");
#nullable restore
#line 52 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"

                    if (column.Sort.IsEnabled == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"mvc-grid-sort\"><span>");
#nullable restore
#line 55 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                  Write(column.Sort.Index + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></button>\n");
#nullable restore
#line 56 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 2609, "\"", 2642, 2);
            WriteAttributeValue("", 2617, "mvc-grid-filter", 2617, 15, true);
#nullable restore
#line 58 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 2632, applied, 2632, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\n");
#nullable restore
#line 59 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"mvc-grid-title\">");
#nullable restore
#line 62 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                            Write(column.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 63 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"

                    if (column.Sort.IsEnabled == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"mvc-grid-sort\"><span>");
#nullable restore
#line 66 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                  Write(column.Sort.Index + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></button>\n");
#nullable restore
#line 67 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </th>\n");
#nullable restore
#line 70 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n");
#nullable restore
#line 72 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
         if (Model.FilterMode == GridFilterMode.Row)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"mvc-grid-row-filters\">\n");
#nullable restore
#line 75 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
             foreach (IGridColumn column in Model.Columns)
            {
                String hidden = column.IsHidden ? " mvc-grid-hidden" : "";

                if (column.Filter.IsEnabled == true && !String.IsNullOrEmpty(column.Filter.Name))
                {
                    String applied = (column.Filter.First ?? column.Filter.Second) == null ? "" : " applied";


#line default
#line hidden
#nullable disable
            WriteLiteral("                <th");
            BeginWriteAttribute("class", " class=\"", 3568, "\"", 3616, 3);
            WriteAttributeValue("", 3576, "filterable", 3576, 10, true);
#nullable restore
#line 83 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue(" ", 3586, column.CssClasses, 3587, 20, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 3607, hidden, 3607, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <div>\n");
#nullable restore
#line 85 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                     if (column.Filter.Options.Any())
                    {
                        if (column.Filter.Type == GridFilterType.Multi)
                        {
                            String[] values = column.Filter.First?.Values ?? StringValues.Empty;
                            values = column.Filter.Options.Where(option => values.Contains(option.Value)).Select(option => option.Text).ToArray();


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 4117, "\"", 4151, 1);
#nullable restore
#line 92 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 4125, String.Join(", ", values), 4125, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" readonly />\n");
            WriteLiteral("                        <select class=\"mvc-grid-options\">\n");
#nullable restore
#line 95 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                             foreach (SelectListItem option in column.Filter.Options)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9a9f6ed8ab4002dde62497bae432544ade4bec20485", async() => {
#nullable restore
#line 97 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                                     Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                               WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 98 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\n");
#nullable restore
#line 100 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <select class=\"mvc-grid-value\">\n");
#nullable restore
#line 104 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                             foreach (SelectListItem option in column.Filter.Options)
                            {
                                if (column.Filter.First?.Values.Contains(option.Value) == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9a9f6ed8ab4002dde62497bae432544ade4bec23331", async() => {
#nullable restore
#line 108 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                                              Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                               WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 109 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9a9f6ed8ab4002dde62497bae432544ade4bec25778", async() => {
#nullable restore
#line 112 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                                     Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                               WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 113 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\n");
#nullable restore
#line 116 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 5401, "\"", 5437, 1);
#nullable restore
#line 120 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 5409, column.Filter.First?.Values, 5409, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 121 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 5509, "\"", 5542, 2);
            WriteAttributeValue("", 5517, "mvc-grid-filter", 5517, 15, true);
#nullable restore
#line 122 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 5532, applied, 5532, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\n                    </div>\n                </th>\n");
#nullable restore
#line 125 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th");
            BeginWriteAttribute("class", " class=\"", 5679, "\"", 5716, 2);
#nullable restore
#line 128 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 5687, column.CssClasses, 5687, 20, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 5707, hidden, 5707, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></th>\n");
#nullable restore
#line 129 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n");
#nullable restore
#line 132 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </thead>\n        <tbody>\n");
#nullable restore
#line 135 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
         foreach (IGridRow<Object> row in rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <");
            WriteLiteral("tr");
#nullable restore
#line 137 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
            Write(row.Attributes);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n");
#nullable restore
#line 138 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
             foreach (IGridColumn column in Model.Columns)
            {
                String classes = (column.IsHidden ? column.CssClasses + " mvc-grid-hidden" : column.CssClasses).Trim();

                if (String.IsNullOrEmpty(classes))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 144 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
               Write(column.ValueFor(row));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 145 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td");
            BeginWriteAttribute("class", " class=\"", 6296, "\"", 6312, 1);
#nullable restore
#line 148 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 6304, classes, 6304, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 148 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                Write(column.ValueFor(row));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 149 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </");
            WriteLiteral("tr>\n");
#nullable restore
#line 152 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
         if (!Model.Rows.Any() && Model.EmptyText != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"mvc-grid-empty-row\">\n                <td");
            BeginWriteAttribute("colspan", " colspan=\"", 6534, "\"", 6566, 1);
#nullable restore
#line 156 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 6544, Model.Columns.Count(), 6544, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    ");
#nullable restore
#line 157 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
               Write(Html.Raw(Model.EmptyText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 160 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n");
#nullable restore
#line 162 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
     if (!String.IsNullOrEmpty(Model.FooterPartialViewName))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tfoot>\n            ");
#nullable restore
#line 165 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
       Write(await Html.PartialAsync(Model.FooterPartialViewName, Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tfoot>\n");
#nullable restore
#line 167 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </");
            WriteLiteral("table>\n");
#nullable restore
#line 169 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
     if (Model.Pager != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
   Write(await Html.PartialAsync(Model.Pager.PartialViewName, Model.Pager));

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "D:\ITransitions\Zadanie4\WebApplication1\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IGrid> Html { get; private set; }
    }
}
#pragma warning restore 1591
