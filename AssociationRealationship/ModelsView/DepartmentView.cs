using System.ComponentModel.DataAnnotations;

namespace AssociationRealationship.ModelsView
{
    public class DepartmentView
    {
        public int Id { get; set; }
       
        [Required]
        [Display(Name="Department Name")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
