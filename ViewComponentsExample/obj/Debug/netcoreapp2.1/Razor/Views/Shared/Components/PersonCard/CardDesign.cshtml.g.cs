#pragma checksum "D:\20610\20486D\Allfiles\Mod05\Democode\05_ViewComponentsExample_begin\ViewComponentsExample\Views\Shared\Components\PersonCard\CardDesign.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64334adfc404767d48e0e056082a550054963283"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PersonCard_CardDesign), @"mvc.1.0.view", @"/Views/Shared/Components/PersonCard/CardDesign.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/PersonCard/CardDesign.cshtml", typeof(AspNetCore.Views_Shared_Components_PersonCard_CardDesign))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64334adfc404767d48e0e056082a550054963283", @"/Views/Shared/Components/PersonCard/CardDesign.cshtml")]
    public class Views_Shared_Components_PersonCard_CardDesign : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(11, 26, true);
            WriteLiteral("<td>\n    <div>First Name: ");
            EndContext();
            BeginContext(38, 31, false);
#line 3 "D:\20610\20486D\Allfiles\Mod05\Democode\05_ViewComponentsExample_begin\ViewComponentsExample\Views\Shared\Components\PersonCard\CardDesign.cshtml"
                Write(ViewBag.People[Model].FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(69, 27, true);
            WriteLiteral("</div>\n    <div>Last Name: ");
            EndContext();
            BeginContext(97, 30, false);
#line 4 "D:\20610\20486D\Allfiles\Mod05\Democode\05_ViewComponentsExample_begin\ViewComponentsExample\Views\Shared\Components\PersonCard\CardDesign.cshtml"
               Write(ViewBag.People[Model].LastName);

#line default
#line hidden
            EndContext();
            BeginContext(127, 27, true);
            WriteLiteral("</div>\n    <div>Residence: ");
            EndContext();
            BeginContext(155, 29, false);
#line 5 "D:\20610\20486D\Allfiles\Mod05\Democode\05_ViewComponentsExample_begin\ViewComponentsExample\Views\Shared\Components\PersonCard\CardDesign.cshtml"
               Write(ViewBag.People[Model].Address);

#line default
#line hidden
            EndContext();
            BeginContext(184, 23, true);
            WriteLiteral("</div>\n    <div>Phone: ");
            EndContext();
            BeginContext(208, 33, false);
#line 6 "D:\20610\20486D\Allfiles\Mod05\Democode\05_ViewComponentsExample_begin\ViewComponentsExample\Views\Shared\Components\PersonCard\CardDesign.cshtml"
           Write(ViewBag.People[Model].PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(241, 12, true);
            WriteLiteral("</div>\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
