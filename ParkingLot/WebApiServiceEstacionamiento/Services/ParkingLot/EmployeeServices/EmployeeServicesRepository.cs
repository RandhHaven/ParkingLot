namespace WebApiServiceEstacionamiento.Services.ParkingLot.EmployeeServices
{
    using WebApiServiceEstacionamiento.Models.Parking;
    using WebApiServiceEstacionamiento.ParkingLotModel;
    using WebApiServiceEstacionamiento.Services.GenericRepository;

    public class EmployeeServicesRepository : Repository<Employee>, IEmployeeServicesRepository
    {
        public EmployeeServicesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public override void Update(Employee entity)
        {
            base.Update(entity);
        }
    }
}