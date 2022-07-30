using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using blazorstate;
using blazorstate.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSettingsProvider();
await builder.Build().RunAsync();
