#pragma checksum "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "359878de5d977fe31fd71170c1c866dcf4ef0ddd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OfficeChecker.Pages.SitePages.Pages_SitePages_Test), @"mvc.1.0.razor-page", @"/Pages/SitePages/Test.cshtml")]
namespace OfficeChecker.Pages.SitePages
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
#line 1 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\_ViewImports.cshtml"
using OfficeChecker;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"359878de5d977fe31fd71170c1c866dcf4ef0ddd", @"/Pages/SitePages/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4a5fe53632434802b6a5254170c7f76d98d52e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SitePages_Test : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
  
    ViewData["Title"] = "Home Page";
    var student = ViewData["Message"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" style=\"margin-top:30px\" >\r\n  <div class=\"row\">\r\n\r\n    <div class=\"col-sm-6\" style=\"height: 250px\">\r\n        <div class=\"header\">\r\n            <h2>");
#nullable restore
#line 14 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
           Write(Html.DisplayFor(model => model.Office.OfficeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n\r\n        <p>");
#nullable restore
#line 17 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.LocationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 18 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 19 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 20 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.OfficeStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 21 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.OfficeServices));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 22 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.Visitors));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 23 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.AdditionalInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

    </div>
    
        
    
    
    <!--covid box -->

    <div class=""col-sm-6"" style=""height: 250px"">
        <div class=""header"">
            <h2>Covid Info</h2>
        </div>
        <p>Temperature Check</p>
        <p>Physical Distancing</p>
        <p>Special Considerations</p>
        <p>Details:</p>
    </div>
</div>
    <!--pinned buttons -->
<div class=""container"" style=""margin-top:30px"" >
  <div class=""row"">
<div class=""col-sm-12"">
    <button type=""button"">Pinned Office</button>
    <button type=""button"">Pinned Office</button>
    <button type=""button"">Pinned Office</button>
    <button type=""button"">Pinned Office</button>
</div>
    
  </div>
</div>

<div class=""container"">
  <div class=""row"">
<div class=""col-sm-12"">
    <button type=""button"">Pinned Office</button>
    <button type=""button"">Pinned Office</button>
    <button type=""button"">Pinned Office</button>
    <button type=""button"">Pinned Office</button>
</div>
    
  </div>
</div>

<p>");
#nullable restore
#line 67 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
Write(Html.DisplayFor(model => model.Office.LocationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 68 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 69 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 70 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.OfficeStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 71 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.OfficeServices));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 72 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.Visitors));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 73 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Test.cshtml"
      Write(Html.DisplayFor(model => model.Office.AdditionalInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OfficeChecker.Pages.SitePages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OfficeChecker.Pages.SitePages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OfficeChecker.Pages.SitePages.IndexModel>)PageContext?.ViewData;
        public OfficeChecker.Pages.SitePages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
