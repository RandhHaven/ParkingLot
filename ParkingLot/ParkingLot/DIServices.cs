namespace ParkingNet
{
    using ParkingNet.Services.CarServices;
    using ParkingNet.Services.EmployeeServices;
    using Microsoft.Extensions.DependencyInjection;
    using ParkingLot.Services.Areas.ParkinLot.CarServicesCore;
    using ParkingLot.Services.Areas.ParkinLot.EmployeeServicesCore;
    using ParkingNet.Services.CategoryServices;

    public static class DIServices
    {
        public static void DependenceInjections(IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICarServiceCore, CarServiceCore>();
            services.AddScoped<IEmployeeServiceCore, EmployeeServiceCore>();
        }
    }
}
