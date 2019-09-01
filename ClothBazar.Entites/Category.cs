using System.Collections.Generic;

namespace ClothBazar.Entites
{
    public class Category : BaseEntity
    {
        public string ImageURL { get; set; }
        public List<Product> Products { get; set; }
    }
}
