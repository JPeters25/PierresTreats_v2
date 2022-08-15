#pragma checksum "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e0dea4106aade539ae4c13ed288828c37a3212e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Details), @"mvc.1.0.view", @"/Views/Treats/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e0dea4106aade539ae4c13ed288828c37a3212e", @"/Views/Treats/Details.cshtml")]
    #nullable restore
    public class Views_Treats_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PierresTreats.Models.Treat>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""row"">
  <div class=""jumbotron text-center"">
    <h2>Pierre's Treats</h2>
  </div>
</div>
<nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
  <div class=""container-fluid"">
    <a class=""navbar-brand"" href=""#""><img class=""logo"" src='/img/logo.png' width=""100px""/></a>
    <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarText"" aria-controls=""navbarText"" aria-expanded=""false"" aria-label=""Toggle navigation"">
      <span class=""navbar-toggler-icon""></span>
    </button>
    <div class=""collapse navbar-collapse"" id=""navbarText"">
      <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
        <li class=""nav-item"">
          <a class=""nav-link active"" aria-current=""page"" ");
#nullable restore
#line 21 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
                                                    Write(Html.ActionLink("Home","Index","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(">Home</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n          <a class=\"nav-link\"");
#nullable restore
#line 24 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
                        Write(Html.ActionLink("Flavors","Index","Flavors"));

#line default
#line hidden
#nullable disable
            WriteLiteral(">Flavors</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n          <a class=\"nav-link\"");
#nullable restore
#line 27 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
                        Write(Html.ActionLink("Treats","Index","Treats"));

#line default
#line hidden
#nullable disable
            WriteLiteral(">Treats</a>\r\n        </li>\r\n      </ul>\r\n      <span class=\"navbar-text\">\r\n        <button class=\"btn btn-outline-primary\">");
#nullable restore
#line 31 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
                                           Write(Html.ActionLink("Log In", "Login", "Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n        <button class=\"btn btn-outline-primary\">");
#nullable restore
#line 32 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
                                           Write(Html.ActionLink( "Create an account", "Register", "Account" ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n      </span>\r\n    </div>\r\n  </div>\r\n      <div>\r\n");
#nullable restore
#line 37 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
         using (Html.BeginForm("Index", "Treats", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"d-flex\" role=\"search\">\r\n            ");
#nullable restore
#line 40 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
       Write(Html.TextBox("SearchString", null, new { type="search", placeholder = "Search", @class="form-control me-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button class=\"btn btn-outline-success\" type=\"submit\">Search</button>\r\n          </div>\r\n");
#nullable restore
#line 43 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n<hr />\r\n</nav>\r\n<div class=\"row\">\r\n  <div class=\"card\" id=treatCard>\r\n    <h3 class=\"card-title\">Treat Details</h3>\r\n      <div class=\"card-body\">\r\n        <div id=treatList>\r\n          <h4>");
#nullable restore
#line 54 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
         Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 54 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 56 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
           if(@Model.JoinEntities.Count == 0)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>This treat does not have flavor\r\n\r\n            </p>\r\n");
#nullable restore
#line 61 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
          }
          else
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>Flavors:</h4>\r\n            <ul>\r\n");
#nullable restore
#line 66 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
             foreach(var join in Model.JoinEntities)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <li>");
#nullable restore
#line 68 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
             Write(Html.ActionLink($"{join.Flavor.Description}", "Details", "Flavors", new { id = join.Flavor.FlavorId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 69 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 71 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          <p>");
#nullable restore
#line 73 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
        Write(Html.ActionLink("Edit treat", "Edit", new { id = Model.TreatId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          <p>");
#nullable restore
#line 74 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
        Write(Html.ActionLink("Delete Treat", "Delete", new { id = Model.TreatId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          </br>\r\n          <button class=\"btn btn-primary bt-sm\">");
#nullable restore
#line 76 "C:\Users\jpete\OneDrive\Desktop\Coding\PierresTreats.Solution\PierresTreats\Views\Treats\Details.cshtml"
                                           Write(Html.ActionLink("All Treats", "Index", "Treats"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n        </div>\r\n      </div>\r\n  </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PierresTreats.Models.Treat> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
