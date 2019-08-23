namespace ClothBazar.Entites
{
    public class Product : BaseEntity
    {
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}
