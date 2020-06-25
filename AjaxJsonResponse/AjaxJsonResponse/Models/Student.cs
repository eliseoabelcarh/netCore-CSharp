﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxJsonResponse.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        [Required]
        public string studentName { get; set; }
        [Required]
        public string studentAddress { get; set; }
    }
}
