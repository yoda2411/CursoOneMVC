using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mod=Modules;
using Modelo;
using System.Data.Entity;

namespace WebAppUno.Controllers
{
    public class HomeController : Controller
    {
        private Alumno dbctx = new Alumno();
        // GET: Home
        public ActionResult Index()
        {       
            return View();
        }
        public ActionResult Alumno()
        {
            //ViewBag.Alumnos = mod.Alumno.ListaAlumno();
            return View(dbctx.GetAll());
        }
        public ActionResult GetById(int Id=0)
        {
            return View(dbctx.GetById(Id));
        }
        public ActionResult Salve(Alumno alumn)
        {      
          alumn.Salve();
            return Redirect("~/Home/Alumno");
        }
        public ActionResult MtAlumno(int Id=0)
        {
            return View(Id==0?new Alumno(): dbctx.GetById(Id));
        }
        public ActionResult Eliminar(int Id=0)
        {
            dbctx.IdAlumno = Id;
            dbctx.Delected();
            return Redirect("~/Home/Alumno");
        }
    }
}