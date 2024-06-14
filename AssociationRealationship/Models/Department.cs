using System.ComponentModel.DataAnnotations;

namespace AssociationRealationship.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Display(Name="Department Name")]
        public string? Name { get; set; }
        public string? Description { get; set; }
 
        public virtual List<Employee> Employees { get; set; }
       
    }
}
