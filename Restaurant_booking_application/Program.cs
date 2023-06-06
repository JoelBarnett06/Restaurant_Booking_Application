using Dapper;
using Restaurant_booking_application.Models;
using Restaurant_booking_application.Models.Service;

var builder = WebApplication.CreateBuilder(args);
{
    DefaultTypeMap.MatchNamesWithUnderscores = true;

    // Add services to the container.
    builder.Services.AddControllersWithViews();
    builder.Services.AddScoped<DbService, DbService>();
    builder.Services.AddScoped<IDbService, DbService>();
    builder.Services.AddScoped<IRestaurantService, RestaurantService>();
    builder.Services.AddScoped<RestaurantService, RestaurantService>();
}

var app = builder.Build();
{
    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Restaurant}/{action=Index}/{id?}");
}
app.Run();
