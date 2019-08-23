using System.Collections.Generic;

namespace ClothBazar.Entites
{
    public class Category : BaseEntity
    {
        public List<Product> Products { get; set; }
    }
}
