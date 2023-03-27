using CourseworkApp.Services;

namespace CourseworkApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		//var apiQuoteService = new Services.APIQuoteService();
		APIQuoteService.GetQuotesFromAPI();
    }
}
