using ClothBazar.Entites;
using System.Collections.Generic;

namespace ClothBazar.Web.ViewModels
{
    public class CheckoutViewModel
    {
        public List<Product> CartProducts { get; set; }

        public List<int> CartProductIDs { get; set; }
    }
}