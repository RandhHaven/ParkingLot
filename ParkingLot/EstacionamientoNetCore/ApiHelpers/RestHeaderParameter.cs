namespace ParkingLot.Core.ApiHelpers
{
    public class RestHeaderParameter
    {
        public string SenderCountry { get; set; }
        public string RequestId { get; set; }
        public string SystemId { get; set; }
        public string UserId { get; set; }

        public void Validate()
        {
            ObjectNullChecker.Check(this.SenderCountry, nameof(this.SenderCountry));
            ObjectNullChecker.Check(this.RequestId, nameof(this.RequestId));
        }
    }
}
