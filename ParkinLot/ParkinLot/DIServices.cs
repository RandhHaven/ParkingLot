namespace Estacionamiento
{
    using Estacionamiento.Services.CarServices;
    using Estacionamiento.Services.EmployeeServices;
    using Microsoft.Extensions.DependencyInjection;
    using ParkingLot.Services.Areas.ParkinLot.CarServicesCore;
    using ParkingLot.Services.Areas.ParkinLot.EmployeeServicesCore;

    public static class DIServices
    {
        public static void DependenceInjections(IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ICarServiceCore, CarServiceCore>();
            services.AddScoped<IEmployeeServiceCore, EmployeeServiceCore>();
        }
    }
}
