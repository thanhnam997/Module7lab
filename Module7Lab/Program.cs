var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//Add this line to enable serving static files
app.UseStaticFiles();

app.Run();
