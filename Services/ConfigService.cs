using Newtonsoft.Json;
using VoidBoard.Models;

namespace VoidBoard.Services;

public class ConfigService
{
    private const string ConfigPath = "config.json";

    public ConfigData Load()
    {
        if (!File.Exists(ConfigPath))
        {
            return new ConfigData();
        }

        var json = File.ReadAllText(ConfigPath);

        return JsonConvert.DeserializeObject<ConfigData>(json)
               ?? new ConfigData();
    }

    public void Save(ConfigData config)
    {
        var json = JsonConvert.SerializeObject(config, Formatting.Indented);

        File.WriteAllText(ConfigPath, json);
    }
}

public class ConfigData
{
    public List<SoundSlot> Slots { get; set; } = [];

    public SettingsModel Settings { get; set; } = new();
}
