using Microsoft.Extensions.Logging;

namespace Spide_Tech_App
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
                });

            //register httpclient and apiservice
            builder.Services.AddHttpClient<UserService>();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            // builder.Build().Run.hardwareAccelerated();
           // builder.Services.AddHttpClient();
            return builder.Build();
        }
    }
}
