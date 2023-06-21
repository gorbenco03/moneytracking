namespace FirstApp;

public partial class App : Application
{
	public App()
	{
        var tabbedPage = new TabbedPage();
        tabbedPage.BarBackgroundColor = Color.FromArgb("#00BF20");
        tabbedPage.Children.Add(new MainPage());
        tabbedPage.Children.Add(new EmptyPage());
        tabbedPage.Children.Add(new ContactPage());
        MainPage = tabbedPage;

    }
}
