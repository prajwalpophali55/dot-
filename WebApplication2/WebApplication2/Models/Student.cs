﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication2.Models
{
    public partial class Student
    {
        public int? Id { get; set; }
        public int? Rollno { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public int? Classid { get; set; }
    }
}
