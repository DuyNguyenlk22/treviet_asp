using DISample.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
        builder.Services.AddTransient<IProductService, ProductServices>(); // cơ chế điều khiển vòng đời DI
        var app = builder.Build();
        app.UseMvcWithDefaultRoute();

        app.Run();
    }
}