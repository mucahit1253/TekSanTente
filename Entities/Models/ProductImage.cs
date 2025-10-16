﻿namespace Entities.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int MediaId { get; set; }
        public bool IsMain { get; set; }
        public int DisplayOrder { get; set; }
        public Product Product { get; set; }
        public Media Media { get; set; }

    }
}
