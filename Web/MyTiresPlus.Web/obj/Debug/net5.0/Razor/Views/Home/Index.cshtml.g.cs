#pragma checksum "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6ede263daece086dae634d5598f903e21c32fc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\_ViewImports.cshtml"
using MyTiresPlus.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\_ViewImports.cshtml"
using MyTiresPlus.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
using MyTiresPlus.Web.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
using MyTiresPlus.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6ede263daece086dae634d5598f903e21c32fc5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179958711e8edeb23dcd33b41925a9c819e1ff6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
  
    this.ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n \r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 25 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
     for (int i = 0; i < 10; i++)
    {
        if (i % 2 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("GG\r\n");
#nullable restore
#line 30 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"

        }
        //Comment
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
            WriteLiteral("@</p>\r\n    <p>Time");
#nullable restore
#line 35 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
       Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Time@abv.bg</p>\r\n    <p>");
#nullable restore
#line 37 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
   Write(Model.Year / 4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <!-- HTML   Comment -->\r\n");
#nullable restore
#line 39 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"display-4\">Welcome to ");
#nullable restore
#line 41 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
                                    Write(GlobalConstants.SystemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n");
#nullable restore
#line 42 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2 class=\"display-4\">Welcome, ");
#nullable restore
#line 45 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n");
#nullable restore
#line 46 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h3>It ");
#nullable restore
#line 48 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
      Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" year.</h3>\r\n    <p>We hawe ");
#nullable restore
#line 49 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
          Write(Model.UserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" users</p>\r\n    <p>ProcesorCount: ");
#nullable restore
#line 50 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
                 Write(Model.ProcesorCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Time: ");
#nullable restore
#line 51 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
        Write(Model.DataTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Id: ");
#nullable restore
#line 52 "C:\Users\Svetoslav\Desktop\Template\Web\MyTiresPlus.Web\Views\Home\Index.cshtml"
      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
