#pragma checksum "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114b6a4400fcfde6de7c2741720a53eed6174127"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListDonor_Index), @"mvc.1.0.view", @"/Views/ListDonor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114b6a4400fcfde6de7c2741720a53eed6174127", @"/Views/ListDonor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df62c2baee5ae612ff3009f5cb2daf0d6d802c9", @"/Views/_ViewImports.cshtml")]
    public class Views_ListDonor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ListDonor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditDonor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Text", new global::Microsoft.AspNetCore.Html.HtmlString("Edit Donor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("CssClass", new global::Microsoft.AspNetCore.Html.HtmlString("ButtonClass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    #map {
        height: 400px;
        width: 100%
    }
</style>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-10 mx-auto"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <h4>Donor List</h4>
                        </div>
                    </div>
");
#nullable restore
#line 17 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                     if (ViewBag.donors.Count == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-12\">\r\n                                <h4>No Donor data available!</h4>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 24 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "114b6a4400fcfde6de7c2741720a53eed61741276401", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-12 align-content-center"">
                                    <table class=""donor-listing"">
                                        <tr>
                                            <th>Donor ID</th>
                                            <th>First Name</th>
                                            <th>Last Name</th>
                                            <th>Location</th>
                                            <th>Email</th>
                                            <th>Contact Number</th>
                                            <th>Blood Group</th>
                                            <th></th>
                                        </tr>

");
#nullable restore
#line 42 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                                         foreach (var donor in ViewBag.donors)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 45 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                                               Write(donor.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 46 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                                               Write(donor.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 47 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                                               Write(donor.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 48 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                                               Write(donor.Address.City);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 48 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                                                                    Write(donor.Address.State);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 49 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                                               Write(donor.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 50 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                                               Write(donor.ContactNum);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 51 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                                               Write(donor.BloodGroup);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "114b6a4400fcfde6de7c2741720a53eed617412710758", async() => {
                    WriteLiteral("Edit");
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
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-value", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                                                                                                              WriteLiteral(donor.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-value", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </table>                                   \r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div><br /></div>\r\n                    <div id=\"map\"></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<script>\r\n");
            WriteLiteral("    var map;\r\n    var markers = [];\r\n    var locationCount = ");
#nullable restore
#line 72 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
                   Write(ViewBag.locations.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    var counter = 0;

    function initialize() {

        latlng = { lat: 37.0902, lng: -95.7129 }; //Latitude and Longitude of the USA
        var options = {
            center: latlng,
            zoom: 4
        }
        map = new google.maps.Map(document.getElementById(""map""), options); //Load the map

        //Serialize the donor locations from ViewBag to JS variable
        var loc = ");
#nullable restore
#line 85 "C:\Users\BB\Desktop\New folder\LaunchCode\Liftoff\Project repo\BloodBankManagement\Views\ListDonor\Index.cshtml"
             Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.locations)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

        for (var i = 0; i < locationCount; i++) {
            var location = loc[i];
            geoCode(location);
        }
    }

    //Use the GeoCode Google API to get the latitude and longitude of a specific city
    async function geoCode(strLocation) {
        var latlng;
        await axios.get('https://maps.googleapis.com/maps/api/geocode/json', {
            params: {
                address: strLocation,
                key: 'AIzaSyCsblRNfAsjZaNgyd76oZPjFNA3GPo5Gw0'
            }
        })
            .then(function (response) {
                if (response.data.results.length > 0) {

                    var lat = response.data.results[0].geometry.location.lat;
                    var lng = response.data.results[0].geometry.location.lng;
                    latlng = { lat: lat, lng: lng };
                    //Add Marker
                    var marker = new google.maps.Marker({
                        position: latlng,
                        label: strLocation
    ");
            WriteLiteral(@"                });

                    markers.push(marker); //push the marker to a array of markers
                counter++;
                //once you reach the end of the location iteration, create a new MarkerClusterer
                if (counter == locationCount) {
                        var markerCluster = new MarkerClusterer(map, markers,
                            {
                                imagePath: 'images/m',
                                gridSize: 20
                            });
                    }
               }
            })
            .catch(function (error) {
                console.log(error);
            });
    }
    google.maps.event.addDomListener(window, ""load"", initialize);
</script>


");
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
