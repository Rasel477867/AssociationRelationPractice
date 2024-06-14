using AssociationRealationship.Models;
using AssociationRealationship.ModelsView;
using AssociationRealationship.Service;
using Microsoft.AspNetCore.Mvc;

namespace AssociationRealationship.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _obj;
        public DepartmentController(IDepartmentService obj)
        {
            _obj = obj;
        }
        public IActionResult Index()
        {
            var obj=_obj.GetAll();
            return View(obj);
        }
        public IActionResult Create ()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentView model)
        {

            var obj = new Department()
            {
                Name = model.Name,
                Description = model.Description 

            };
           var state= _obj.Add(obj);
            if(state)
            {
                ViewBag.Massage  = "Save Successfully !";
            }
            return RedirectToAction("Index");
        }
       
        public IActionResult Delete(int id)
        {
            var obj=_obj.GetById(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Delete(Department department)
        {
            var obj=_obj.Delete(department);
            return RedirectToAction("Index", "Department");
        }
        public IActionResult EmployeeFind(int id)
        {
           var obj=_obj.EmployeeFind(id);
            
            return View(obj);
        }
    }
}
