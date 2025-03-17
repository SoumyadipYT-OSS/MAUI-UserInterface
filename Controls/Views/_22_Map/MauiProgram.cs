using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Maps;

namespace _22_Map;

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
			})
			.UseMauiMaps();  // API integration

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
