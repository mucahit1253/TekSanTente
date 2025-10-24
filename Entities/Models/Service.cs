namespace Entities.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }  // null = ana menü
        public Service? Parent { get; set; }   // navigation property
        public ICollection<Service>? Children { get; set; }  // alt menüler
        public ICollection<ServiceImage> Images { get; set; }
    }
}
