#pragma checksum "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "914991aefb4ef2da09455945898b39d9e544b385"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminLayout__adminLayout), @"mvc.1.0.view", @"/Views/AdminLayout/_adminLayout.cshtml")]
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
#line 1 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"914991aefb4ef2da09455945898b39d9e544b385", @"/Views/AdminLayout/_adminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6494dc9393571371fa83d6140b50adbfa061ea87", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminLayout__adminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
#nullable restore
#line 4 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLAyout/HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "914991aefb4ef2da09455945898b39d9e544b3853527", async() => {
                WriteLiteral("\n\n    ");
#nullable restore
#line 8 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLAyout/HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 10 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLAyout/SidebarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    <!--**********************************\n        Content body start\n    ***********************************-->\n    <div class=\"content-body\">\n\n        <div class=\"container-fluid mt-3\">\n\n            ");
#nullable restore
#line 19 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n        </div>\n        <!-- #/ container -->\n    </div>\n    <!--**********************************\n        Content body end\n    ***********************************-->\n\n\n    ");
#nullable restore
#line 29 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLAyout/FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 31 "C:\Users\SSA\source\repos\AspNetCoreApi\Frontend\HotelProject.WebUI\Views\AdminLayout\_adminLayout.cshtml"
Write(await Html.PartialAsync("/Views/AdminLAyout/ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n\n");
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
