namespace Entities.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public ICollection<ServiceImage> Images { get; set; }
    }
}
