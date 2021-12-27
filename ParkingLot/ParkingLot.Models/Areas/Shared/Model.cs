namespace ParkingLot.Models.Areas.Shared
{
    public interface IModel
    {
        long ID { get; set; }

        void Initialize();
    }

    public abstract class Model : IModel
    {
        protected Model() { }

        public virtual long ID { get; set; }

        public virtual void Initialize() { }
    }
}