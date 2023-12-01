namespace Maui.Theme;

internal static class ThemeHelper
{
    public static void SetTheme()
    {
        Application.Current!.UserAppTheme = Settings.Theme switch
        {
            0 => AppTheme.Unspecified,
            2 => AppTheme.Dark,
            _ => AppTheme.Light
        };
    }
    public static void ChangeTheme(int theme)
    {
        Settings.Theme = theme;

        SetTheme();
    }
}