using Microsoft.AspNetCore.Mvc;
using Restaurant_booking_application.Models.Service;

namespace Restaurant_booking_application.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        public async Task <IActionResult> Index()
        {
            var result = await _restaurantService.GetRestaurants("A1");

            return View(result);
        }
    }
}
