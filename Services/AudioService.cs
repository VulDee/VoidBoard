using NAudio.Wave;

namespace VoidBoard.Services;

public class AudioService
{
    private readonly List<WaveOutEvent> activeOutputs = [];

    // plays mp3

    public void Play(string path, float volume = 1f)
    {
        if (!File.Exists(path))
            return;

        var reader = new AudioFileReader(path)
        {
            Volume = volume
        };

        var output = new WaveOutEvent();

        output.Init(reader);

        output.PlaybackStopped += (s, e) =>
        {
            output.Dispose();
            reader.Dispose();

            activeOutputs.Remove(output);
        };

        activeOutputs.Add(output);

        output.Play();
    }

    // stops everything

    public void StopAll()
    {
        foreach (var output in activeOutputs)
        {
            output.Stop();
            output.Dispose();
        }

        activeOutputs.Clear();
    }
}
