using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.Logging;
using GardenApp.Data;

namespace GardenApp
{
 
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>();

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            // Register application services
            builder.Services.AddSingleton<ProductService>();
            builder.Services.AddSingleton<CartService>();

            return builder.Build();
        }
    }
}