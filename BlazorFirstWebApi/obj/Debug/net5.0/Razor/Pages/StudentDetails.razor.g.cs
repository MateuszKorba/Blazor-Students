#pragma checksum "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\StudentDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "951b2df473af933f28f6899450c43394aa48cdcb"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/students/studentDetails/{IdStudent}")]
    public partial class StudentDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<head><style>
        .left{
            margin-top:30px;
        }
        .right {
            margin-top: 30px;
        }
        .left {
            margin-left: 10px;
            float: left;
            width: 45%;
            text-align:left
        }

        .right {
            float: right;
            width: 50%;
            position:relative;
        }

        .left table tr td {
            text-align: right;
        }

        .left table tr td input {
            text-align: center;
        }

        .left table tr td input {
            margin-left: 20px;
        }

        .right table {
            text-align: center;
        }

        .right table tr td input {
            margin-left: 20px;
        }

        .left .backbutton {
            background-color: #0066cc;
            color: white;
            border: 1px solid #0066cc;
            margin-top: 4px;
        }
        .avatarImage {
            display: block;
            margin-left: auto;
            margin-right: auto;
            width: 200px;
            height: 200px;
        }
    </style></head>
");
            __builder.OpenElement(1, "body");
            __builder.AddMarkupContent(2, "<h3><u>Student\'s details</u></h3>\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "left");
            __builder.OpenElement(5, "table");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<td>First name:<br><br></td>\r\n                    ");
            __builder.OpenElement(8, "td");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "name", "First name");
            __builder.AddAttribute(12, "value", 
#nullable restore
#line 68 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\StudentDetails.razor"
                                                                     student.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "size", "15");
            __builder.AddAttribute(14, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "<br><br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "<td>Last name:<br><br></td>\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "name", "Last name");
            __builder.AddAttribute(23, "value", 
#nullable restore
#line 72 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\StudentDetails.razor"
                                                                    student.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "size", "15");
            __builder.AddAttribute(25, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "<br><br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "<td>Birthdate:<br><br></td>\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "name", "Birthdate");
            __builder.AddAttribute(34, "value", (
#nullable restore
#line 76 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\StudentDetails.razor"
                                                                    student.BirthDate.Day

#line default
#line hidden
#nullable disable
            ) + "." + (
#nullable restore
#line 76 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\StudentDetails.razor"
                                                                                           student.BirthDate.Month

#line default
#line hidden
#nullable disable
            ) + "." + (
#nullable restore
#line 76 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\StudentDetails.razor"
                                                                                                                    student.BirthDate.Year

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "size", "15");
            __builder.AddAttribute(36, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "<br><br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "<td>Studies:<br><br></td>\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "text");
            __builder.AddAttribute(44, "name", "Studies");
            __builder.AddAttribute(45, "value", 
#nullable restore
#line 80 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\StudentDetails.razor"
                                                                  student.Studies

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "size", "15");
            __builder.AddAttribute(47, "disabled");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "<br><br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "class", "backbutton");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "value", "Return");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\StudentDetails.razor"
                                                                               () => OnButtonClicked()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "right");
            __builder.OpenElement(58, "table");
            __builder.AddAttribute(59, "align", "center");
            __builder.OpenElement(60, "tr");
            __builder.AddMarkupContent(61, "<td>Avatar</td>\r\n                    ");
            __builder.OpenElement(62, "td");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "text");
            __builder.AddAttribute(65, "name", "Avatar");
            __builder.AddAttribute(66, "value", 
#nullable restore
#line 89 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\StudentDetails.razor"
                                                                 student.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(67, "size", "15");
            __builder.AddAttribute(68, "disabled");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "<br>\r\n            ");
            __builder.OpenElement(70, "img");
            __builder.AddAttribute(71, "src", 
#nullable restore
#line 92 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\StudentDetails.razor"
                       student.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(72, "class", "avatarImage");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "G:\Semestr 4\APBD\cwiczenia\cw11\cwiczenia11_jd-MateuszKorba\BlazorFirstWebApi\Pages\StudentDetails.razor"
       
    private Student student;
    [Parameter]
    public string IdStudent { get; set; }

    protected override void OnInitialized()
    {
        student = iStudentService.listOfStudents.Where(x => x.IdStudent == Int32.Parse(IdStudent)).First();
    }

    private void OnButtonClicked()
    {
        navigationManager.NavigateTo($"/students");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService iStudentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591