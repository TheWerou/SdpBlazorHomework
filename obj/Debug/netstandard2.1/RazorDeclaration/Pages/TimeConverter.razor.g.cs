#pragma checksum "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\TimeConverter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c69d02f735358c0b268eb6371eae9fe20ea0f16a"
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
    public partial class TimeConverter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\wojte\OneDrive\Pulpit\Programowanie\c_hasz\SDP\Blazor\CodeInterpreter\Pages\TimeConverter.razor"
       
    int? _seconds = null;
    public int? Hours { get; set; }

    private void ConvertTime()
    {
        _seconds = Hours * 3600;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
