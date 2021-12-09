namespace EstacionamientoServices
{
    using Microsoft.Extensions.DependencyInjection;
    using ParkingLot.Core.CoreService.CarCoreServices;
    using ParkingLot.Core.CoreService.EmployeeCoreServices;

    public static class DIServices
    {
        public static void DependenceInjections(IServiceCollection services)
        {
            services.AddScoped<ICarCoreService, CarCoreService>();
            services.AddScoped<IEmployeeCoreService, EmployeeCoreService>();
        }
    }
}
