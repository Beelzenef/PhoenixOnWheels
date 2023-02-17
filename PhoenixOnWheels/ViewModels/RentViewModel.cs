using PhoenixOnWheels.Models;
using PhoenixOnWheels.Services;
using System.Collections.ObjectModel;

namespace PhoenixOnWheels.ViewModels
{
    public partial class RentViewModel : BaseViewModel
    {
        private RentalService _service;

        public ObservableCollection<Rent> Rentals { get; } = new();

        public RentViewModel(RentalService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));

            Title = "Rentals";

            GetAllRentals();
        }

        private void GetAllRentals()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;

                var rentals = _service.GetRentals();

                if (Rentals.Count != 0)
                {
                    Rentals.Clear();
                }

                foreach (var r in rentals)
                {
                    Rentals.Add(r);
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
