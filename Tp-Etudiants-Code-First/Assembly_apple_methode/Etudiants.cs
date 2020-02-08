using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assembly_apple_methode
{
  public   class Etudiants
    {
        [Key]
        public int id { get; set; }
        public String nom { get; set; }
        public String Prenom { get; set; }
        public String Adress { get; set; }
        public DateTime date { get; set; }
        public int groupid { get; set; }
        [ForeignKey("groupid")]
        public Groupes groupes { get; set; }
    }
}
