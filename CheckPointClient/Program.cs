using CheckPointClient;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Supabase;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient regisztrálása
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Supabase konfiguráció
var supabaseUrl = "https://hedjgccxnquyglcgxlmj.supabase.co";
var supabaseKey = "sb_publishable_VYzVEvE2oZSlHxQQP7282A_wLq1cQsy"; // CSAK AZ ANON KULCSOT HASZNÁLD!

var options = new SupabaseOptions
{
    AutoRefreshToken = true,
    AutoConnectRealtime = true
};

// Scoped-ként regisztráljuk a klienst, mert WASM-ban minden fül/felhasználó saját példányt kap
builder.Services.AddScoped(provider => new Supabase.Client(supabaseUrl, supabaseKey, options));

await builder.Build().RunAsync();
