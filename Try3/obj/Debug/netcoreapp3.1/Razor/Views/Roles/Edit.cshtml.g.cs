#pragma checksum "C:\Users\Master.1\source\repos\Try3\Try3\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c0bcf1793e185e330755a4c4bb76c8ad86a3852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Edit), @"mvc.1.0.view", @"/Views/Roles/Edit.cshtml")]
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
#line 1 "C:\Users\Master.1\source\repos\Try3\Try3\Views\_ViewImports.cshtml"
using Try3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Master.1\source\repos\Try3\Try3\Views\_ViewImports.cshtml"
using Try3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Master.1\source\repos\Try3\Try3\Views\Roles\Edit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0bcf1793e185e330755a4c4bb76c8ad86a3852", @"/Views/Roles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d08914eedee2346a365b3e67926aca0bae3a3088", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Try3.Models.ChangeRoleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<h2>Изменение ролей для пользователя ");
#nullable restore
#line 4 "C:\Users\Master.1\source\repos\Try3\Try3\Views\Roles\Edit.cshtml"
                                Write(Model.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c0bcf1793e185e330755a4c4bb76c8ad86a38524238", async() => {
                WriteLiteral("\n    <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 214, "\"", 235, 1);
#nullable restore
#line 7 "C:\Users\Master.1\source\repos\Try3\Try3\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 222, Model.UserId, 222, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <div class=\"form-group\">\n");
#nullable restore
#line 9 "C:\Users\Master.1\source\repos\Try3\Try3\Views\Roles\Edit.cshtml"
         foreach (IdentityRole role in Model.AllRoles)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<input type=\"checkbox\" name=\"roles\"");
                BeginWriteAttribute("value", " value=\"", 369, "\"", 387, 1);
#nullable restore
#line 11 "C:\Users\Master.1\source\repos\Try3\Try3\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 377, role.Name, 377, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\n       ");
#nullable restore
#line 12 "C:\Users\Master.1\source\repos\Try3\Try3\Views\Roles\Edit.cshtml"
   Write(Model.UserRoles.Contains(role.Name) ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />");
#nullable restore
#line 12 "C:\Users\Master.1\source\repos\Try3\Try3\Views\Roles\Edit.cshtml"
                                                                        Write(role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />");
#nullable restore
#line 12 "C:\Users\Master.1\source\repos\Try3\Try3\Views\Roles\Edit.cshtml"
                                                                                              }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\n    <button type=\"submit\" class=\"btn btn-primary\">Сохранить</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Try3.Models.ChangeRoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591