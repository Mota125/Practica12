#pragma checksum "C:\Users\JOVANY MOTA\Desktop\Practica12\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f29ecf3cde0929f0e9e89f8525f401216c3e23f4"
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
#line 1 "C:\Users\JOVANY MOTA\Desktop\Practica12\Views\_ViewImports.cshtml"
using Practica12;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JOVANY MOTA\Desktop\Practica12\Views\_ViewImports.cshtml"
using Practica12.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f29ecf3cde0929f0e9e89f8525f401216c3e23f4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4948c6b938314c4750a9e67dd66f7f7bb175d3ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\JOVANY MOTA\Desktop\Practica12\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Calculadora</h1>\r\n");
#nullable restore
#line 7 "C:\Users\JOVANY MOTA\Desktop\Practica12\Views\Home\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table>
            <tr>
                <th> Numero 1: </th>
            <td> <input type=""text"" id=""txtNumuero1"" name=""numero1"" class=""form-control"" /></td>
            </tr>
            <tr>
                <th> Numero 2: </th>
            <td> <input type=""text"" id=""txtNumuero2"" name=""numero2"" class=""form-control"" /></td>
            </tr>
         
            <tr>
                <th ><input type=""submit"" name=""tipo"" value=""Suma"" class=""btn btn-primary""/></th>
                <th><input type=""submit"" name=""tipo"" value=""Resta"" class=""btn btn-primary"" /></th> 
            </tr>
            
            <tr> 
                <th><input type=""submit"" name=""tipo"" value=""Multiplicacion"" class=""btn btn-primary""/></th>
                <th><input type=""submit"" name=""tipo"" value=""Division"" class=""btn btn-primary""/></th>
            </tr>
            <tr>
                <th>Resultado</th>
                <td><input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1142, "\"", 1168, 1);
#nullable restore
#line 30 "C:\Users\JOVANY MOTA\Desktop\Practica12\Views\Home\Index.cshtml"
WriteAttributeValue("", 1150, ViewBag.Resultado, 1150, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> </td>\r\n            </tr>\r\n            \r\n        </table>\r\n");
#nullable restore
#line 34 "C:\Users\JOVANY MOTA\Desktop\Practica12\Views\Home\Index.cshtml"
    
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
