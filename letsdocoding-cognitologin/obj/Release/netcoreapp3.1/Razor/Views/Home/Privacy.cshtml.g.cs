#pragma checksum "E:\ICT\Sem 8\IBM Project\Authentication and Authorization\Group 03 Project\letsdocoding-cognitologin\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ef11de5c90e547d4257df8df0ad25723d38a850"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "E:\ICT\Sem 8\IBM Project\Authentication and Authorization\Group 03 Project\letsdocoding-cognitologin\Views\_ViewImports.cshtml"
using group03_cognitologin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ICT\Sem 8\IBM Project\Authentication and Authorization\Group 03 Project\letsdocoding-cognitologin\Views\_ViewImports.cshtml"
using group03_cognitologin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\ICT\Sem 8\IBM Project\Authentication and Authorization\Group 03 Project\letsdocoding-cognitologin\Views\Home\Privacy.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ICT\Sem 8\IBM Project\Authentication and Authorization\Group 03 Project\letsdocoding-cognitologin\Views\Home\Privacy.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ef11de5c90e547d4257df8df0ad25723d38a850", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e93debd4b04fa813c9957abc7c34d92a539fe59", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\ICT\Sem 8\IBM Project\Authentication and Authorization\Group 03 Project\letsdocoding-cognitologin\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "User Tokens";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "E:\ICT\Sem 8\IBM Project\Authentication and Authorization\Group 03 Project\letsdocoding-cognitologin\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<h2>Access Token</h2>\n\n<textarea rows=\"3\" cols=\"50\">");
#nullable restore
#line 11 "E:\ICT\Sem 8\IBM Project\Authentication and Authorization\Group 03 Project\letsdocoding-cognitologin\Views\Home\Privacy.cshtml"
                        Write(HttpContextAccessor.HttpContext.GetTokenAsync("access_token").GetAwaiter().GetResult());

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\n\n\n<hr />\n<h2>Id Token</h2>\n\n<textarea rows=\"3\" cols=\"50\">");
#nullable restore
#line 17 "E:\ICT\Sem 8\IBM Project\Authentication and Authorization\Group 03 Project\letsdocoding-cognitologin\Views\Home\Privacy.cshtml"
                        Write(HttpContextAccessor.HttpContext.GetTokenAsync("id_token").GetAwaiter().GetResult());

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
