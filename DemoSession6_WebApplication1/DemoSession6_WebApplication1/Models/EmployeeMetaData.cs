using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession6_WebApplication1.Models
{
    [ModelMetadataType(typeof(EmployeeMetaData))]
    public partial class Employee
    {
       
    }
    public class EmployeeMetaData
    {
        //Set requirements for Username
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Username { get; set; }


        //Set requirements for passwords
        [Required]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string Website { get; set; }

    }
}
