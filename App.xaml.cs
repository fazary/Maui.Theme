namespace Maui.Theme;

public partial class App : Application
{
    public App()
    {
        ThemeHelper.SetTheme();
        InitializeComponent();

        MainPage = new AppShell();
    }
}
