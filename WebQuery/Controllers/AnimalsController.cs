using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebQuery.Models;

namespace WebQuery.Controllers
{
    public class AnimalsController : Controller
    {

        private readonly dbContext _context;

        public AnimalsController(dbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<SelectListItem> lst = new List<SelectListItem>();

            using (var db = _context) 
            {
                var animalClass = (from d in db.animal_class
                                   select new SelectListItem
                                   {
                                       Value = d.id.ToString(),
                                       Text = d.id.ToString() + " | " + d.name
                                   }).ToList();
                lst = animalClass;
            }

            return View(lst);
        }

        public JsonResult Animal(int idAnimalClass)
        {
            List<ElementJsonIntKey> lst = new List<ElementJsonIntKey>();
            using (var db = _context)
            {
                lst = (from d in db.animal
                       where d.idAnimal_class == idAnimalClass
                       select new ElementJsonIntKey
                       {
                           Value = d.id,
                           Text = d.name
                       }
                        ).ToList();
            }

            return Json(lst);
        }

        
    }

    public class ElementJsonIntKey
    {
        public int Value { get; set; }
        public string Text { get; set; }
    }

}
