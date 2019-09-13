using System.Collections.Generic;

namespace ClothBazar.Entites
{
    public class Category : BaseEntity
    {
        public bool isFeatured;

        public string ImageURL { get; set; }
        public List<Product> Products { get; set; }
        public bool IsFeatured { get; set; }
    }
}
