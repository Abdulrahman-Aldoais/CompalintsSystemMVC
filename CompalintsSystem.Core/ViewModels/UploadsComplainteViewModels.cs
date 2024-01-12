﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace CompalintsSystem.Core.ViewModels
{

    public class InputFile
    {
        [Required]
        public IFormFile File { get; set; }

    }


    public class InputCompmallintVM
    {


        public int Id { get; set; }
        public IFormFile? File { get; set; }
        public string UserId { get; set; }
        public string UserRoleName { get; set; }

        [Required(ErrorMessage = "يجب ان تقوم بكتابة هذه الحقل ")]
        public string TitleComplaint { get; set; }

        [Required(ErrorMessage = "يجب ان تقوم بكتابة هذه الحقل ")]
        public int? TypeComplaintId { get; set; }

        //public IEnumerable<SelectListItem> SubDepartmentss { get; set; }
        [Required(ErrorMessage = "يجب ان تقوم بكتابة هذه الحقل ")]
        public string DescComplaint { get; set; }

        public int? SocietyId { get; set; }

        public int StatusCompalintId { get; set; } = 1;
        public int StagesComplaintId { get; set; } = 1;
        [Required(ErrorMessage = "يجب ان تقوم بإختبار المنطقة المحددة ")]

        public int CollegesId { get; set; }
        [Required(ErrorMessage = "يجب ان تقوم بإختبار المنطقة المحددة ")]

        public int DepartmentsId { get; set; }
        [Required(ErrorMessage = "يجب ان تقوم بإختبار المنطقة المحددة ")]

        public int? SubDepartmentsId { get; set; }
        public int? VillageId { get; set; }

        //[Required(ErrorMessage = "يجب ان تقوم بكتابة هذه الحقل ")]
        public string PropBeneficiarie { get; set; }

        public DateTime CompDate { get; set; }
        //[Timestamp]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime CompDateUp { get; set; }

        public DateTime UploadDate { get; set; }
        public string OriginalFileName { get; set; }
        public string FileName { get; set; }
        public decimal Size { get; set; }

        public string ContentType { get; set; }
        public string Today { get; set; }

    }

    public class UploadViewModel
    {
        public string TitleComplaint { get; set; }
        [Required(ErrorMessage = "يجب ان تقوم بكتابة هذه الحقل ")]
        public int? TypeComplaintId { get; set; }
        [Required(ErrorMessage = "يجب ان تقوم بكتابة هذه الحقل ")]
        public string DescComplaint { get; set; }
        public int? SocietyId { get; set; }
        public int StatusCompalintId { get; set; }
        public int StagesComplaintId { get; set; }
        public string PropBeneficiarie { get; set; }

        //public  List<Colleges> Collegess { get; set; }
        public int CollegesId { get; set; }
        public int? DepartmentsId { get; set; }
        public int? SubDepartmentsId { get; set; }
        public int? VillageId { get; set; }


    }



}
