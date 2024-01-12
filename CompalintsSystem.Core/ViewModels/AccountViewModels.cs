﻿using CompalintsSystem.Core.Constants;
using CompalintsSystem.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompalintsSystem.Core.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = Constant.Messages.InvalidIdentityNumber)]
        [Display(Name = "رقم البطاقة")]

        public string Email { get; set; }
        [Required(ErrorMessage = Constant.Messages.Required)]
        [DataType(DataType.Password)]
        [Display(Name = "كلمة السر")]
        public string Password { get; set; }

        [Display(Name = "تذكرني")]
        public bool RememberMe { get; set; }

    }


    public class ChangePasswordViewModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = Constant.Messages.Required), RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = Constant.Messages.PasswordCondation)]
        public string CurrentPassword { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = Constant.Messages.Required), RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "صيغة يجب ان تكون كلمة السر ارقام و حروف و رموز")]
        public string NewPassword { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = Constant.Messages.Required), Compare("NewPassword", ErrorMessage = Constant.Messages.PasswordMatch)]
        public string PasswordConfirm { get; set; }
    }



    public class EditUserViewModel
    {
        public string Id { get; set; }
        [Display(Name = " الاسم")]
        [Required(ErrorMessage = "يجب ادخال الاسم كاملا")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "ادخل رقم البطاقة الجامعي"), MaxLength(12, ErrorMessage = "يجب ان لا يكون رقم البطاقة اكثر من اثنا عشر ارقام "), MinLength(9, ErrorMessage = "يجب ان لا يكون رقم البطاقة ياغالي  اقل من تسعة ارقام  ")]
        //[Remote(action: "CheckingIdentityNumber", controller: "ManageUsers")]
        public string IdentityNumber { get; set; }
        [Required(ErrorMessage = "ادخل رقم الهاتف"), MaxLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اكثر من تسعة ارقام "), MinLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اقل من تسعة ارقام")]
        [Remote(action: "CheckingPhoneNumber", controller: "ManageUsers")]
        public string PhoneNumber { get; set; }
        //public virtual IdentityRole Role { get; set; }
        public string? ProfilePicture { get; set; }
        public IEnumerable<Colleges> CollegessList { get; set; }
        [Required(ErrorMessage = "اختر الكلية")]
        public int CollegesId { get; set; }
        [Required(ErrorMessage = "اختر القسم")]
        public int DepartmentsId { get; set; }
        public string DepartmentsName { get; set; }
        [Required(ErrorMessage = "اختر المستوى")]
        public int SubDepartmentsId { get; set; }
        public string SubDepartmentsName { get; set; }

        //[DataType(DataType.Password)]
        //[Required(ErrorMessage = "يرجى ادخال كلمة المرور"), RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "صيغة يجب ان تكون كلمة السر ارقام و حروف و رموز")]
        //public string Password { get; set; }
        //[DataType(DataType.Password)]
        //[Required(ErrorMessage = "يرجى اعادة ادخال كلمة المرور"), Compare("Password", ErrorMessage = "كلمة المرور غير متطابقة")]
        //public string PasswordConfirm { get; set; }
        public bool IsBlocked { get; set; }
        [Required(ErrorMessage = "اختر الصلاحية الممنوحة")]
        [Display(Name = "نوع المستخدم")]
        public int RoleId { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;


    }


    public class UserProfileEditVM
    {
        [Display(Name = " الاسم")]
        [Required(ErrorMessage = "يجب ادخال الاسم كاملا")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "ادخل رقم البطاقة"), MaxLength(12, ErrorMessage = "يجب ان لا يكون رقم البطاقة اكبر من تسعة 12 رقم "), MinLength(9, ErrorMessage = "يجب ان لا يكون رقم البطاقةيا غالي اقل من تسعة ارقام")]
        public string IdentityNumber { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "ادخل رقم الهاتف"), MaxLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اكثر من تسعة ارقام "), MinLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اقل من تسعة ارقام")]
        public string PhoneNumber { get; set; }
        public virtual IdentityRole Role { get; set; }
        //public byte[] ProfilePicture { get; set; }

    }

    public class UserViewModels
    {
        public string Id { get; set; }
        public string FullName { get; set; }

        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int CollegesId { get; set; }
        //[ForeignKey("CollegesId")]
        public virtual Colleges Collegess { get; set; }
        public int DepartmentsId { get; set; }
        //[ForeignKey("DepartmentsId")]

        public virtual Departments Departmentss { get; set; }
        public int SubDepartmentsId { get; set; }
        //[ForeignKey("SubDepartmentsId")]

        public virtual SubDepartments SubDepartments { get; set; }

        public bool IsBlocked { get; set; }

        // public string UserId{ get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }



    }

    public class AddUserViewModel
    {
        [Required(ErrorMessage = "ادخل الاسم ")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "ادخل رقم البطاقة الاكاديمي"), MaxLength(12, ErrorMessage = "يجب ان لا يكون رقم البطاقة اكثر من اثنا عشر ارقام "), MinLength(9, ErrorMessage = "يجب ان لا يكون رقم البطاقة اقل من تسعة ارقام")]
        //[Remote(action: "CheckingIdentityNumber", controller: "ManageUsers", ErrorMessage = "ksdfsdfsf")]
        public string IdentityNumber { get; set; }
        [Required(ErrorMessage = "ادخل رقم الهاتف"), MaxLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اكثر من تسعة ارقام "), MinLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اقل من تسعة ارقام")]
        [Remote(action: "CheckingPhoneNumber", controller: "ManageUsers")]
        public string PhoneNumber { get; set; }
        public IEnumerable<Colleges> CollegessList { get; set; }
        [Required(ErrorMessage = "اختر الكلية")]
        public int CollegesId { get; set; }
        [Required(ErrorMessage = "اختر القسم")]
        public int DepartmentsId { get; set; }
        [Required(ErrorMessage = "اختر المستوى")]
        public int SubDepartmentsId { get; set; }
        public string UserId { get; set; }
        public string OriginatorName { get; set; }
        public int? SocietyId { get; set; }
        //public IEnumerable<string> Roles { get; set; }
        public string ProfilePicture { get; set; }
        [Display(Name = "نوع المستخدم")]
        [Required(ErrorMessage = " حدد الصلاحية الممنوحة")]
        public int userRoles { get; set; }
        public bool IsBlocked { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "يرجى ادخال كلمة المرور"), RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "صيغة يجب ان تكون كلمة السر ارقام و حروف و رموز")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "يرجى اعادة ادخال كلمة المرور"), Compare("Password", ErrorMessage = "كلمة المرور غير متطابقة")]
        public string PasswordConfirm { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedDate { get; set; }

    }

}