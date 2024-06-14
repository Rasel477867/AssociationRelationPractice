namespace AssociationRealationship.Models
{
    public class Duet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int  Code { get; set; }
        public List<Teacher> Teachers { get; set; }
        
    }
}
