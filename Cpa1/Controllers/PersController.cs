using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cpa1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cpa1.Controllers
{
    public class PersController : Controller
    {
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Lpers str = new Lpers();
            Personne prs = str.personnes.Single(emp => emp.code == id);
            return View(prs);
        }
        [HttpPost]
        public IActionResult Edit(IFormCollection formcollection)
        {


            Personne str = new Personne();
            str.code = Convert.ToInt32(formcollection["code"]);
            str.Nom = formcollection["Nom"].ToString();
            str.Prenom = formcollection["Prenom"].ToString();
            str.qualite = formcollection["qualite"].ToString();
           
            Lpers liste = new Lpers();
            liste.modifypers(str);



            return RedirectToAction("Lstruct","structure");

        }









        // GET: /<controller>/
        public IActionResult Dpers(int id)
        {
            Lpers str = new Lpers();
            Personne prs = str.personnes.Single(emp => emp.code == id);
            return View(prs);
            
        }
        [HttpGet]
        public IActionResult Cpers()
        {
            return View();
        }
   
        [HttpPost]
        public IActionResult Cpers(IFormCollection formcollection)
        {
            Personne str = new Personne();
            str.code = Convert.ToInt32(formcollection["code"]);
            str.Nom = formcollection["Nom"].ToString();
            str.Prenom = formcollection["Prenom"].ToString();
            str.qualite = formcollection["qualite"].ToString();

            Lpers prs = new Lpers();
            prs.addpers(str);
            return RedirectToAction("Index","Home");
        }
    }
}
