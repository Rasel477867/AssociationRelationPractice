using AssociationRealationship.Models;
using AssociationRealationship.ModelsView;
using AssociationRealationship.Service;
using Microsoft.AspNetCore.Mvc;

namespace AssociationRealationship.Controllers
{
    public class DuetController : Controller
    {
        private readonly IDuetService duetService;
        public DuetController(IDuetService duetService)
        {
            this.duetService = duetService;

            
        }
        public IActionResult Index()
        {
            var model=duetService.GetAll();

            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DuetView obj)
        {
            if (ModelState.IsValid)
            {
                var model = new Duet();
                model.Name = obj.Name;
                model.Description = obj.Description;
                model.Code = obj.Code;
                var state=duetService.Add(model);
                return RedirectToAction("Index");

            }
            return RedirectToAction("Create");
        }
    }
}
