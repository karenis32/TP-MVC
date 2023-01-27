using Microsoft.AspNetCore.Mvc;
using SLNClinica.Data;
using SLNClinica.Models;
using System.Linq;

namespace SLNClinica.Controllers
{
    public class MedicoController : Controller
    {
        private readonly DBSLNClinicaContext context;

        public MedicoController(DBSLNClinicaContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var medicos = context.Medicos.ToList();

            return View(medicos);
        }

        //get: medico/create
        [HttpGet]
        public ActionResult Create()
        {
            Medico medico = new Medico();

            return View("Create", medico);//devolver al cliente html (vista)
        }

        //post: medico/Create
        [HttpPost]
        public ActionResult Create(Medico medico)
        {
            if (ModelState.IsValid)
            {
                context.Medicos.Add(medico);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medico);
        }


        // GET medico/delete/1
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", medico);
            }
        }

        //POST opera/delete/1
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                context.Medicos.Remove(medico);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }

        //GET Medico/Details/4
        [HttpGet]
        public ActionResult Details(int id)
        {
            Medico medico = TraerUno(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View("detalle", medico);
            }

        }

        private Medico TraerUno(int id)
        {
            return context.Medicos.Find(id);
        }


        //GET Medico/Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Medico medico = TraerUno(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View("edit", medico);
            }

        }

        //POST Medico/Edit
        [HttpPost]
        public ActionResult Edit(int id, [FromBody] Medico medico)
        {
            medico = TraerUno(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                context.Medicos.Update(medico);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}
