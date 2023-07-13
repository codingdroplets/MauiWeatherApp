using MauiWeatherApp.Pages;

namespace MauiWeatherApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new WeatherInfoPage();
	}
}
