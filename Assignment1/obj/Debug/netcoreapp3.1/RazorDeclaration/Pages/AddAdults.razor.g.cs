#pragma checksum "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\Pages\AddAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6f4cd9225c972fe36cdac956c0716be04a90b22"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\Pages\AddAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\Pages\AddAdults.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\Pages\AddAdults.razor"
           [Authorize(Policy = "MustBeVIA")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addadults")]
    public partial class AddAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\Sonny\Dropbox\DNP\Assignment1\Assignment1\Pages\AddAdults.razor"
       
    private string[] hairColors = {"Blond", "Red", "Brown", "Black", "White", "Grey", "Blue", "Green", "Leverpostej"};
    private string[] eyeColors = {"Black", "Brown", "Grey", "Green", "Blue", "Amber", "Hazel"};

    private Adult person = new Adult();
    
    
    private void SaveAdultToFile() {
        FileContext fileContext = new FileContext();
        IList<Adult> adults = fileContext.Adults;
        
        adults.Add(person);
        
        fileContext.SaveChanges();

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
