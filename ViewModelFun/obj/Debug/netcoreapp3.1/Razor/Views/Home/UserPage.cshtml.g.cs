#pragma checksum "/Users/javanogden/Desktop/CodingDojo/cSharp/ASP.NETCore/ViewModelFun/ViewModelFun/Views/Home/UserPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02295f38c31140908d448de7d8b39e68e2a78621"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserPage), @"mvc.1.0.view", @"/Views/Home/UserPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02295f38c31140908d448de7d8b39e68e2a78621", @"/Views/Home/UserPage.cshtml")]
    public class Views_Home_UserPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YourNamespace.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
            WriteLiteral("    <h1>Super sweet page for ");
#nullable restore
#line 4 "/Users/javanogden/Desktop/CodingDojo/cSharp/ASP.NETCore/ViewModelFun/ViewModelFun/Views/Home/UserPage.cshtml"
                        Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 4 "/Users/javanogden/Desktop/CodingDojo/cSharp/ASP.NETCore/ViewModelFun/ViewModelFun/Views/Home/UserPage.cshtml"
                                         Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YourNamespace.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591