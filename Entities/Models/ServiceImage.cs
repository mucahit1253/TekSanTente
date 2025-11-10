namespace Entities.Models
{
    public class ServiceImage
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int MediaId { get; set; }
        public Service Service { get; set; }
        public Media Media { get; set; }
    }
}

