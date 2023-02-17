namespace PhoenixOnWheels.Models
{
    public class Vehicle : BaseModel
    {
        public string VehicleName { get; set; }
        public DateTime AcquiringTime { get; set; }
        public double InitialPrice { get; set; }
        public double RentPricePerDay { get; set; }
        public double RentPricePerHour { get; set; }

        // sumatorio de alquileres, ha sido amortizado? 

        public List<Repair> RepairsOnVehicle { get; set; }
    }
}
