#pragma checksum "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3498bb9c1af193d7a9ec935ba4067932b7841d89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HallManager_Index), @"mvc.1.0.view", @"/Views/HallManager/Index.cshtml")]
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
#line 1 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\_ViewImports.cshtml"
using RestaurantMVCUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\_ViewImports.cshtml"
using RestaurantMVCUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3498bb9c1af193d7a9ec935ba4067932b7841d89", @"/Views/HallManager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3d282d11171782d64e6461b1948706aa7dabf3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HallManager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RestaurantEntity.HallTable>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HallManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewBill", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#5A3B5D"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutHallManager.cshtml";


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3498bb9c1af193d7a9ec935ba4067932b7841d895238", async() => {
                WriteLiteral("\r\n    \r\n<div class=\"container\">\r\n\r\n        <center>\r\n            <h2 class=\"text-center\" style=\"color:#1e88e5\">Index of Hall Manager</h2>\r\n<div style=\"color:white\">\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3498bb9c1af193d7a9ec935ba4067932b7841d895688", async() => {
                    WriteLiteral(" Accept Paid Bill");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <hr />\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n            <div class=\" row\">\r\n");
#nullable restore
#line 32 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
             foreach(var item in Model)
            {
             

#line default
#line hidden
#nullable disable
                WriteLiteral("              <div class=\"col-3\">\r\n                  \r\n");
#nullable restore
#line 37 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
               if(item.HallTableStatus==true&&item.HallTableSize==4)
              {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <br />\r\n                        <div class=\"text-light\">Table Num:");
#nullable restore
#line 40 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                     Write(item.HallTableId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"text-light\">Occupancy:");
#nullable restore
#line 41 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                     Write(item.HallTableSize);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <img class=\"rounded\" src=\"https://www.svgrepo.com/show/105314/table.svg\" style=\"width:100px;height:100px;background-color:green\"/>\r\n");
#nullable restore
#line 43 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
              }
              else if (item.HallTableStatus == true && item.HallTableSize == 6)
              {

#line default
#line hidden
#nullable disable
                WriteLiteral("         <br />\r\n                        <div class=\"text-light\">Table Num:");
#nullable restore
#line 46 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                     Write(item.HallTableId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"text-light\">Occupancy:");
#nullable restore
#line 47 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                     Write(item.HallTableSize);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <img class=\"rounded\" src=\"https://www.svgrepo.com/show/26641/table.svg\" style=\"width:100px;height:100px;background-color:green\" />\r\n");
#nullable restore
#line 49 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"

              }
              else if (item.HallTableStatus == true && item.HallTableSize == 10)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                     <br />\r\n                        <div class=\"text-light\">Table Num:");
#nullable restore
#line 54 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                     Write(item.HallTableId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"text-light\">Occupancy:");
#nullable restore
#line 55 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                     Write(item.HallTableSize);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <img class=\"rounded\" src=\"https://www.svgrepo.com/show/206580/table-desk.svg\" style=\"width:100px;height:100px;background-color:green\" />\r\n");
#nullable restore
#line 57 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
              }

              else if (item.HallTableStatus == false && item.HallTableSize == 4)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <br />\r\n                            <div class=\"text-light\">Table Num:");
#nullable restore
#line 62 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                         Write(item.HallTableId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"text-light\">Occupancy:");
#nullable restore
#line 63 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                     Write(item.HallTableSize);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <img class=\"rounded\" src=\"https://www.svgrepo.com/show/105314/table.svg\" style=\"width:100px;height:100px;background-color:red\" />\r\n");
#nullable restore
#line 65 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"

              }

             else if (item.HallTableStatus == false && item.HallTableSize == 6)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <br />\r\n                        <div class=\"text-light\">Table Num:");
#nullable restore
#line 71 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                     Write(item.HallTableId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"text-light\">Occupancy:");
#nullable restore
#line 72 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                     Write(item.HallTableSize);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <img class=\"rounded\" src=\"https://www.svgrepo.com/show/26641/table.svg\" style=\"width:100px;height:100px;background-color:red\" />\r\n");
#nullable restore
#line 74 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"

             }
             else if (item.HallTableStatus == false && item.HallTableSize == 10)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <br />\r\n                        <div class=\"text-light\">Table Num:");
#nullable restore
#line 79 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                     Write(item.HallTableId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"text-light\">Occupancy:");
#nullable restore
#line 80 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
                                                     Write(item.HallTableSize);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <img class=\"rounded\" src=\"https://www.svgrepo.com/show/206580/table-desk.svg\" style=\"width:100px;height:100px;background-color:red\" />\r\n");
#nullable restore
#line 82 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"

             }

#line default
#line hidden
#nullable disable
                WriteLiteral("             </div>\r\n");
#nullable restore
#line 85 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\HallManager\Index.cshtml"
             
            

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                <br />\r\n            </div>\r\n   \r\n     </center>\r\n     </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RestaurantEntity.HallTable>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
