namespace Maui.Theme;

internal static class Settings
{
    public static int Theme
    {
        get => Preferences.Get(nameof(Theme), HasDefaultTheme ? 0 : 1);
        set => Preferences.Set(nameof(Theme), value);
    }
    private static bool HasDefaultTheme
    {
        get
        {
            var minDefaultVersion = new Version(10, 0);
            if (DeviceInfo.Platform == DevicePlatform.iOS)
                minDefaultVersion = new Version(13, 0);

            return DeviceInfo.Version >= minDefaultVersion;
        }
    }
}