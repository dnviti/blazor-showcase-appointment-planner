#pragma checksum "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f166fe5a43ece14db1efbc62157db5b977b3c408"
// <auto-generated/>
#pragma warning disable 1591
namespace AppointmentPlanner.Pages.Preference
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
#line 3 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
using AppointmentPlanner.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
using AppointmentPlanner.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/preference")]
    public partial class Preference : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "preference");
            __builder.AddAttribute(2, "class", "preference-container");
            __builder.AddMarkupContent(3, "<header><div class=\"module-title\"><div class=\"title\">PREFERENCE</div>\r\n            <div class=\"underline\"></div></div></header>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "control-container");
            __builder.AddMarkupContent(6, "<div class=\"label-text\">Default View</div>\r\n        ");
            __Blazor.AppointmentPlanner.Pages.Preference.Preference.TypeInference.CreateSfDropDownList_0(__builder, 7, 8, "preference-drop-down", 9, "CurrentView", 10, "335px", 11, 
#nullable restore
#line 15 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                                                                views

#line default
#line hidden
#nullable disable
            , 12, 
#nullable restore
#line 15 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                       selectedView

#line default
#line hidden
#nullable disable
            , 13, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedView = __value, selectedView)), 14, () => selectedView, 15, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string, TextValueData>>(16);
                __builder2.AddAttribute(17, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData>>(this, 
#nullable restore
#line 16 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                   onViewChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(19);
                __builder2.AddAttribute(20, "Text", "Text");
                __builder2.AddAttribute(21, "Value", "Value");
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "control-container");
            __builder.AddMarkupContent(25, "<div class=\"label-text\">Calendar Start Time</div>\r\n        ");
            __Blazor.AppointmentPlanner.Pages.Preference.Preference.TypeInference.CreateSfDropDownList_1(__builder, 26, 27, "preference-drop-down", 28, "CalendarStart", 29, "335px", 30, 
#nullable restore
#line 22 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                                                                       startHours

#line default
#line hidden
#nullable disable
            , 31, 
#nullable restore
#line 22 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                         selectedStartHour

#line default
#line hidden
#nullable disable
            , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedStartHour = __value, selectedStartHour)), 33, () => selectedStartHour, 34, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string, TextValueData>>(35);
                __builder2.AddAttribute(36, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData>>(this, 
#nullable restore
#line 23 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                   onStartHourChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(38);
                __builder2.AddAttribute(39, "Text", "Text");
                __builder2.AddAttribute(40, "Value", "Value");
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "control-container");
            __builder.AddMarkupContent(44, "<div class=\"label-text\">Calendar End Time</div>\r\n        ");
            __Blazor.AppointmentPlanner.Pages.Preference.Preference.TypeInference.CreateSfDropDownList_2(__builder, 45, 46, "preference-drop-down", 47, "CalendarEnd", 48, "335px", 49, 
#nullable restore
#line 29 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                                                                   endHours

#line default
#line hidden
#nullable disable
            , 50, 
#nullable restore
#line 29 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                       selectedEndHour

#line default
#line hidden
#nullable disable
            , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedEndHour = __value, selectedEndHour)), 52, () => selectedEndHour, 53, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string, TextValueData>>(54);
                __builder2.AddAttribute(55, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData>>(this, 
#nullable restore
#line 30 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                   onEndhourChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(57);
                __builder2.AddAttribute(58, "Text", "Text");
                __builder2.AddAttribute(59, "Value", "Value");
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "control-container");
            __builder.AddMarkupContent(63, "<div class=\"label-text\">Slot Duration</div>\r\n        ");
            __Blazor.AppointmentPlanner.Pages.Preference.Preference.TypeInference.CreateSfDropDownList_3(__builder, 64, 65, "preference-drop-down", 66, "Duration", 67, "335px", 68, 
#nullable restore
#line 36 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                                                             timeSlots

#line default
#line hidden
#nullable disable
            , 69, 
#nullable restore
#line 36 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                    timeInterval

#line default
#line hidden
#nullable disable
            , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => timeInterval = __value, timeInterval)), 71, () => timeInterval, 72, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<int?, TextValueNumericData>>(73);
                __builder2.AddAttribute(74, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<int?, TextValueNumericData>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<int?, TextValueNumericData>>(this, 
#nullable restore
#line 37 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                        onDurationChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(76);
                __builder2.AddAttribute(77, "Text", "Text");
                __builder2.AddAttribute(78, "Value", "Value");
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "control-container");
            __builder.AddMarkupContent(82, "<div class=\"label-text\">Booking Color</div>\r\n        ");
            __Blazor.AppointmentPlanner.Pages.Preference.Preference.TypeInference.CreateSfDropDownList_4(__builder, 83, 84, "preference-drop-down", 85, "BookingColor", 86, "335px", 87, 
#nullable restore
#line 43 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                                                                     colorCategory

#line default
#line hidden
#nullable disable
            , 88, 
#nullable restore
#line 43 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                        selectedCategory

#line default
#line hidden
#nullable disable
            , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedCategory = __value, selectedCategory)), 90, () => selectedCategory, 91, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string, TextValueData>>(92);
                __builder2.AddAttribute(93, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData>>(this, 
#nullable restore
#line 44 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                   onColorChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(95);
                __builder2.AddAttribute(96, "Text", "Text");
                __builder2.AddAttribute(97, "Value", "Value");
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "control-container");
            __builder.AddMarkupContent(101, "<div class=\"label-text\">First Day of the Week</div>\r\n        ");
            __Blazor.AppointmentPlanner.Pages.Preference.Preference.TypeInference.CreateSfDropDownList_5(__builder, 102, 103, "preference-drop-down", 104, "FirstDayOfWeek", 105, "335px", 106, 
#nullable restore
#line 50 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                                                                        dayOfWeeks

#line default
#line hidden
#nullable disable
            , 107, 
#nullable restore
#line 50 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                          selectedDayOfWeek

#line default
#line hidden
#nullable disable
            , 108, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedDayOfWeek = __value, selectedDayOfWeek)), 109, () => selectedDayOfWeek, 110, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<int?, TextValueNumericData>>(111);
                __builder2.AddAttribute(112, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<int?, TextValueNumericData>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<int?, TextValueNumericData>>(this, 
#nullable restore
#line 51 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
                                                                                        onFirstDayChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(113, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(114);
                __builder2.AddAttribute(115, "Text", "Text");
                __builder2.AddAttribute(116, "Value", "Value");
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Pages\Preference\Preference.razor"
      
    [Inject]
    protected AppointmentService Service { get; set; }
    private List<TextValueData> views { get; set; }
    private List<TextValueData> startHours { get; set; }
    private List<TextValueData> endHours { get; set; }
    private List<TextValueNumericData> timeSlots { get; set; }
    private List<TextValueData> colorCategory { get; set; }
    private List<TextValueNumericData> dayOfWeeks { get; set; }
    private string selectedView { get; set; }
    private string selectedStartHour { get; set; }
    private string selectedEndHour { get; set; }
    private string selectedCategory { get; set; }
    private int? timeInterval { get; set; }
    private int? selectedDayOfWeek { get; set; }

    protected override void OnInitialized()
    {
        this.views = Service.Views;
        this.startHours = Service.StartHours;
        this.endHours = Service.EndHours;
        this.timeSlots = Service.TimeSlot;
        this.colorCategory = Service.ColorCategory;
        this.dayOfWeeks = Service.DayOfWeekList;
        this.selectedView = Service.CalendarSettings.CurrentView;
        this.selectedStartHour = Service.CalendarSettings.Calendar.Start;
        this.selectedEndHour = Service.CalendarSettings.Calendar.End;
        this.selectedCategory = Service.CalendarSettings.BookingColor;
        this.timeInterval = Service.CalendarSettings.Interval;
        this.selectedDayOfWeek = Service.CalendarSettings.FirstDayOfWeek;
    }

    private void onViewChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData> args)
    {
        Service.CalendarSettings.CurrentView = args.Value;
    }
    private void onStartHourChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData> args)
    {
        Service.CalendarSettings.Calendar.Start = args.Value;
    }
    private void onEndhourChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData> args)
    {
        Service.CalendarSettings.Calendar.End = args.Value;
    }
    private void onColorChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TextValueData> args)
    {
        Service.CalendarSettings.BookingColor = (string)args.Value;
    }
    private void onDurationChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<int?, TextValueNumericData> args)
    {
        Service.CalendarSettings.Interval = (int)args.Value;
    }
    private void onFirstDayChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<int?, TextValueNumericData> args)
    {
        Service.CalendarSettings.FirstDayOfWeek = (int)args.Value;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.AppointmentPlanner.Pages.Preference.Preference
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfDropDownList_0<TValue, TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Collections.Generic.IEnumerable<TItem> __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.DropDowns.SfDropDownList<TValue, TItem>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "ID", __arg1);
        __builder.AddAttribute(__seq2, "Width", __arg2);
        __builder.AddAttribute(__seq3, "DataSource", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateSfDropDownList_1<TValue, TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Collections.Generic.IEnumerable<TItem> __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.DropDowns.SfDropDownList<TValue, TItem>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "ID", __arg1);
        __builder.AddAttribute(__seq2, "Width", __arg2);
        __builder.AddAttribute(__seq3, "DataSource", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateSfDropDownList_2<TValue, TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Collections.Generic.IEnumerable<TItem> __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.DropDowns.SfDropDownList<TValue, TItem>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "ID", __arg1);
        __builder.AddAttribute(__seq2, "Width", __arg2);
        __builder.AddAttribute(__seq3, "DataSource", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateSfDropDownList_3<TValue, TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Collections.Generic.IEnumerable<TItem> __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.DropDowns.SfDropDownList<TValue, TItem>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "ID", __arg1);
        __builder.AddAttribute(__seq2, "Width", __arg2);
        __builder.AddAttribute(__seq3, "DataSource", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateSfDropDownList_4<TValue, TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Collections.Generic.IEnumerable<TItem> __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.DropDowns.SfDropDownList<TValue, TItem>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "ID", __arg1);
        __builder.AddAttribute(__seq2, "Width", __arg2);
        __builder.AddAttribute(__seq3, "DataSource", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateSfDropDownList_5<TValue, TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Collections.Generic.IEnumerable<TItem> __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.DropDowns.SfDropDownList<TValue, TItem>>(seq);
        __builder.AddAttribute(__seq0, "CssClass", __arg0);
        __builder.AddAttribute(__seq1, "ID", __arg1);
        __builder.AddAttribute(__seq2, "Width", __arg2);
        __builder.AddAttribute(__seq3, "DataSource", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
