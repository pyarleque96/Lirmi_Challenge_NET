using Lirmi.Challenge.WebApp;
using Lirmi.Challenge.WebApp.Agents.API.School;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ISchoolAPIAgent, SchoolAPIAgent>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
