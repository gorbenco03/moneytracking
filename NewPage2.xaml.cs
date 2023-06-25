namespace FirstApp;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
        signInButton.Clicked += SignInButton_Clicked;
	}
    private void SignInButton_Clicked(object sender, EventArgs e)
    {
        string userName = entryUserName.Text;

        if (string.IsNullOrWhiteSpace(userName))
        {
            // Afiseaza o alerta daca textul este gol sau contine doar spatii albe
            DisplayAlert("Error", "Please enter a valid user name", "OK");
        }
        else
        {
            // Redirectionează la pagina principală (MainPage)
            Application.Current.MainPage = new NewPage1();
        }
    }

}