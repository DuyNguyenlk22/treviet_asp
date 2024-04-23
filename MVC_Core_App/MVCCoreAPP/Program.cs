using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
var app = builder.Build();


//Routes collection 
//app.UseMvc(routes =>
//{
//routes.MapRoute(name: "secure", template: "secure", defaults: new
//{
//    Controller = "Admin",
//    Action = "Index"
//});
//routes.MapRoute("default", "{controller=Home}/{action=Index}/{id:int?}");
//routes.MapRoute("default", "{controller=Home}/{action=Index}/{id:int:minlength(3)?}"); // route constraints
//});
app.UseMvc();
app.Run(handler: async (context) =>
{
    await context.Response.WriteAsync("Failed to find route");
});

app.Run();