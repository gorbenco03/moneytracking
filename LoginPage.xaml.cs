namespace FirstApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
      
	}

   

    private void Button_Clicked(object sender, EventArgs e)
    {
        string UserName = myUserName.Text;
        string Password = myPassword.Text;
        if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
        {
            // Redirecționare către NewPage1.xaml
            Application.Current.MainPage = new NewPage1();
        }
    }
}