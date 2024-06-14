using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace AssociationRealationship.ModelsView
{
    public class EmployeeView
    {
      
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [Display(Name="Department")]
        public int DepartmentId { get; set; }
        public List<SelectListItem> Departments { get; set; }
    }
}
