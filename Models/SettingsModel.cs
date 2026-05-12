namespace VoidBoard.Models;

public class SettingsModel
{
    public string Theme { get; set; } = "system";

    public bool MonitorPlayback { get; set; } = true;

    public string InputDevice { get; set; } = "";

    public string OutputDevice { get; set; } = "";

    public bool StartHidden { get; set; }

    public bool MinimizeToTray { get; set; } = true;
}
