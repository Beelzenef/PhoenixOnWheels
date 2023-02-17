
using PhoenixOnWheels.Services;
using PhoenixOnWheels.ViewModels;
using PhoenixOnWheels.Views;

namespace PhoenixOnWheels;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<VehicleViewModel>();
		builder.Services.AddSingleton<VehiclePage>();

		builder.Services.AddSingleton<RentalService>();

		return builder.Build();
	}
}
