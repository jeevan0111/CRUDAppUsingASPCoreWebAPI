using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDAppUsingASPCoreWebAPI.Models
{
	public class Student
	{
		public int  id { get; set; }
        [Required]
		public string studentName { get; set; } = string.Empty;
        [Required]
        public string studentGender { get; set; } = string.Empty;
        [Required]
        public int age { get; set; }
        [Required]
        public string standard { get; set; } = string.Empty;
        [Required]
        public string fatherName { get; set; } = string.Empty;
    }
}

