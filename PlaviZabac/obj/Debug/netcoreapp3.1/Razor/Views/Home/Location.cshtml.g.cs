#pragma checksum "C:\Projects\PlaviZabac\PlaviZabac\Views\Home\Location.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bb94357d1647e45e5cdf3126fe0bac75865c994"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Location), @"mvc.1.0.view", @"/Views/Home/Location.cshtml")]
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
#line 1 "C:\Projects\PlaviZabac\PlaviZabac\Views\_ViewImports.cshtml"
using PlaviZabac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\PlaviZabac\PlaviZabac\Views\_ViewImports.cshtml"
using PlaviZabac.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb94357d1647e45e5cdf3126fe0bac75865c994", @"/Views/Home/Location.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5eff4f856ff64dd0337b6c06cef7b0cae9922ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Location : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Projects\PlaviZabac\PlaviZabac\Views\Home\Location.cshtml"
  
    ViewData["Title"] = "Location";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lokacija nase radnje</h1>\r\n\r\n");
            WriteLiteral(@"<div id=""map"" style=""width:100%;height:400px;""></div>

<script type=""text/javascript"">
    function initMap() {

        //Set the Latitude and Longitude of the Map
        var myAddress = new google.maps.LatLng(44.8177777778, 20.4569444444);

        //Create Options or set different Characteristics of Google Map
        var mapOptions = {
            center: myAddress,
            zoom: 15,
            minZoom: 15,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };

        //Display the Google map in the div control with the defined Options
        var map = new google.maps.Map(document.getElementById(""map""), mapOptions);

        //Set Marker on the Map
        var marker = new google.maps.Marker({
            position: myAddress,
        });

        marker.setMap(map);
    }
</script>");
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
