using PhoenixOnWheels.Models;

namespace PhoenixOnWheels.Services
{
    public static class MockData
    {
        public static Vehicle Vehicle1 = new()
        {
            Id = Guid.NewGuid(),
            VehicleName = "Vehicle1",
            RentPricePerDay = 10,
            RentPricePerHour = 15,
            InitialPrice = 100,
            AcquiringTime = DateTime.Today
        };

        public static Vehicle Vehicle2 = new()
        {
            Id = Guid.NewGuid(),
            VehicleName = "MotosMotos",
            RentPricePerDay = 10,
            RentPricePerHour = 15,
            InitialPrice = 100,
            AcquiringTime = DateTime.Today
        };

        public static Vehicle Vehicle3 = new()
        {
            Id = Guid.NewGuid(),
            VehicleName = "Motillo",
            RentPricePerDay = 10,
            RentPricePerHour = 15,
            InitialPrice = 100,
            AcquiringTime = DateTime.Today
        };

        public static Client Client1 = new()
        {
            Id = Guid.NewGuid(),
            FirstName = "First",
            LastName = "Lastname",
            PhoneNumber = "999-999-999",
            BlackListed = true,
            RedListed = true
        };

        public static Client Client2 = new()
        {
            Id = Guid.NewGuid(),
            FirstName = "First",
            LastName = "Lastname",
            PhoneNumber = "999-999-999",
            BlackListed = true,
            RedListed = true
        };

        public static Client Client3 = new()
        {
            Id = Guid.NewGuid(),
            FirstName = "First",
            LastName = "Lastname",
            PhoneNumber = "999-999-999",
            BlackListed = true,
            RedListed = true
        };

        public static Rent Rent1 = new()
        {
            Id = Guid.NewGuid(),
            RentalVehicle = Vehicle1,
            RentalClient = Client1,
            RentalStart = DateTime.Today.AddDays(1),
            RentalEnd = DateTime.Today.AddDays(-2)
        };

        public static Rent Rent2 = new()
        {
            Id = Guid.NewGuid(),
            RentalVehicle = Vehicle2,
            RentalClient = Client2,
            RentalStart = DateTime.Today.AddDays(1),
            RentalEnd = DateTime.Today.AddDays(-2)
        };

        public static Rent Rent3 = new()
        {
            Id = Guid.NewGuid(),
            RentalVehicle = Vehicle1,
            RentalClient = Client3,
            RentalStart = DateTime.Today.AddDays(1),
            RentalEnd = DateTime.Today.AddDays(-2)
        };

        public static List<Client> MockClients = new()
        {
            Client1,
            Client2,
            Client3
        };

        public static List<Vehicle> MockVehicles = new()
        {
            Vehicle1,
            Vehicle2,
            Vehicle3
        };

        public static List<Rent> MockRentals = new()
        {
            Rent1,
            Rent2,
            Rent3
        };
    }
}
