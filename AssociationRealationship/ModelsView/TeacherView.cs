using AssociationRealationship.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace AssociationRealationship.ModelsView
{
    public class TeacherView
    {
      
        [Required]
        public String Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display (Name= "Hostel Name")]
        public int? DuetId { get; set; }
        public List<SelectListItem>Duets { get; set; }
       

    }
}
