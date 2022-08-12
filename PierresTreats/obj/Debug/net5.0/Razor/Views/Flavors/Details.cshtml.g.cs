#pragma checksum "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "942f162374ae3ad2ea3f391947c2cb08d44e423d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Details), @"mvc.1.0.view", @"/Views/Flavors/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"942f162374ae3ad2ea3f391947c2cb08d44e423d", @"/Views/Flavors/Details.cshtml")]
    #nullable restore
    public class Views_Flavors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PierresTreats.Models.Flavor>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"jumbotron text-center\">\r\n  <h2>Flavor Details</h2>\r\n</div>\r\n\r\n<h3>");
#nullable restore
#line 11 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 11 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This flavor does not contain any treats\r\n\r\n  </p>\r\n");
#nullable restore
#line 18 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Flavor of Treats:</h4>\r\n  <ul>\r\n");
#nullable restore
#line 23 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 25 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
   Write(Html.ActionLink($"{join.Treat.Name}", "Details", "Treats", new { id = join.Treat.TreatId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 26 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n");
#nullable restore
#line 28 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 30 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
Write(Html.ActionLink("Add new treat", "Create", "Treats"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 31 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
Write(Html.ActionLink("Back to flavors", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 32 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
Write(Html.ActionLink("Edit flavor", "Edit", new { id = Model.FlavorId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 33 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Flavors\Details.cshtml"
Write(Html.ActionLink("Delete Flavor", "Delete", new { id = Model.FlavorId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PierresTreats.Models.Flavor> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
