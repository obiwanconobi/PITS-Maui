namespace PITS_MAUI.Pages;

public partial class ApiSetup : ContentPage
{
	public ApiSetup()
	{
		InitializeComponent();
	}

	void SetApiUrlButtonClicked(object sender, EventArgs args)
	{
		Preferences.Set("ApiUrl", ApiUrlEntry.Text);
		Navigation.PopAsync();
		Navigation.PushAsync(new MainPage());
	}
}