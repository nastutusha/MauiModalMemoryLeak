using MemoryToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace NET8MAUI_Test;

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
		// Configure logging
		builder.Logging.AddDebug ();

		// Ensure UseLeakDetection is called after logging has been configured!
		builder.UseLeakDetection (collectionTarget =>
		{
			// This callback will run any time a leak is detected.
			Application.Current?.MainPage?.DisplayAlert ("💦Leak Detected💦",
				$"❗🧟❗{collectionTarget.Name} is a zombie!", "OK");
		});
#endif

		return builder.Build();
	}
}

