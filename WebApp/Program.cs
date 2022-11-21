using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebApp;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://PyExpertiseApi2.victorfalkensko.repl.co"), Timeout = TimeSpan.FromMinutes(60) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://127.0.0.1:5000/"), Timeout = TimeSpan.FromMinutes(10) });
builder.Services.AddMudServices();

await builder.Build().RunAsync();
