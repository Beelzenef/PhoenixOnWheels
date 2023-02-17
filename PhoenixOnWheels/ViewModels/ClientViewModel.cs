using PhoenixOnWheels.Models;
using PhoenixOnWheels.Services;
using System.Collections.ObjectModel;

namespace PhoenixOnWheels.ViewModels
{
    public partial class ClientViewModel : BaseViewModel
    {
        private RentalService _service;

        public ObservableCollection<Client> Client { get; } = new();

        public ClientViewModel(RentalService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));

            Title = "Client history";

            GetAllClients();
        }

        private void GetAllClients()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;

                var client = _service.GetClients();

                if (Client.Count != 0)
                {
                    Client.Clear();
                }

                foreach (var c in client)
                {
                    Client.Add(c);
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
