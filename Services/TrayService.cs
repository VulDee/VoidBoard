using Hardcodet.Wpf.TaskbarNotification;
using System.Windows;

namespace VoidBoard.Services;

public class TrayService
{
    private TaskbarIcon? trayIcon;

    // tray icon

    public void Setup(Window window)
    {
        trayIcon = new TaskbarIcon();

        trayIcon.ToolTipText = "VoidBoard";

        trayIcon.TrayLeftMouseDown += (s, e) =>
        {
            window.Show();
            window.WindowState = WindowState.Normal;
            window.Activate();
        };
    }

    public void Dispose()
    {
        trayIcon?.Dispose();
    }
}
