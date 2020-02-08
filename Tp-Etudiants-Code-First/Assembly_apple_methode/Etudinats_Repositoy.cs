using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly_apple_methode
{
  public  class Etudinats_Repositoy
    {
        EtudiantsDBContext v = new EtudiantsDBContext();
        Etudiants e = new Etudiants();
        Groupes g = new Groupes();
        Filieres f = new Filieres();

        public Etudiants GetEtudiantsbyid(int id)
        {
             return  v.Etudiants.Single(q => q.id == id);
        }

        public  List<Etudiants> GetEtudiants()
        {
            return v.Etudiants.ToList();
        }
        public List<Groupes> GetGroupes()
        {
            return v.Groupes.ToList();
        }
        public List<Filieres> GetFilieres()
        {
            return v.Filieres.ToList();
        }
        public void add_flr(Filieres ff)
        {
            v.Filieres.Add(ff);
            v.SaveChanges();
        }
        public void add_group(Groupes gg)
        {
            v.Groupes.Add(gg);
            v.SaveChanges();
        }
        public  void Add_Etudiants(Etudiants e)
        {
            v.Etudiants.Add(e);
            v.SaveChanges();
        }
    }
}
