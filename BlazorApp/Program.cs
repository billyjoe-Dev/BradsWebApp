using Majorsoft.Blazor.Components.Common.JsInterop;
using Majorsoft.Blazor.Components.Common.JsInterop.Scroll;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PortfolioWebsite.Client;

namespace MyApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //Register dependencies
            builder.Services.AddJsInteropExtensions();
            builder.Services.AddScoped<IScrollHandler, ScrollHandler>();
            //builder.Services.AddScoped<IJSRuntime, JSRuntime>();

            await builder.Build().RunAsync();
        }
    }
}
