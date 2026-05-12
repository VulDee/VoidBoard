using NHotkey;
using NHotkey.Wpf;

namespace VoidBoard.Services;

public class HotkeyService
{
    // registers capslock + num hotkeys later

    public void RegisterHotkey(
        string name,
        System.Windows.Input.Key key,
        EventHandler<HotkeyEventArgs> action)
    {
        try
        {
            HotkeyManager.Current.AddOrReplace(
                name,
                key,
                System.Windows.Input.ModifierKeys.None,
                action
            );
        }
        catch
        {

        }
    }

    public void RemoveHotkey(string name)
    {
        try
        {
            HotkeyManager.Current.Remove(name);
        }
        catch
        {

        }
    }
}
