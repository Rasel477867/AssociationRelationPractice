namespace AssociationRealationship.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Duet Duet { get; set; }
        public int DuetId {  get; set; }
    }
}