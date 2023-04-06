using CourseworkApp.Services;
using Microsoft.Extensions.Logging;
using CourseworkApp.Interfaces;
using CourseworkApp.Models;

namespace CourseworkApp;

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
			.RegisterServices()
            .RegisterViewsAndViewModels();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

    // Registering views & viewmodels
    public static MauiAppBuilder RegisterViewsAndViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        // Views
        mauiAppBuilder.Services.AddSingleton(typeof(Views.ExercisesPage));
        mauiAppBuilder.Services.AddTransient(typeof(Views.HistoryPage));
        mauiAppBuilder.Services.AddSingleton(typeof(Views.LogWorkoutPage));
        mauiAppBuilder.Services.AddSingleton(typeof(Views.ScorePage));

        // ViewModels
        mauiAppBuilder.Services.AddSingleton(typeof(ViewModels.ExercisesPageViewModel));
        mauiAppBuilder.Services.AddTransient(typeof(ViewModels.HistoryPageViewModel));
        mauiAppBuilder.Services.AddSingleton(typeof(ViewModels.LogWorkoutPageViewModel));
        mauiAppBuilder.Services.AddSingleton(typeof(ViewModels.ScorePageViewModel));


        return mauiAppBuilder;
    }

    // Registering services
    public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<IDatabaseService, HardcodedDatabaseService>();

        return mauiAppBuilder;
    }
}
