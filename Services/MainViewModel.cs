using System.Collections.ObjectModel;
using VoidBoard.Models;

namespace VoidBoard.ViewModels;

public class MainViewModel
{
    public ObservableCollection<SoundSlot> Slots { get; set; } = [];

    public SettingsModel Settings { get; set; } = new();

    public MainViewModel()
    {
        // makes 10 slots

        for (int i = 0; i < 10; i++)
        {
            Slots.Add(new SoundSlot
            {
                SlotNumber = i
            });
        }
    }
}
