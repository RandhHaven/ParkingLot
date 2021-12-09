namespace WebApiServiceEstacionamiento.ParkingLotModel
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using WebApiServiceEstacionamiento.Models.Parking;
    using WebApiServiceEstacionamiento.Models.Controls;
    using WebApiServiceEstacionamiento.Models.Admin;

    public partial class DatabaseContext : DbContext
    {
        #region Properties
        private readonly IConfiguration _configuration;
        #endregion

        #region Tables
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<DocumentTypes> DocumentTypes { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ModelCar> ModelCar { get; set; }
        public virtual DbSet<BrandCar> BrandCar { get; set; }
        #endregion

        #region Builds
        public DatabaseContext(DbContextOptions<DatabaseContext> options,
            IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
              .Property(e => e.CarId);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("AppConnection"));
            }
        }

        #endregion
    }
}
