#pragma checksum "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ea156f8725f8e2895e418fc4c853b8f6d61b2bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetAll), @"mvc.1.0.view", @"/Views/User/GetAll.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\_ViewImports.cshtml"
using TestASP2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\_ViewImports.cshtml"
using TestASP2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea156f8725f8e2895e418fc4c853b8f6d61b2bf", @"/Views/User/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efc6db690d0587cf009a78672e19a65303fe6966", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestASP2.Models.UserModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
  
    ViewData["Title"] = "GetAll";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetAll</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea156f8725f8e2895e418fc4c853b8f6d61b2bf3709", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.userId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.achternaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.geboortedatum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.eMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.telefoonNummer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.profielFoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.userName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayNameFor(model => model.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.userId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.achternaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.geboortedatum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.eMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.telefoonNummer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.profielFoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.userName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 77 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 78 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 81 "C:\Users\Alex\Desktop\FHICT\Fontys-S2\Projecten\TestASP2\TestASP2\Views\User\GetAll.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestASP2.Models.UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
