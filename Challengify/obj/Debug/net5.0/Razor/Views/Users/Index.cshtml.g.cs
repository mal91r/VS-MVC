#pragma checksum "/Users/davidnatroshvili/Desktop/VS-MVC/Challengify/Views/Users/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52d8ab22e0086c1187dcac4c73f8dd4ef1ebbd7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "/Users/davidnatroshvili/Desktop/VS-MVC/Challengify/Views/_ViewImports.cshtml"
using Challengify;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/davidnatroshvili/Desktop/VS-MVC/Challengify/Views/_ViewImports.cshtml"
using Challengify.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d8ab22e0086c1187dcac4c73f8dd4ef1ebbd7e", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1869ba22ca56d8969061aa084a90749011132708", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/davidnatroshvili/Desktop/VS-MVC/Challengify/Views/Users/Index.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"display-4\">Список пользователей</h1>\n\n");
#nullable restore
#line 8 "/Users/davidnatroshvili/Desktop/VS-MVC/Challengify/Views/Users/Index.cshtml"
 foreach (var user in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\n        <div class=\"card-body\">\n            <h5 class=\"card-title\">");
#nullable restore
#line 12 "/Users/davidnatroshvili/Desktop/VS-MVC/Challengify/Views/Users/Index.cshtml"
                              Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <h5 class=\"card-title\">");
#nullable restore
#line 13 "/Users/davidnatroshvili/Desktop/VS-MVC/Challengify/Views/Users/Index.cshtml"
                              Write(user.XP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        </div>\n        <div class=\"card-footer\">\n            <h5 class=\"card-title\">");
#nullable restore
#line 16 "/Users/davidnatroshvili/Desktop/VS-MVC/Challengify/Views/Users/Index.cshtml"
                              Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <small class=\"text-muted\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 461, "\"", 490, 3);
            WriteAttributeValue("", 468, "/users/", 468, 7, true);
#nullable restore
#line 18 "/Users/davidnatroshvili/Desktop/VS-MVC/Challengify/Views/Users/Index.cshtml"
WriteAttributeValue("", 475, user.UserName, 475, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 489, "/", 489, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Перейти в профиль</a>\n            </small>\n        </div>\n    </div>\n");
#nullable restore
#line 22 "/Users/davidnatroshvili/Desktop/VS-MVC/Challengify/Views/Users/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
