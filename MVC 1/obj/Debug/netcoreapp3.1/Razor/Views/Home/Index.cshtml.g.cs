#pragma checksum "A:\Study\ASP.NET Core MVC\Study c#\ASP.NET Core практика\Students\MVC 1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f765b506cdbcf6c473f43ca91572925c96cc20a3"
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
#line 1 "A:\Study\ASP.NET Core MVC\Study c#\ASP.NET Core практика\Students\MVC 1\Views\_ViewImports.cshtml"
using MVC_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\Study\ASP.NET Core MVC\Study c#\ASP.NET Core практика\Students\MVC 1\Views\_ViewImports.cshtml"
using MVC_1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "A:\Study\ASP.NET Core MVC\Study c#\ASP.NET Core практика\Students\MVC 1\Views\_ViewImports.cshtml"
using MVC_1.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "A:\Study\ASP.NET Core MVC\Study c#\ASP.NET Core практика\Students\MVC 1\Views\_ViewImports.cshtml"
using MVC_1.Models.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "A:\Study\ASP.NET Core MVC\Study c#\ASP.NET Core практика\Students\MVC 1\Views\_ViewImports.cshtml"
using MVC_1.Models.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "A:\Study\ASP.NET Core MVC\Study c#\ASP.NET Core практика\Students\MVC 1\Views\_ViewImports.cshtml"
using MVC_1.Models.Abstract.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "A:\Study\ASP.NET Core MVC\Study c#\ASP.NET Core практика\Students\MVC 1\Views\_ViewImports.cshtml"
using MVC_1.Models.Deadline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "A:\Study\ASP.NET Core MVC\Study c#\ASP.NET Core практика\Students\MVC 1\Views\_ViewImports.cshtml"
using MVC_1.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "A:\Study\ASP.NET Core MVC\Study c#\ASP.NET Core практика\Students\MVC 1\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f765b506cdbcf6c473f43ca91572925c96cc20a3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a28a449801f1e23f14846430c1570f5bba223ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "A:\Study\ASP.NET Core MVC\Study c#\ASP.NET Core практика\Students\MVC 1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("forHeader", async() => {
                WriteLiteral("\r\n    <p>Home</p>\r\n");
            }
            );
            WriteLiteral(@"
<p>Быстрые клавиши:</p>

<ul type=""circle"">
    <li>Главная: ALT+0</li>
    <li>Расписание: ALT+1</li>
    <li>Дедлайны: ALT+2</li>
    <li>Оценки: ALT+3</li>
    <li>Студенты: ALT+4</li>
    <li>Рейтинг: ALT+5</li>
    <li>Новости: ALT+6</li>
</ul>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
