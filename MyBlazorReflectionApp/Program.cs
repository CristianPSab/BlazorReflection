using MyBlazorReflectionApp.Components;
using log4net.Config;
using log4net;

var builder = WebApplication.CreateBuilder(args);

var entryAssembly = System.Reflection.Assembly.GetEntryAssembly();
if (entryAssembly != null)
{
    var logRepository = LogManager.GetRepository(entryAssembly);
    XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
}

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
