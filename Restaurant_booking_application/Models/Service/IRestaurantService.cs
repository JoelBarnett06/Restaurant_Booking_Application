namespace Restaurant_booking_application.Models.Service
{
    public interface IRestaurantService
    {
        //public Task<bool> CreateRestaurant(RestaurantModel restaurant);

        public Task<List<RestaurantModel>> GetRestaurants(string postcode);
    }
}
