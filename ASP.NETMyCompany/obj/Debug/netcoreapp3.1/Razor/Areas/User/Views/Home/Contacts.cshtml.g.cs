#pragma checksum "C:\Users\user\source\repos\MyCompany1\ASP.NETMyCompany\Areas\User\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "383dd2dae60f6437c9fb8586718d3e748400fbf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Home_Contacts), @"mvc.1.0.view", @"/Areas/User/Views/Home/Contacts.cshtml")]
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
#line 2 "C:\Users\user\source\repos\MyCompany1\ASP.NETMyCompany\Areas\User\Views\_ViewImports.cshtml"
using MyCompany.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\MyCompany1\ASP.NETMyCompany\Areas\User\Views\_ViewImports.cshtml"
using MyCompany.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\MyCompany1\ASP.NETMyCompany\Areas\User\Views\_ViewImports.cshtml"
using MyCompany.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\MyCompany1\ASP.NETMyCompany\Areas\User\Views\_ViewImports.cshtml"
using MyCompany.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"383dd2dae60f6437c9fb8586718d3e748400fbf6", @"/Areas/User/Views/Home/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c98feb9e1a0657b22553d465a169b966cb06b16d", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Home_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextField>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\source\repos\MyCompany1\ASP.NETMyCompany\Areas\User\Views\Home\Contacts.cshtml"
  
    ViewBag.Title = Model.MetaTitle;
    ViewBag.Description = Model.MetaDescription;
    ViewBag.Keywords = Model.MetaKeywords;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    Контакты\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextField> Html { get; private set; }
    }
}
#pragma warning restore 1591
