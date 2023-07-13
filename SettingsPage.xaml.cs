namespace FirstApp;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
        InitializeComponent();
    }

    private void LogOut_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new LoginPage();
    }
}
