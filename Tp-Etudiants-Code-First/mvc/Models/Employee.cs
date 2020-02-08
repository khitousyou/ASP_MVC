using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public String nom { get; set; }
        public String Prenom { get; set; }
       
    }
}