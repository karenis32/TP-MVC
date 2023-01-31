using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebEscuelaMVC.Data;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {
        private readonly EscuelaDBMVCContext context;

        public AulaController(EscuelaDBMVCContext context)
        {
            this.context = context;
        }

        //GET aula/index
        [HttpGet]
        public IActionResult Index()
        {
            var aulas = context.Aulas.ToList();
            return View(aulas);
        }

        //Get: Aula/Register
        [HttpGet]
        public ActionResult Register()
        {
            Aula aula = new Aula();

            return View("Register", aula);
        }

        //post: Aula/Register
        [HttpPost]
        public ActionResult Register(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Aulas.Add(aula);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aula);
        }

        private Aula TraerUna(int id)
        {
            return context.Aulas.Find(id);
        }

        //GET Aula/Details/4
        [HttpGet]
        public ActionResult Detalle(int id)
        {
            Aula aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                return View("detalle", aula);
            }

        }

        //GET Aula/Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Aula aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                return View("Edit", aula);
            }

        }

        //POST Aula/Edit
        [HttpPost]
        public ActionResult Edit(int id, Aula aula)
        {
            //aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                context.Aulas.Update(aula);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        // GET Aula/delete/1
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var aula = context.Aulas.Find(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", aula);
            }
        }

        //POST Aula/delete/1
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var aula = context.Aulas.Find(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                context.Aulas.Remove(aula);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}
