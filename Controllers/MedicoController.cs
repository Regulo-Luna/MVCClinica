using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCClinica.Models;
using MVCClinica.Admin;
namespace MVCClinica.Controllers
{
    public class MedicoController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", AdmMedico.Listar());
        }
        [HttpGet]
        public ActionResult Create()
        {
            Medico medico = new Medico();
            return View("Create", medico);
        }

        public ActionResult Create(Medico medico)
        {
            if (ModelState.IsValid)
            {
                AdmMedico.Insertar(medico);
                return RedirectToAction("Index");
            }
            return View("Create", medico);
        }

        public ActionResult Detail(int id)
        {
            Medico medico = AdmMedico.Listar(id);
            if (medico == null)
                return HttpNotFound();

            return View("Detail", medico);
        }

        public ActionResult Edit(int id)
        {
            Medico medico = AdmMedico.BuscarPorId(id);
            if (medico == null)
                return HttpNotFound();

            return View("Edit", medico);
        }

        [HttpPost]
        public ActionResult Edit(Medico medico)
        {
            if (ModelState.IsValid)
            {
                AdmMedico.Modificar(medico);
                return RedirectToAction("Index");
            }
            return View("Edit", medico);
        }

        public ActionResult Delete(int id)
        {
            Medico medico = AdmMedico.Listar(id);
            if (medico == null)
                return HttpNotFound();

            return View("Delete", medico);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Medico medico = AdmMedico.Listar(id);
            if (medico == null)
                return HttpNotFound();

            AdmMedico.Eliminar(medico);

            return RedirectToAction("Index");
        }

        public ActionResult SearchByEspecialidad(string especialidad)
        {
            if (especialidad == null)
                return RedirectToAction("Index");

            return View("Index", AdmMedico.ListarEspecialidad(especialidad));
        }

        public ActionResult SearchByNombreCompleto(string nombre, string apellido)
        {
            if (nombre == null&&apellido == null)
            {
                return RedirectToAction("Index");
                
            }

            return View("Index", AdmMedico.ListarNombre(nombre, apellido));
        }
    }
}