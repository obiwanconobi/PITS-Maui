using Microsoft.Maui.Controls;
using PITS_MAUI.Model;
using PITS_MAUI.Services;

namespace PITS_MAUI.Pages;

public partial class DevicePage : ContentPage
{

    public List<Scripts> _scripts;
	public DevicePage(Devices device)
	{
        InitializeComponent();
        GetScriptsForDeviceTypeService service = new GetScriptsForDeviceTypeService();
        var jwt = new GenerateJwtToken();
        _scripts = service.GetDataFromApi(Preferences.Get("ApiUrl", "error"), jwt.Generate(), device.machineType).Result;

        ScriptsCollectionView.ItemsSource = _scripts;
	}
}