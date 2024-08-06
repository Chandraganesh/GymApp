using GymApp.DAL;
using GymApp.ViewModels;
using GymApp.Views;
using Microsoft.Extensions.Logging;

namespace GymApp;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<GymAppDataBase>();
		builder.Services.AddSingleton<RegistrationViewModel>();
		builder.Services.AddSingleton<MembersViewModel>();
		builder.Services.AddSingleton<HomeViewModel>();

		return builder.Build();
	}
}