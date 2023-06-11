using NetCoreApps.Controllers;
using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<HomeController>();
var app = builder.Build();
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("MiddleWare 1");
    await next();
});
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 2");
    await next();
});
app.UseRouting();
app.UseEndpoints(endpoints =>endpoints.MapControllers());
app.Run();
