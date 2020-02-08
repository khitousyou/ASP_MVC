using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;
using Assembly_apple_methode;
namespace mvc.Controllers
{
    public class EtudiantsController : Controller
    {
        //index
        public ActionResult getTous()
        {
            Assembly_apple_methode.EtudiantsDBContext prd = new EtudiantsDBContext();
           List<Etudiants> et= prd.Etudiants.ToList();
            return View(et);
        }

        //details
        public ActionResult Index(int id)
        {
            Assembly_apple_methode.Etudiants etudiants = new Etudiants();
            Assembly_apple_methode.EtudiantsDBContext prd = new EtudiantsDBContext();
            etudiants= prd.Etudiants.Single(em => em.id == id);
            return View(etudiants);
        }

        public ActionResult get()
        {
            Employee em = new Employee()
            {
                id = 100,
                nom = "khitous",
                Prenom="Youssef"

            };
            return View(em);
        }
        // return typeof(Controller).Assembly.GetName().Version.ToString();
        public ActionResult alo()
        {
            ViewData["khi"] = new List<String>()
            {
                "khitous",
                 "youssef"
        };
            return View();
        }
        //public ActionResult Index()
        //{   
        //    ViewBag.khitous = new List<string>()
        //    {
        //        "casablanca",
        //        "Rabat",
        //        "Sale"
        //    };
        //    return View();
        }
        //GET: Etudiants
        //public ActionResult Details(int id)
        //{
        //    Etudiants e = new Etudiants();
        
        //    e  =  Entity.GetEtudiantsbyid(id);
        //    //{
        //    //    id = 1,
        //    //    nom = "khitous",
        //    //    Prenom = "youssef"
        //    //};
        //    return View(e);
        //}
        //public ActionResult index1()
        //{
        //    List < Assembly_apple_methode.Etudiants > e =
        //    Entity.prd.GetEtudiants();
            
        //    //EtudiantsDBContext v = new EtudiantsDBContext();
        //    //Filieres f = new Filieres();
            
        //    //    f = v.Filieres.Find(id);
        //    return View(e);
        //}

        //public ActionResult getgroup()
        //{
        //    List<Assembly_apple_methode.Groupes> g =
        //   Entity.prd.GetGroupes();
        //    return View(g);
        //}
    //}
}