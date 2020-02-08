using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Assembly_apple_methode
{
   public class EtudiantsDBContext:DbContext
    {
        public DbSet<Etudiants> Etudiants { get; set; }
        public DbSet<Groupes> Groupes { get; set; }
        public DbSet<Filieres> Filieres { get; set; }
        public EtudiantsDBContext() : base("EtudiantsDBContext") { }
    }
}
