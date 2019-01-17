using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using meinUmfrageTool.Models;

namespace meinUmfrageTool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private static FragebogenModel generischerFragebogen = new FragebogenModel
        {
            Fragen = new List<FragenModel> { new FragenModel() { Text = "Fragentext?" } }
        };

        private FragebogenModel _fragebogen;

        private FragebogenModel Fragebogen
        {
            get
            {
                if (_fragebogen == null)
                {
                    _fragebogen = Session["Fragebogen"] as FragebogenModel;
                }
                return _fragebogen;
            }
            set
            {
                _fragebogen = value;
                Session["Fragebogen"] = _fragebogen;
            }
        }

        public ActionResult FragebogenErstellen()
        {
            ViewBag.Message = "Erstellen Sie einen neuen Fragebogen";

            if (Fragebogen == null)
            {
                Fragebogen = generischerFragebogen;
            }

            return View(Fragebogen);
        }

        [HttpPost]
        public ActionResult FragebogenErstellen(FragebogenModel fragebogen, string befehl)
        {
            //try
            //{
            //if (befehl == "Frage hinzufuegen")
            //{
                //fragebogen.Fragen = new List<FragenModel>();
                //fragebogen.Fragen.Add(new FragenModel());
                fragebogen.Bezeichnung = "Haha!";
                Fragebogen = fragebogen;
            //}
            return RedirectToAction("FragebogenErstellen");
            //}
            //catch (Exception)
            //{

            //    return View();
            //}
        }
    }
}