using PhoenixOnWheels.Models;
using PhoenixOnWheels.Services;
using System.Collections.ObjectModel;

namespace PhoenixOnWheels.ViewModels
{
    public partial class VehicleViewModel : BaseViewModel
    {
        private RentalService _service;

        public ObservableCollection<Vehicle> Vehicles { get; } = new();

        public VehicleViewModel(RentalService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));

            Title = "Vehicles available";

            GetAllVehicles();
        }

        private void GetAllVehicles()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;

                var vehicles = _service.GetVehicles();

                if (Vehicles.Count != 0)
                {
                    Vehicles.Clear();
                }

                foreach (var v in vehicles)
                {
                    Vehicles.Add(v);
                }
            }
            catch
            {

            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
