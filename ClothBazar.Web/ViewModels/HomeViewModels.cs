using ClothBazar.Entites;
using System.Collections.Generic;

namespace ClothBazar.Web.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> FeaturedCategories { get; set; }
        public List<Product> FeaturedProducts { get; set; }
    }
}