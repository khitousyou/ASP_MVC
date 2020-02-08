using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assembly_apple_methode;

namespace Tp1_Etudiants_Code_First
{
    public class Entity
    {
        public static Filieres f = new Filieres();
        public static Groupes g = new Groupes();
        public static Etudiants e = new Etudiants();
        public static EtudiantsDBContext v = new EtudiantsDBContext();
        public static Etudinats_Repositoy prd = new Etudinats_Repositoy();
    }
}