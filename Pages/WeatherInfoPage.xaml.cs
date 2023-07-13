using MauiWeatherApp.Models.ViewModels;

namespace MauiWeatherApp.Pages;

public partial class WeatherInfoPage : ContentPage
{
	public WeatherInfoPage()
	{
		InitializeComponent();

		BindingContext = new WeatherInfoPageViewModel();
	}
}