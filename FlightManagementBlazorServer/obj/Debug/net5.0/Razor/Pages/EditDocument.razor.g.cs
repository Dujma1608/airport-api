#pragma checksum "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d98ade02b44148237fc5e38ab6690c8ba46e58a"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightManagementBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\_Imports.razor"
using ValidationModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PassengerList/{FlightId}/{PassengerId}/EditDocument")]
    public partial class EditDocument : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Document</h3>");
#nullable restore
#line 7 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
 if(Document == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Loading...</p>");
#nullable restore
#line 10 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
                  Document

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
                                            UpdateDocument

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row g-3");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-auto");
                __builder2.AddMarkupContent(10, "<label for=\"documentName\">First and Last name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "documentName");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
                                                       Document.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Document.Name = __value, Document.Name))));
                __builder2.AddAttribute(16, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Document.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n\r\n            ");
                __builder2.AddMarkupContent(18, "<label for=\"documentType\">Type of document</label>\r\n            ");
                __builder2.OpenElement(19, "select");
                __builder2.AddAttribute(20, "id", "documentType");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
                                              Document.documentType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Document.documentType = __value, Document.documentType));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(24, "option");
                __builder2.AddAttribute(25, "value");
                __builder2.AddContent(26, "Select Document...");
                __builder2.CloseElement();
#nullable restore
#line 22 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
               foreach(var types in Types)
              {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(27, "option");
                __builder2.AddAttribute(28, "value", 
#nullable restore
#line 24 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
                              types

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 24 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
__builder2.AddContent(29, types);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 25 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
              }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n            ");
                __builder2.AddMarkupContent(31, "<label for=\"documentNumber\">Document Number</label>\r\n            ");
                __Blazor.FlightManagementBlazorServer.Pages.EditDocument.TypeInference.CreateInputNumber_0(__builder2, 32, 33, "documentNumber", 34, "form-control", 35, 
#nullable restore
#line 29 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
                                                           Document.documentNumber

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Document.documentNumber = __value, Document.documentNumber)), 37, () => Document.documentNumber);
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.AddMarkupContent(39, "<label for=\"expirationDate\">Expirration Date</label>\r\n            ");
                __Blazor.FlightManagementBlazorServer.Pages.EditDocument.TypeInference.CreateInputDate_1(__builder2, 40, 41, "expirationDate", 42, "form-control", 43, 
#nullable restore
#line 31 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
                                                         Document.ExpireDate

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Document.ExpireDate = __value, Document.ExpireDate)), 45, () => Document.ExpireDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(47, "<button type=\"submit\" class=\"btn btn-success\"><span class=\"oi oi-pencil\"></span>\r\n        Update\r\n    </button>\r\n    ");
                __builder2.OpenElement(48, "button");
                __builder2.AddAttribute(49, "type", "button");
                __builder2.AddAttribute(50, "class", "btn btn-outline-success");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
                                                                    () => Close() 

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(52, "Close");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 41 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\josip\OneDrive\Radna površina\AirportSystem-Josip Dujmović\FlightManagementBlazorServer\Pages\EditDocument.razor"
       
    [Parameter]
    public string FlightId { get; set; }
    [Parameter]
    public string PassengerId{ get; set; }
    List<string> Types = new List<string>() { "Passport", "ID Card" };
    public Document Document { get; set; }
    public NotificationDialog NotificationDialog{ get; set; }
    public List<ValidationError> ValidationErrors{ get; set; }
    public String ConcatenatedValidationErrors{ get; set; }
    protected override async Task OnInitializedAsync()
    {
       Document = await _documentService.GetDocumentAsync(int.Parse(PassengerId));
    }
    private async Task UpdateDocument()
    {
        await _documentService.UpdateDocument(Document);
        Close();
    }
    private void Close()
    {
        _navigationManager.NavigateTo($"/PassengerList/{FlightId}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DocumentService _documentService { get; set; }
    }
}
namespace __Blazor.FlightManagementBlazorServer.Pages.EditDocument
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
