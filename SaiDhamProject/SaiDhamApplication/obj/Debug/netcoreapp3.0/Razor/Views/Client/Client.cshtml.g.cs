#pragma checksum "E:\Core\DotNetCore3.0\SaiDhamProject\SaiDhamApplication\Views\Client\Client.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b5d10ba0f1eb05a693b08548cc79877e0de9bb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Client), @"mvc.1.0.view", @"/Views/Client/Client.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b5d10ba0f1eb05a693b08548cc79877e0de9bb9", @"/Views/Client/Client.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Client : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600' rel='stylesheet' type='text/css'>
<link href=""/css/application/Client/font-awesome.css"" rel=""stylesheet"">

<div class=""testbox"">
    <h1>Client</h1>
    <form action=""/"">
        <hr>
        <div class=""accounttype"">
            <input type=""radio"" value=""None"" id=""radioOne"" name=""account"" checked />
            <label for=""radioOne"" class=""radio"" chec>Internal</label>
            <input type=""radio"" value=""None"" id=""radioTwo"" name=""account"" />
            <label for=""radioTwo"" class=""radio"">External</label>
        </div>
        <hr>
        <label id=""icon"" for=""name""><i class=""icon-envelope ""></i></label>
        <input type=""text"" name=""name"" id=""name"" placeholder=""Email"" required />
        <label id=""icon"" for=""name""><i class=""icon-user""></i></label>
        <input type=""text"" name=""name"" id=""name"" placeholder=""Name"" required />
        <label id=""icon"" for=""name""><i class=""icon-shield""></i");
            WriteLiteral(@"></label>
        <input type=""password"" name=""name"" id=""name"" placeholder=""Password"" required />
        <div class=""gender"">
            <input type=""radio"" value=""None"" id=""male"" name=""gender"" checked />
            <label for=""male"" class=""radio"" chec>Male</label>
            <input type=""radio"" value=""None"" id=""female"" name=""gender"" />
            <label for=""female"" class=""radio"">Female</label>
        </div>
        <p>By clicking Register, you agree on our <a href=""#"">terms and condition</a>.</p>
        <a href=""#"" class=""button"">Register</a>
    </form>
</div>");
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
