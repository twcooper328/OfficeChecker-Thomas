#pragma checksum "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Feedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbc2341f9cc24429e9692e9cb8510703b2b443f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OfficeChecker.Pages.SitePages.Pages_SitePages_Feedback), @"mvc.1.0.razor-page", @"/Pages/SitePages/Feedback.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbc2341f9cc24429e9692e9cb8510703b2b443f8", @"/Pages/SitePages/Feedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4a5fe53632434802b6a5254170c7f76d98d52e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SitePages_Feedback : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ThomasWCooper\Documents\GitHub\technique\Pages\SitePages\Feedback.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container row d-flex justify-content-center\" style=\"margin-top:30px\" >\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\"");
            BeginWriteAttribute("style", " style=\"", 241, "\"", 249, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""card bg-dark text-white"" style=""margin-left: 10px;"">
            <!--Top half  -->
            <div class=""header"">
                <h2 class=""text-center"">Feedback</h2>
                <p class=""text-center"">How would you rate your experience?</p>
            </div>
            <div class=""container-fluid"">
            

                 <meta name=""viewport"" content=""width=device-width"">
    


    <!-- alternate codepen version https://codepen.io/mad-d/pen/aJMPWr?editors=0010 -->
    <div class=""card-body align-items-center d-flex justify-content-center""> 
        <div class=""stars"" data-rating=""3"">
            <span class=""star"">&nbsp;</span>
            <span class=""star"">&nbsp;</span>
            <span class=""star"">&nbsp;</span>
            <span class=""star"">&nbsp;</span>
            <span class=""star"">&nbsp;</span>
        </div>
    </div>
    
    
            
            <!--bottom half -->

            <p class=""text-center"">Tell us why:</p>");
            WriteLiteral("\n             <div class=\"col-md-7\">\r\n             \r\n            <textarea id=\"tb\"");
            BeginWriteAttribute("name", " name=\"", 1356, "\"", 1363, 0);
            EndWriteAttribute();
            WriteLiteral(@" rows=""3"" cols=""65"" placeholder=""Comment Here:""></textarea>
            
            <div class=""pbtn"">
                <button type=""button"" class=""btn btn-secondary"">Cancel</button>
                <button type=""button"" class=""btn btn-primary"">Submit</button>
            </div> 
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OfficeChecker.Pages.SitePages.TestModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OfficeChecker.Pages.SitePages.TestModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OfficeChecker.Pages.SitePages.TestModel>)PageContext?.ViewData;
        public OfficeChecker.Pages.SitePages.TestModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
