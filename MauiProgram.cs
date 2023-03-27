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

    public static MauiAppBuilder RegisterViewsAndViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        //Pages
        mauiAppBuilder.Services.AddSingleton(typeof(Views.ExercisesPage));
        mauiAppBuilder.Services.AddTransient(typeof(Views.HistoryPage));
        mauiAppBuilder.Services.AddSingleton(typeof(Views.LogWorkoutPage));
        //mauiAppBuilder.Services.AddTransient(typeof(Views.ScorePage));

        //Services
        mauiAppBuilder.Services.AddSingleton(typeof(ViewModels.ExercisesPageViewModel));
        mauiAppBuilder.Services.AddTransient(typeof(ViewModels.HistoryPageViewModel));
        mauiAppBuilder.Services.AddSingleton(typeof(ViewModels.LogWorkoutPageViewModel));
        //mauiAppBuilder.Services.AddTransient(typeof(ViewModels.ScorePageViewModel));


        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<IDatabaseService, HardcodedDatabaseService>();

        return mauiAppBuilder;
    }
}
