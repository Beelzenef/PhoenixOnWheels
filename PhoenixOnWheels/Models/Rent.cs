namespace PhoenixOnWheels.Models
{
    public class Rent : BaseModel
    {
        public Client RentalClient { get; set; }
        public Vehicle RentalVehicle { get; set; }

        public DateTime RentalStart { get; set; }
        public DateTime RentalEnd { get; set; }

        public List<RentExperience> Experiences { get; set; }
    }
}
