using PhoenixOnWheels.Models;

namespace PhoenixOnWheels.Services
{
    public class RentalService
    {

        public List<Vehicle> GetVehicles()
        {
            return MockData.MockVehicles;
        }

        public List<Client> GetClients()
        {
            return MockData.MockClients;
        }

        public List<Rent> GetRentals()
        {
            return MockData.MockRentals;
        }
    }
}
