using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using PITS_MAUI.Model;
using PITS_MAUI.Pages;
using PITS_MAUI.Services;

namespace PITS_MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;
	public List<Devices> _devices;
	Devices selectedDevice;
	string ApiUrl;
	public MainPage()
	{
		

		if(Preferences.Get("ApiUrl", "error") == "error")
		{
            
			SetupApi();
		}
		else
		{
			ApiUrl = Preferences.Get("ApiUrl", "error");
            
            GetDevicesService service = new GetDevicesService();
            var jwt = new GenerateJwtToken();
            _devices = service.GetDataFromApi(ApiUrl, jwt.Generate()).Result;
            InitializeComponent();
            DevicesCollectionView.ItemsSource = _devices;
            
        }
        
    
	}

	private void SetupApi()
	{
		Navigation.PopAsync();
		Navigation.PushAsync(new ApiSetup());
      
    }

    private async void OnItemClicked(object sender, SelectionChangedEventArgs e)
    {
		Devices device = DevicesCollectionView.SelectedItem as Devices;
		await Navigation.PushAsync(new DevicePage(device));
        //App.Current.MainPage = new NavigationPage(new DevicePage(device));
    }

}

