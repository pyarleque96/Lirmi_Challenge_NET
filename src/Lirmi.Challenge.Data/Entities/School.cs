﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Lirmi.Challenge.Data.Entities
{
    public partial class School
    {
        public School()
        {
            Grade = new HashSet<Grade>();
        }

        public int SchoolId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Code { get; set; }
        public string TypeDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }

        public virtual ICollection<Grade> Grade { get; set; }
    }
}