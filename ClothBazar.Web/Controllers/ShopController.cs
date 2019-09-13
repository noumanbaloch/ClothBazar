using ClothBazar.Services;
using ClothBazar.Web.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class ShopController : Controller
    {
        //ProductsService productsService = new ProductsService();
        // GET: Shop
        public ActionResult Checkout()
        {
            CheckoutViewModel model = new CheckoutViewModel();
            var cartProductsCookie = Request.Cookies["CartProducts"];
            if (cartProductsCookie != null)
            {
                model.CartProductIDs = cartProductsCookie.Value.Split('-').Select(x => int.Parse(x)).ToList();
                model.CartProducts = ProductsService.Instance.GetProducts(model.CartProductIDs);

            }



            return View(model);
        }
    }
};