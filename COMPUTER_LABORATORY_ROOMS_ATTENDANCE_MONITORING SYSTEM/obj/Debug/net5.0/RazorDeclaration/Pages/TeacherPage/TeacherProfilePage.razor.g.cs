// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Pages.TeacherPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using MudBlazor.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsClassSchedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSubject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsStudent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTimInOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTimelogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsFilter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.ScheduleService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.UserService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.TeacherService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.SectionService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.SubjectService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.StudentService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.TimelogsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.GlobalService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\Pages\TeacherPage\TeacherProfilePage.razor"
using System.Transactions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/teacher/profile")]
    public partial class TeacherProfilePage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\Pages\TeacherPage\TeacherProfilePage.razor"
       
    Teacher teacher = new Teacher();
    List<Teacher> teachers = new List<Teacher>();
    List<Schedule> handleSubject = new List<Schedule>();
    DateTime? bday = DateTime.Today;

    Enums.Gender gender { get; set; }
    MudMessageBox mbox { get; set; }
    MudMessageBox dbox { get; set; }

    string searchString = "";
    bool open = false;
    bool disable = true;

    protected override void OnInitialized()
    {
        LoadAllTeachers();
        GetTeacher();
        ListOfHandleSubject();
        base.OnInitialized();
    }

    public List<Teacher> LoadAllTeachers()
    {
        teachers = teacherService.GetAllTeacher();
        return teachers;
    }
    private void UpdateTeacher()
    {
        try
        {
            teacher.Gender = gender;
            teacher.BirthDate = bday.GetValueOrDefault();
            var teacher1 = teacherService.UpdateTeacher(teacher);
            teachers.RemoveAll(x => x.Id == teacher1.Id);
            teachers.Add(teacher1);
            Common.ShowAlert("Updated successfully", Severity.Success, SnackBar);
            disable = true;
        }
        catch (Exception)
        {
            throw;
        }
    }
    private bool FilterFunc1(Teacher teacher) => FilterFunc(teacher, searchString);
    private bool FilterFunc(Teacher teacher, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (teacher.FirstName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (teacher.MiddleName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (teacher.LastName.Contains(searchString))
            return true;
        return false;
    }
    private void GetTeacher()
    {
        var teach = teacherService.GetTeacherByIdNumber(Convert.ToInt64(Global.CurrentUser.IDNumber));
        teacher = teach;
        gender = teach.Gender;
        bday = teach.BirthDate;
    }

    private async void ShowMessageBox(Teacher teacher)
    {
        bool? result = await mbox.Show();
        if (result != null)
        {
            try
            {
                var user = userService.GetUserById(Convert.ToInt64((string)teacher.EmployeeId));
                user.UserName = teacher.FirstName.ToLower() + '.' + teacher.LastName.ToLower();
                user.Password = "temporary1234";
                var account = userService.ResetAccount(user);
                //if(account != null)
                Common.ShowAlert("Account reset successfully!", Severity.Success, SnackBar);
            }
            catch (Exception ex)
            {
                Common.ShowAlert(ex.ToString(), Severity.Error, SnackBar);
            }
        }
        StateHasChanged();
    }
    private async void DeactivateAccount(Teacher teacher)
    {
        bool? result = await dbox.Show();
        if (result != null)
        {
            try
            {
                var user = userService.GetUserById(Convert.ToInt64((string)teacher.EmployeeId));
                teacherService.DeactivateTeacher(teacher);
                userService.DeactivateUser(user);
                teachers.RemoveAll(x => x.Id == teacher.Id);
                StateHasChanged();
                Common.ShowAlert("Account deactivated successfully!", Severity.Success, SnackBar);
            }
            catch (Exception ex)
            {
                Common.ShowAlert(ex.ToString(), Severity.Error, SnackBar);
            }
        }
    }
    private void ListOfHandleSubject()
    {
         handleSubject = classScheduleService.GetScheduleByTeacherId(Convert.ToInt64(Global.CurrentUser.UserId));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar SnackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassScheduleService classScheduleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeacherService teacherService { get; set; }
    }
}
#pragma warning restore 1591
