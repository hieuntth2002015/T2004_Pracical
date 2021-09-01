using System;
using System.Collections.Generic;

#nullable disable

namespace T2004_Pracical.Models
{
    public partial class Student
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
