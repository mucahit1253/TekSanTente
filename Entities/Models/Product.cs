using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        [Required(ErrorMessage = "Ürün adı gereklidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Slug adı gereklidir.")]
        public string Slug { get; set; }
        public decimal? Price { get; set; }
        public string? Comment { get; set; }
        public Category? Category { get; set; }
        public ICollection<ProductImage> Images { get; set; }
    }
}
