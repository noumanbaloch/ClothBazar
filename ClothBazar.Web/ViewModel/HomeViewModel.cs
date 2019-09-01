using ClothBazar.Entites;
using System.Collections.Generic;

namespace ClothBazar.Web.ViewModel
{
    public class HomeViewModel
    {
        public List<Category> categories { get; set; }
        public List<Product> products { get; set; }
    }
}