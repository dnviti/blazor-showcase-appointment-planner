// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AppointmentPlanner.Pages.Doctors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using AppointmentPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using AppointmentPlanner.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Doctors\Doctors.razor"
using AppointmentPlanner.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Doctors\Doctors.razor"
using AppointmentPlanner.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/doctors")]
    public partial class Doctors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Doctors\Doctors.razor"
      

    [Inject]
    protected AppointmentService Service { get; set; }

    SfDialog DialogObj;
    SfDropDownList<string, Specialization> specObj { get; set; }
    private List<Doctor> filteredDoctors { get; set; }
    private SfMaskedTextBox maskObj { get; set; }

    private List<Specialization> specializationData { get; set; }
    private Doctor doctorEditModel = new Doctor();

    private bool isShowNewDialog { get; set; } = false;

    private string editHeader { get; set; } = "New Doctor";

    private List<TextIdData> experienceData { get; set; }

    private List<TextIdData> dutyTimings { get; set; }

    protected override void OnInitialized()
    {
        this.specializationData = Service.Specializations;
        this.experienceData = Service.Experience;
        this.dutyTimings = Service.DutyTimings;
        this.filteredDoctors = Service.Doctors;
    }

    private void onAddDoctor(Microsoft.AspNetCore.Components.Web.MouseEventArgs args)
    {
        doctorEditModel = new Doctor { Name = null, Gender = "Male", Mobile = null, Email = null, Education = null, Designation = null };
        this.isShowNewDialog = true;
    }

    private void dialogClosed(object args)
    {
        this.isShowNewDialog = false;
    }

    public async Task HandleValidSubmit(EditContext context)
    {
        Doctor initialData = Service.Doctors.FirstOrDefault();
        initialData = initialData != null ? initialData : new Doctor();
        Doctor getHours = updateWorkHours(initialData);
        string mobileNo = await this.maskObj.GetMaskedValue();
        var specialize = Service.Doctors.Where(i => i.DepartmentId == doctorEditModel.DepartmentId).FirstOrDefault().Specialization;
        Doctor newDoctor = new Doctor(doctorEditModel.Name, doctorEditModel.Gender, "default", filteredDoctors.LastOrDefault().Id + 1, doctorEditModel.DepartmentId, doctorEditModel.Color, doctorEditModel.Education, specialize, doctorEditModel.Experience, doctorEditModel.Designation, doctorEditModel.DutyTiming, doctorEditModel.Email, mobileNo, "available", getHours.StartHour, getHours.EndHour, initialData.AvailableDays, initialData.WorkDays);
        Service.Doctors.Add(newDoctor);

        if (specObj.Value != null)
        {
            filteredDoctors = Service.Doctors.Where(i => i.Specialization.Equals(specObj.Value)).ToList();
        }
        string message = $"Dr.{newDoctor.Name}, {newDoctor.Specialization.Substring(0, 1).ToUpper()} {newDoctor.Specialization.Substring(1)}";
        Service.Activities.Insert(0, new Activity { Name = "Added New Doctor", Message = message, Time = "4 mins ago", Type = "doctor", ActivityTime = DateTime.Now });
        await DialogObj.Hide();
    }

    private Doctor updateWorkHours(Doctor data)
    {
        string dutyString = dutyTimings.Where(item => item.Id.Equals(doctorEditModel.DutyTiming)).FirstOrDefault().Text;
        string startHour;
        string endHour;

        if (dutyString == "10:00 AM - 7:00 PM")
        {
            startHour = "10:00";
            endHour = "19:00";
        }
        else if (dutyString == "08:00 AM - 5:00 PM")
        {
            startHour = "08:00";
            endHour = "17:00";
        }
        else
        {
            startHour = "12:00";
            endHour = "21:00";
        }
        return new Doctor { StartHour = startHour, EndHour = endHour };
    }

    private void onSpecialistClick(Microsoft.AspNetCore.Components.Web.MouseEventArgs args, int Id)
    {
        UriHelper.NavigateTo("doctors/doctorsdetails/" + Id);
    }

    private int? selectedDepartmentId { get; set; }

    private void onSpecializationChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, Specialization> eventArgs)
    {
        List<Doctor> filteredData;
        if (eventArgs.Value != null)
        {
            this.selectedDepartmentId = eventArgs.ItemData.DepartmentId;
            filteredData = Service.Doctors.Where(i => i.Specialization.Equals(eventArgs.ItemData.Id)).ToList();
        }
        else
        {
            this.selectedDepartmentId = null;
            filteredData = Service.Doctors;
        }
        filteredDoctors = filteredData;
    }
    private async Task onCancelClick(Microsoft.AspNetCore.Components.Web.MouseEventArgs args)
    {
        await this.DialogObj.Hide();
        this.isShowNewDialog = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
