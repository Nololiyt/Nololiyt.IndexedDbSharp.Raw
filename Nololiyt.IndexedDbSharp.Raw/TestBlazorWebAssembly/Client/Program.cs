using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Nololiyt.IndexedDbSharp.Raw.CSharp;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Extensions;
using TestBlazorWebAssembly;

namespace TestBlazorWebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddIndexedDbSharpRaw();

            await builder.Build().RunAsync();
        }
    }
}