using CourseworkApp.Services;

namespace CourseworkApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		// Fetching quotes from API during startup of the app
		APIQuoteService.GetQuotesFromAPI();
    }
}
