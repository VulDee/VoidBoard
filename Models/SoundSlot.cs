namespace VoidBoard.Models;

public class SoundSlot
{
    public int SlotNumber { get; set; }

    public string FilePath { get; set; } = "";

    public float Volume { get; set; } = 100;

    public string Hotkey { get; set; } = "";

    public bool Loop { get; set; }

    public bool Enabled { get; set; } = true;
}
