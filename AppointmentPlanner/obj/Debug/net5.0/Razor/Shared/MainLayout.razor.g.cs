#pragma checksum "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f1bd6bbf6d47f6e9905359e7243248264b43045"
// <auto-generated/>
#pragma warning disable 1591
namespace AppointmentPlanner.Shared
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
#line 4 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
using AppointmentPlanner.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
using AppointmentPlanner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sb-content-overlay" + " " + (
#nullable restore
#line 9 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
                                 hide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(2, "<div class=\"sb-loading\"><svg class=\"circular\" height=\"40\" width=\"40\"><circle class=\"path\" cx=\"25\" cy=\"25\" r=\"20\" fill=\"none\" stroke-width=\"6\" stroke-miterlimit=\"10\"></circle></svg></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "planner-wrapper");
            __builder.AddAttribute(6, "style", "width:" + " 100%;" + " visibility:" + (
#nullable restore
#line 16 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
                                                              visible

#line default
#line hidden
#nullable disable
            ) + ";" + " opacity:" + (
#nullable restore
#line 16 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
                                                                                  opacity

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Syncfusion.Blazor.Navigations.SfSidebar>(7);
            __builder.AddAttribute(8, "ID", "plannerSiderBar");
            __builder.AddAttribute(9, "EnableGestures", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
                                                    false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "MediaQuery", "(min-width: 600px)");
            __builder.AddAttribute(11, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.SidebarType>(
#nullable restore
#line 17 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
                                                                                                                     SidebarType.Auto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Created", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 17 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
                                                                                                                                                OnCreate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "CloseOnDocumentClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
                                                                                                                                                                                onDocumentClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
                                                                         open

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => open = __value, open))));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "dock");
                __builder2.AddMarkupContent(19, @"<div class=""info align-center""><div class=""image""><img src=""css/appoinment/assets/images/Admin.png"" alt=""Admin""></div>
                    <div class=""content nameContent""><p class=""name"">Jane Doe</p>
                        <p class=""user-type"">Admin</p></div></div>
                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "sideparent menulist");
                __builder2.OpenElement(22, "ul");
                __builder2.AddAttribute(23, "class", "nav flex-column");
                __builder2.OpenElement(24, "li");
                __builder2.AddAttribute(25, "class", "nav-item e-list-item");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
                __builder2.AddAttribute(27, "class", "nav-link sidebar-item");
                __builder2.AddAttribute(28, "href", "");
                __builder2.AddAttribute(29, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 30 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
                                                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(31, "<span class=\"dashboard-image\"><span class=\"item-image icon-dashboard\"></span></span>\r\n                                ");
                    __builder3.AddMarkupContent(32, "<span class=\"text\" aria-hidden=\"true\" title=\"Dashboard\">Dashboard</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "li");
                __builder2.AddAttribute(35, "class", "nav-item e-list-item");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
                __builder2.AddAttribute(37, "class", "nav-link sidebar-item");
                __builder2.AddAttribute(38, "href", "schedule");
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "<span class=\"dashboard-image\"><span class=\"item-image icon-schedule\"></span></span>\r\n                                ");
                    __builder3.AddMarkupContent(41, "<span class=\"text\" aria-hidden=\"true\" title=\"Schedule\">Schedule</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.OpenElement(43, "li");
                __builder2.AddAttribute(44, "class", "nav-item e-list-item");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
                __builder2.AddAttribute(46, "class", "nav-link sidebar-item");
                __builder2.AddAttribute(47, "href", "doctors");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "<span class=\"dashboard-image\"><span class=\"item-image icon-doctors\"></span></span>\r\n                                ");
                    __builder3.AddMarkupContent(50, "<span class=\"text\" aria-hidden=\"true\" title=\"Doctors\">Doctors</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __builder2.OpenElement(52, "li");
                __builder2.AddAttribute(53, "class", "nav-item e-list-item");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
                __builder2.AddAttribute(55, "class", "nav-link sidebar-item");
                __builder2.AddAttribute(56, "href", "patients");
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(58, "<span class=\"dashboard-image\"><span class=\"item-image icon-patients\"></span></span>\r\n                                ");
                    __builder3.AddMarkupContent(59, "<span class=\"text\" aria-hidden=\"true\" title=\"Patients\">Patients</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __builder2.OpenElement(61, "li");
                __builder2.AddAttribute(62, "class", "nav-item e-list-item");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(63);
                __builder2.AddAttribute(64, "class", "nav-link sidebar-item");
                __builder2.AddAttribute(65, "href", "preference");
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(67, "<span class=\"dashboard-image\"><span class=\"item-image icon-preference\"></span></span>\r\n                                ");
                    __builder3.AddMarkupContent(68, "<span class=\"text\" aria-hidden=\"true\" title=\"Preference\">Preference</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.OpenElement(70, "li");
                __builder2.AddAttribute(71, "class", "nav-item e-list-item");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(72);
                __builder2.AddAttribute(73, "class", "nav-link sidebar-item");
                __builder2.AddAttribute(74, "href", "about");
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(76, "<span class=\"dashboard-image\"><span class=\"item-image icon-about\"></span></span>\r\n                                ");
                    __builder3.AddMarkupContent(77, "<span class=\"text\" aria-hidden=\"true\" title=\"About\">About</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.OpenElement(79, "main");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "planner-header");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "side-bar-opener");
            __builder.OpenElement(84, "span");
            __builder.AddAttribute(85, "class", "open-icon e-icons");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
                                                           showSideBar

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.AddMarkupContent(88, "<div class=\"name-cantainer\"><span class=\"clinic-image icon-logo\"></span>\r\n                <h1 class=\"clinic-name appointment-title\">APPOINTMENT PLANNER</h1></div>\r\n            ");
            __builder.AddMarkupContent(89, "<div class=\"logout-container\"><div class=\"logout-icon-container\"><span class=\"icon-logout logout-image\"></span></div>\r\n                <span class=\"logout-name\">Logout</span></div>\r\n            ");
            __builder.AddMarkupContent(90, @"<div class=""sb-header-item sb-table-cell sb-download-wrapper""><a href=""https://github.com/syncfusion/ej2-showcase-blazor-appointment-planner"" target=""_blank""><div id=""github"" class=""sb-github-btn""><div class=""github-image""><img src=""css/appoinment/mark.svg""></div></div></a></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.AddContent(92, 
#nullable restore
#line 105 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Users\dnvit\Documents\Projects\Visual Studio 2019\OnyceHis\AppointmentPlanner\Shared\MainLayout.razor"
      
    [Inject]
    protected AppointmentService Service { get; set; }
    [Inject]
    protected IJSRuntime JsRuntime { get; set; }

    private bool onDocumentClick { get; set; }
    private bool isDevice { get; set; }

    private string target { get; set; } = "#loader-content";

    private string visible { get; set; } = "hidden";
    private string OverlayClass { get; set; }

    private string hide { get; set; }
    private string opacity { get; set; } = "0";
    private bool open { get; set; }
    private List<NavigationMenu> navigationItems { get; set; }

    public void OnCreate()
    {
        this.hide = "sb-hide";
        this.visible = "visible";
        this.opacity = "1";
    }

    protected override void OnInitialized()
    {
        this.navigationItems = Service.NavigationMenu;
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            this.isDevice = await JSRuntime.InvokeAsync<bool>("checkBrowserDevice");
            this.onDocumentClick = this.isDevice;
        }
    }

    private void showSideBar()
    {
        open = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
