#pragma checksum "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e9ce37e6083be3b6e1879f0cb8c6aa8f739cfc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VoyagePlanss), @"mvc.1.0.view", @"/Views/Home/VoyagePlanss.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/VoyagePlanss.cshtml", typeof(AspNetCore.Views_Home_VoyagePlanss))]
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
#line 2 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
using VoyagePlanner;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9ce37e6083be3b6e1879f0cb8c6aa8f739cfc7", @"/Views/Home/VoyagePlanss.cshtml")]
    public class Views_Home_VoyagePlanss : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
  
    
    ViewData["Title"] = "ListLocation";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(112, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 10 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
   
    List<Location> location = ViewData["Location"] as List<Location>;
    List<VoyagePlan> voyagePlan = ViewData["VoyagePlan"] as List<VoyagePlan>;

#line default
#line hidden
            BeginContext(269, 585, true);
            WriteLiteral(@"
<div id=""container"" class=""row d-flex justify-content-center m-0"">
    <table class=""table table-hover col-lg-12"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Created By</th>
                <th scope=""col"">Created On</th>
                <th scope=""col"">Modified By</th>
                <th scope=""col"">Modified On</th>
                <th scope=""col"">Departure Time</th>
                <th scope=""col"">Arrival Time</th>
                <th scope=""col"">Location ID</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 30 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
             foreach (var item in voyagePlan)
            {

                string arrival = item.ArrivalTime.ToString();
                string r;
                if (arrival == "1/1/0001 12:00:00 AM") { r = " - "; }
                else { r = item.ArrivalTime.ToString(); }


#line default
#line hidden
            BeginContext(1132, 57, true);
            WriteLiteral("                <tr>\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(1190, 7, false);
#line 39 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
                               Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1197, 30, true);
            WriteLiteral("</th>\n                    <td>");
            EndContext();
            BeginContext(1228, 14, false);
#line 40 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
                   Write(item.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(1242, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1273, 14, false);
#line 41 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
                   Write(item.CreatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(1287, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1318, 15, false);
#line 42 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
                   Write(item.ModifiedBy);

#line default
#line hidden
            EndContext();
            BeginContext(1333, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1364, 15, false);
#line 43 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
                   Write(item.ModifiedOn);

#line default
#line hidden
            EndContext();
            BeginContext(1379, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1410, 18, false);
#line 44 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
                   Write(item.DepartureTime);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 50, true);
            WriteLiteral("</td>\n                    <td class=\"arrivalTime\">");
            EndContext();
            BeginContext(1479, 1, false);
#line 45 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
                                       Write(r);

#line default
#line hidden
            EndContext();
            BeginContext(1480, 32, true);
            WriteLiteral("</td>\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1512, "", 1547, 2);
            WriteAttributeValue("", 1518, "ListLocation/", 1518, 13, true);
#line 46 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
WriteAttributeValue("", 1531, item.LocationID, 1531, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1547, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1549, 15, false);
#line 46 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
                                                         Write(item.LocationID);

#line default
#line hidden
            EndContext();
            BeginContext(1564, 32, true);
            WriteLiteral("</a></td>\n                </tr>\n");
            EndContext();
#line 48 "C:\Users\emreselim.sahin\Source\Repos\VoyagePlanner\VoyagePlanner\Views\Home\VoyagePlanss.cshtml"
             }

#line default
#line hidden
            BeginContext(1611, 37, true);
            WriteLiteral("\n        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
