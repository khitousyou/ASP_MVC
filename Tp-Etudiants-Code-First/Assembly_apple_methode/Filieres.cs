using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assembly_apple_methode
{
   public class Filieres
    {
        [Key]
        public int id { get; set; }
        public String Title { get; set; }
        //public List<Groupes> groupes { get; set; }
    }
}
