using AssociationRealationship.ModelsView;
using AssociationRealationship.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssociationRealationship.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            this.teacherService = teacherService;
        }
        public IActionResult Index()
        {
            var model=teacherService.GetAll();
            return View(model);
        }
        public IActionResult Create() {
            var model = new TeacherView();
            model.Duets=teacherService.GetAll().Select(c=>new SelectListItem
            {
                Value=c.Id.ToString(),
                Text=c.Description
            }).ToList();
        return View(model);
        }
    }
}
