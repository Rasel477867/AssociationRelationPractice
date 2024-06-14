using AssociationRealationship.Models;
using AssociationRealationship.ModelsView;
using AssociationRealationship.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssociationRealationship.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _obj;
        private readonly IDepartmentService _objDepartment;
        public EmployeeController(IEmployeeService obj, IDepartmentService objDepartment)
        {
            _obj = obj;
            _objDepartment = objDepartment;

        }
        public IActionResult Index()
        {
           var model=_obj.GetAll(); 
            return View(model);
        }
        public IActionResult Create()
        {
            var model = new EmployeeView();
            model.Departments = _objDepartment.GetAll().Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Description
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(EmployeeView obj) {
            var model = new Employee()
            {
                Name = obj.Name,
                DepartmentId = obj.DepartmentId,
                Email = obj.Email,
                City= obj.City,
                Phone= obj.Phone

            };
            var state = _obj.Add(model);
            return RedirectToAction("Index");
        
        }
        public IActionResult GetEmployee(int departmentId)
        {
            var obj = _obj.GetEmployee(departmentId);
            return Json(obj);
        }
        public IActionResult DepartmentEmployee()
        {
            var model = new DepartmentEmployee();
            model.Departments = _objDepartment.GetAll().Select(c => new SelectListItem
            {
                Text = c.Description,
                Value = c.Id.ToString()
            }).ToList();
            return View(model);
        }
    }
}
