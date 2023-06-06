namespace Restaurant_booking_application.Models.Service
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IDbService _dbService;

        public RestaurantService(IDbService dbService)
        {
            _dbService = dbService;
        }

        //public async Task<bool> CreateRestaurant(RestaurantModel restaurant)
        //{

        //}

        public async Task<List<RestaurantModel>> GetRestaurants(string postcode)
        {
            var restaurantList = await _dbService.GetAll<RestaurantModel>("SELECT * FROM restaurant", new { });
            return restaurantList;
        }
        /////////////
    }
}
