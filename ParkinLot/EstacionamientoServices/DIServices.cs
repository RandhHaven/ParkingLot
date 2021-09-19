namespace EstacionamientoServices
{
    using EstacionamientoNetCore.CoreService.CarCoreServices;
    using EstacionamientoNetCore.CoreService.EmployeeCoreServices;
    using Microsoft.Extensions.DependencyInjection;

    public static class DIServices
    {
        public static void DependenceInjections(IServiceCollection services)
        {
            services.AddScoped<ICarCoreService, CarCoreService>();
            services.AddScoped<IEmployeeCoreService, EmployeeCoreService>();
        }
    }
}
