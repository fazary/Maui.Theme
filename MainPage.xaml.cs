namespace Maui.Theme;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        int theme = Settings.Theme switch
        {
            1 => 2,
            _ => 1
        };
        ThemeHelper.ChangeTheme(theme);
    }
}

