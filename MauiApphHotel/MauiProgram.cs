using Microsoft.Extensions.Logging;

namespace MauiApphHotel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                    fonts.AddFont("Kalam-light.ttf", "KalamLight");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                    fonts.AddFont("Quicksand-Regular.ttf", "Quicksand");
                    fonts.AddFont("Quicksand-Bold.ttf", "QuicksandBold");
                    fonts.AddFont("Quicksand-light.ttf", "QuicksandLight");
                    fonts.AddFont("Quicksand-Medium.ttf", "QuicksandMedium");
                    fonts.AddFont("Quicksand-Semibold.ttf", "QuicksandSemi");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
