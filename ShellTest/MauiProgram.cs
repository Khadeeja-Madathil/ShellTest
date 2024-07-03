
using Microsoft.Extensions.Logging;

namespace ShellTest;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();

#if DEBUG
        builder.Logging.AddDebug();
#endif
#if IOS
        AVFoundation.AVAudioSession.SharedInstance().SetActive(true);
        AVFoundation.AVAudioSession.SharedInstance().SetCategory(AVFoundation.AVAudioSessionCategory.Playback);
#endif
        return builder.Build();
    }
}