// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FlightManagementBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\_Imports.razor"
using ValidationModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\Pages\AddFlightPassenger.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PassengerList/{FlightId}/AddPassenger")]
    public partial class AddFlightPassenger : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\josip\MyProject\AirportSystem-Josip_Dujmovic\FlightManagementBlazorServer\Pages\AddFlightPassenger.razor"
       
    public PassengerList PassengerList;
    [Parameter]
    public string FlightId { get; set; }
    public Passenger Passenger { get; set; }
    public NotificationDialog NotificationDialog{ get; set; }
    public List<ValidationError> ValidationErrors{ get; set; }
    public String ConcatenatedValidationErrors{ get; set; }
    protected override async Task OnInitializedAsync()
    {
        Passenger = new Passenger();
    }

    private async Task AddPassengerAsync()
    {
        ValidationErrors = ValidateFlight();
        if (ValidationErrors.Any())
        {
            ConcatenatedValidationErrors = GetConcatenatedValidationErrors(ValidationErrors);
            NotificationDialog.Show();
        }
        else
        {
            Passenger.FlightId = int.Parse(FlightId);
            await _passengerService.AddPassengerAsync(Passenger);
            Close();
        }
    }

    private void Close()
    {
        _navigationManager.NavigateTo($"/PassengerList/{FlightId}");
    }

    private List<ValidationError> ValidateFlight()
    {
        var validationErrors = new List<ValidationError>();
        if (String.IsNullOrWhiteSpace(Passenger.Name))
            validationErrors.Add(new ValidationError { Description = "Please insert Name!" });

        if (String.IsNullOrWhiteSpace(Passenger.LastName))
            validationErrors.Add(new ValidationError { Description = "Please insert Last Name!" });

        if (Passenger.Gender == null)
            validationErrors.Add(new ValidationError { Description = "Please select Gender!" });

        if ((Passenger.NumberLuggage > 0) && (Passenger.LuggageWeight == 0))
            validationErrors.Add(new ValidationError { Description = "Check luggage information!" });

        return validationErrors;

    }

    private string GetConcatenatedValidationErrors(List<ValidationError> ValidationErrors)
    {
        StringBuilder message = new StringBuilder();
        foreach(var error in ValidationErrors)
        {
            if (message.Length == 0)
                message.Append(error.Description);
            else
                message.Append($"{Environment.NewLine} {error.Description}");

        }
        return message.ToString();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PassengerService _passengerService { get; set; }
    }
}
#pragma warning restore 1591
