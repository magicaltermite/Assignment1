#pragma checksum "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5980a6e80ebae2db44433d704090030e9ca27cf8"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
           [Authorize(Policy = "AddAdults")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addadults")]
    public partial class AddAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>  Adult Adder</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>To create an adult, please fill out the information: </p>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                  adultItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                                             SaveAdultToFile

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "\r\n        First Name: <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                                adultItem.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.FirstName = __value, adultItem.FirstName))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultItem.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    \r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "\r\n        Last Name: <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                                adultItem.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.LastName = __value, adultItem.LastName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultItem.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    \r\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "\r\n        Hair Colour: <br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdults.TypeInference.CreateInputSelect_0(__builder2, 32, 33, 
#nullable restore
#line 30 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                                  adultItem.HairColor

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.HairColor = __value, adultItem.HairColor)), 35, () => adultItem.HairColor, 36, (__builder3) => {
                    __builder3.AddMarkupContent(37, "\r\n");
#nullable restore
#line 31 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
             foreach (var color in hairColors) {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(38, "                ");
                    __builder3.OpenElement(39, "option");
                    __builder3.AddContent(40, 
#nullable restore
#line 32 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                         color

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\r\n");
#nullable restore
#line 33 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(42, "        ");
                }
                );
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    \r\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "\r\n        Eye Colour: <br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdults.TypeInference.CreateInputSelect_1(__builder2, 48, 49, 
#nullable restore
#line 39 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                                  adultItem.EyeColor

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.EyeColor = __value, adultItem.EyeColor)), 51, () => adultItem.EyeColor, 52, (__builder3) => {
                    __builder3.AddMarkupContent(53, "\r\n");
#nullable restore
#line 40 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
             foreach (var color in eyeColors) {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(54, "                ");
                    __builder3.OpenElement(55, "option");
                    __builder3.AddContent(56, 
#nullable restore
#line 41 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                         color

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\r\n");
#nullable restore
#line 42 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(58, "        ");
                }
                );
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n    \r\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "\r\n        Age: <br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdults.TypeInference.CreateInputNumber_2(__builder2, 64, 65, 
#nullable restore
#line 48 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                                  adultItem.Age

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.Age = __value, adultItem.Age)), 67, () => adultItem.Age);
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n    \r\n    ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "\r\n        Weight: <br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdults.TypeInference.CreateInputNumber_3(__builder2, 73, 74, 
#nullable restore
#line 53 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                                  adultItem.Weight

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.Weight = __value, adultItem.Weight)), 76, () => adultItem.Weight);
                __builder2.AddMarkupContent(77, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n    \r\n    ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group");
                __builder2.AddMarkupContent(81, "\r\n        Height: <br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdults.TypeInference.CreateInputNumber_4(__builder2, 82, 83, 
#nullable restore
#line 58 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                                  adultItem.Height

#line default
#line hidden
#nullable disable
                , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.Height = __value, adultItem.Height)), 85, () => adultItem.Height);
                __builder2.AddMarkupContent(86, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n    \r\n    ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group");
                __builder2.AddMarkupContent(90, "\r\n        Sex: <br>\r\n        ");
                __Blazor.Assignment1.Pages.AddAdults.TypeInference.CreateInputSelect_5(__builder2, 91, 92, 
#nullable restore
#line 63 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                                  adultItem.Sex

#line default
#line hidden
#nullable disable
                , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.Sex = __value, adultItem.Sex)), 94, () => adultItem.Sex, 95, (__builder3) => {
                    __builder3.AddMarkupContent(96, "\r\n            <option></option>\r\n            ");
                    __builder3.AddMarkupContent(97, "<option>Male</option>\r\n            ");
                    __builder3.AddMarkupContent(98, "<option>Female</option>\r\n            ");
                    __builder3.AddMarkupContent(99, "<option>Other</option>\r\n        ");
                }
                );
                __builder2.AddMarkupContent(100, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n    \r\n    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-group");
                __builder2.AddMarkupContent(104, "\r\n        Job: <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(105);
                __builder2.AddAttribute(106, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
                                adultItem.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(107, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.JobTitle = __value, adultItem.JobTitle))));
                __builder2.AddAttribute(108, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultItem.JobTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n\r\n    ");
                __builder2.AddMarkupContent(111, "<p class=\"action\">\r\n        <button class=\"btn btn-primary\" type=\"submit\">Add Adult</button>\r\n    </p>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "D:\VIA\3 Semester\DNP1\Assignment1\Assignment1\Pages\AddAdults.razor"
       
    private string[] hairColors = {"", "Blond", "Red", "Brown", "Black", "White", "Grey", "Blue", "Green", "Leverpostej"};
    private string[] eyeColors = {"", "Black", "Brown", "Grey", "Green", "Blue", "Amber", "Hazel"};

    private Adult adultItem = new Adult();
    
    
    private void SaveAdultToFile() {
        try {
            AdultService.AddAdultAsync(adultItem);
        }
        catch (NullReferenceException e) {
            Console.WriteLine(e);
            throw;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
namespace __Blazor.Assignment1.Pages.AddAdults
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
