using CustomControl.Controls;
using CustomControl.Handlers;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace CustomControl;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureMauiHandlers(handlers => {
#if ANDROID
				handlers.AddHandler<CustomCounterButton, CustomCounterButtonHandlerAndroid>();
#endif
#if IOS
				handlers.AddHandler<CustomCounterButton, CustomCounterButtonHandler_ios>();
#endif
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}