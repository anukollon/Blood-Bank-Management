#pragma checksum "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68c3f1c4bef7ef35024764645ed89bac3946e5f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StaffLogin_DeleteDonor), @"mvc.1.0.view", @"/Views/StaffLogin/DeleteDonor.cshtml")]
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
#line 1 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\_ViewImports.cshtml"
using BloodBankManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\_ViewImports.cshtml"
using BloodBankManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c3f1c4bef7ef35024764645ed89bac3946e5f9", @"/Views/StaffLogin/DeleteDonor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df62c2baee5ae612ff3009f5cb2daf0d6d802c9", @"/Views/_ViewImports.cshtml")]
    public class Views_StaffLogin_DeleteDonor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h3>Delete Donor</h3>\r\n<hr />\r\n");
#nullable restore
#line 9 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
 if (ViewBag.donors.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No Donor data available!</p>\r\n");
#nullable restore
#line 12 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68c3f1c4bef7ef35024764645ed89bac3946e5f94258", async() => {
                WriteLiteral(@"
        <table class=""donor-listing"">
            <tr>
                <th>Donor ID</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Location</th>
                <th>Blood Group</th>
                <th>Select the Donor</th>
            </tr>

");
#nullable restore
#line 26 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
             foreach (var donor in ViewBag.donors)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
                   Write(donor.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
                   Write(donor.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
                   Write(donor.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
                   Write(donor.Address.City);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 32 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
                                        Write(donor.Address.State);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
                   Write(donor.BloodGroup);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><input type=\"checkbox\" name=\"donorIds\"");
                BeginWriteAttribute("value", " value=\"", 980, "\"", 997, 1);
#nullable restore
#line 34 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
WriteAttributeValue("", 988, donor.Id, 988, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"></td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n        <hr />\r\n        <p>\r\n            <input type=\"submit\" value=\"Delete Selected Donors\" class=\"btn btn-danger\">\r\n        </p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\StaffLogin\DeleteDonor.cshtml"
}

#line default
#line hidden
#nullable disable
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
