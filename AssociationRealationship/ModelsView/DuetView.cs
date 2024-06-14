using System.ComponentModel.DataAnnotations;

namespace AssociationRealationship.ModelsView
{
    public class DuetView
    {
      
        [Required]
        [Display(Name="Hostel Name")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int Code { get; set; }

    }
}
