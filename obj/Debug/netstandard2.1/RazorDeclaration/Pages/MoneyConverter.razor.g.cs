#pragma checksum "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\MoneyConverter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "360f4e93209e9b7bf071883152ceca79af5345aa"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class MoneyConverter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\MoneyConverter.razor"
       
    public double monConverter  { get; set; }
    public double Money { get; set; }
    public double? Dolars = null;


    private void CalcForsa()
    {
        if(monConverter != 0)
        {
            Dolars = Money * monConverter;
        }
        else
        {
            Dolars = Money * 3.96;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
