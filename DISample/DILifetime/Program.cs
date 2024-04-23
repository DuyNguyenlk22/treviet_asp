using DILifetime.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
builder.Services.AddTransient<ITransientService, SomeService>();
// nếu yêu cầu kiểu ITransient thì trả về SomeService
builder.Services.AddScoped<IScopeService, SomeService>();
// nếu yêu cầu 2 lần củng chỉ trả về cùng 1 instance
builder.Services.AddSingleton<ISingletonService, SomeService>();
// instance chỉ sinh ra 1 lần duy nhất

var app = builder.Build();
app.UseMvcWithDefaultRoute();


app.MapGet("/", () => "Hello World!");

app.Run();
