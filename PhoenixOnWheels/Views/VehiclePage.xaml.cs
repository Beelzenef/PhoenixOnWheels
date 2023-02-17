using PhoenixOnWheels.ViewModels;

namespace PhoenixOnWheels.Views;

public partial class VehiclePage : ContentPage
{

	public VehiclePage(VehicleViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}

