namespace Estacionamiento
{
    using ParkingLot.Services.CarServices;
    using ParkingLot.Services.EmployeeServices;
    using Microsoft.Extensions.DependencyInjection;
    using ParkingLot.Services.Areas.ParkinLot.CarServicesCore;
    using ParkingLot.Services.Areas.ParkinLot.EmployeeServicesCore;
    using ParkingLot.Services.CategoryServices;

    public static class DIServices
    {
        public static void DependenceInjections(IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ICarServiceCore, CarServiceCore>();
            services.AddScoped<IEmployeeServiceCore, EmployeeServiceCore>();

            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
