#pragma checksum "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2296eafd9800c7a7ab31ef889b0117d4bf83b70b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFirstWebApi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using BlazorFirstWebApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using BlazorFirstWebApi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using BlazorFirstWebApi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\_Imports.razor"
using BlazorFirstWebApi.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class AllStudents : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head><style>\r\n        table {\r\n            border-collapse: collapse;\r\n            margin: 0;\r\n            padding: 0;\r\n            width: 100%;\r\n            table-layout: fixed;\r\n            text-align: center;\r\n            margin-top: 50px;\r\n        }\r\n\r\n        th, td {\r\n            padding: 10px;\r\n        }\r\n\r\n        table tr {\r\n            background-color: white;\r\n            padding: .35em;\r\n        }\r\n\r\n        table th, table td {\r\n            padding: .625em;\r\n            text-align: center;\r\n        }\r\n        table tbody tr td img {\r\n            width: 50px;\r\n            height: 50px;\r\n        }\r\n        table tbody tr td input {\r\n            width:40px;\r\n            height:40px;\r\n            float:left;\r\n            margin-left:10px;\r\n        }\r\n\r\n        @media screen and (max-width: 801px) {\r\n            table {\r\n                border: 0;\r\n                margin-bottom: 150px;\r\n            }\r\n\r\n            table thead {\r\n                    border: none;\r\n                    clip: rect(0 0 0 0);\r\n                    height: 1px;\r\n                    margin: -1px;\r\n                    overflow: hidden;\r\n                    padding: 0;\r\n                    position: absolute;\r\n                    width: 1px;\r\n            }\r\n\r\n            table tr {\r\n                    display: block;\r\n                    margin-bottom: .625em;\r\n            }\r\n\r\n            table td {\r\n                    display: block;\r\n                    font-size: .8em;\r\n                    text-align: right;\r\n            }\r\n\r\n            table td::before {\r\n                     content: attr(data-label);\r\n                     float: left;\r\n                     font-weight: bold;\r\n            }\r\n\r\n            table td:last-child {\r\n                     border-bottom: 0;\r\n                     margin-bottom: 50px\r\n            }\r\n\r\n            table tbody tr td input {\r\n                    width: 40px;\r\n                    height: 40px;\r\n                    float: left;\r\n                    margin-left:-10px;\r\n            }\r\n        }\r\n    </style></head>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3><u>Students</u></h3>\r\n");
            __builder.OpenElement(2, "table");
            __builder.OpenElement(3, "thead");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "<th style=\"border: 2px solid black\">Avatar</th>\r\n            ");
            __builder.OpenElement(6, "th");
            __builder.AddAttribute(7, "style", "border: 2px solid black");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                                                            () => SortList("FirstName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "FirstName");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "th");
            __builder.AddAttribute(12, "style", "border: 2px solid black");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                                                            () => SortList("LastName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "LastName");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "th");
            __builder.AddAttribute(17, "style", "border: 2px solid black");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                                                            () => SortList("BirthDate")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "BirthDate");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "th");
            __builder.AddAttribute(22, "style", "border: 2px solid black");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                                                            () => SortList("Studies")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Studies");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "tbody");
#nullable restore
#line 105 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
         foreach (var student in iStudentService.listOfStudents)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "data-label", "Avatar");
            __builder.AddAttribute(30, "style", "border: 2px solid black");
            __builder.OpenElement(31, "img");
            __builder.AddAttribute(32, "src", 
#nullable restore
#line 109 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                               student.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                                                           () => OnAvatarClicked(@student.IdStudent)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "data-label", "FirstName");
            __builder.AddAttribute(37, "style", "border: 2px solid black");
            __builder.AddContent(38, 
#nullable restore
#line 112 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                     student.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "data-label", "LastName");
            __builder.AddAttribute(42, "style", "border: 2px solid black");
            __builder.AddContent(43, 
#nullable restore
#line 115 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                     student.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "data-label", "BirthDate");
            __builder.AddAttribute(47, "style", "border: 2px solid black");
            __builder.AddContent(48, 
#nullable restore
#line 118 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                     student.BirthDate.Day

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(49, ".");
            __builder.AddContent(50, 
#nullable restore
#line 118 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                                            student.BirthDate.Month

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(51, ".");
            __builder.AddContent(52, 
#nullable restore
#line 118 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                                                                     student.BirthDate.Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "data-label", "Studies");
            __builder.AddAttribute(56, "style", "border: 2px solid black");
            __builder.AddContent(57, 
#nullable restore
#line 121 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                     student.Studies

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "td");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "image");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 124 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
                                                    () => DeleteStudent(@student)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "src", "https://findicons.com/files/icons/1262/amora/256/delete.png");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 127 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\AllStudents.razor"
       
    private bool IsSortetAscending;
    private string CurrentSortColumn;

    protected override void OnInitialized()
    {
        iStudentService.SetList();
    }

    async Task DeleteStudent(Student student)
    {
        if (!await ijsRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete the student '{student.FirstName}'?"))
        {
            return;
        }
        iStudentService.listOfStudents.Remove(student);
    }

    private void OnAvatarClicked(int IdStudent)
    {
        navigationManager.NavigateTo($"/students/studentDetails/{IdStudent}");
    }

    private void SortList(string columnName)
    {
        if (columnName != CurrentSortColumn)
        {
            iStudentService.listOfStudents = iStudentService.listOfStudents.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            CurrentSortColumn = columnName;
            IsSortetAscending = true;
        }
        else
        {
            if (IsSortetAscending)
            {
                iStudentService.listOfStudents = iStudentService.listOfStudents.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            }
            else
            {
                iStudentService.listOfStudents = iStudentService.listOfStudents.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            }
            IsSortetAscending = !IsSortetAscending;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime ijsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService iStudentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
