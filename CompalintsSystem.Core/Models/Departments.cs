﻿using CompalintsSystem.Core.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompalintsSystem.Core.Models
{
    public class Departments : IEntityBase
    {
        public Departments()
        {
            //DepartmentsId = Guid.NewGuid().ToString();
            Users = new List<ApplicationUser>();
            //Beneficiaries = new List<Beneficiarie>();

        }
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public int CollegesId { get; set; }
        [ForeignKey("CollegesId")]
        public virtual Colleges Colleges { get; set; }

        //RelationShipes one to many
        public virtual ICollection<SubDepartments> SubDepartmentss { get; set; }
        public virtual ICollection<UsersCommunication> UsersCommunications { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }
        //public virtual ICollection<Beneficiarie> Beneficiaries { get; set; }
        public virtual ICollection<UploadsComplainte> UploadsComplaintes { get; set; }

        //public virtual List<User> Users { get; set; }
        //public virtual List<Beneficiarie> Beneficiaries { get; set; }

    }

}
