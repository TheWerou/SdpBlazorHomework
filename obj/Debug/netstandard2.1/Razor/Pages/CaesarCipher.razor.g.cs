#pragma checksum "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\CaesarCipher.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fbfea6fe20d1102789fba129a8822f1387e0648"
// <auto-generated/>
#pragma warning disable 1591
namespace CodeInterpreter.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\_Imports.razor"
using CodeInterpreter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\_Imports.razor"
using CodeInterpreter.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\_Imports.razor"
using CodeInterpreter.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CezarCipher")]
    public partial class CaesarCipher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3> CezarCipher </h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", " col-md-4");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label> Text to encript </label>\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "placeholder", "StringToCode");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\CaesarCipher.razor"
                                                                                      input

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => input = __value, input));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, "<label> Key </label>\r\n            ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "number");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "placeholder", "Key");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\CaesarCipher.razor"
                                                                               keycode

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => keycode = __value, keycode, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-primary mt-1");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\CaesarCipher.razor"
                                                           Code

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, " Encript ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-primary mt-1");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\CaesarCipher.razor"
                                                           DeCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, " Decript ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 23 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\CaesarCipher.razor"
     if (output != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row blockquote mt-5");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "span");
            __builder.AddContent(51, "Your encripted message is ");
            __builder.AddContent(52, 
#nullable restore
#line 26 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\CaesarCipher.razor"
                                             output

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            \r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 30 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\CaesarCipher.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\CaesarCipher.razor"
       

    public string input { get; set;  }
    public string? output { get; set; } = null;
    public int keycode { get; set; } = 1;

    private void Code()
    {

        output = Encipher(input, keycode);

    }

    private void DeCode()
    {

        output = Decipher(input, keycode);

    }

    private static char cipher(char ch, int key)
    {
        if (!char.IsLetter(ch))
        {

            return ch;
        }

        char d = char.IsUpper(ch) ? 'A' : 'a';
        return (char)((((ch + key) - d) % 26) + d);


    }


    private string Encipher(string input, int key)
    {
        string output = string.Empty;

        foreach (char ch in input)
            output += cipher(ch, key);

        return output;
    }

    private string Decipher(string input, int key)
    {
        return Encipher(input, 26 - key);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
