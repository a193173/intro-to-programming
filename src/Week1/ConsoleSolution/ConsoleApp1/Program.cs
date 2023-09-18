var builder = WebApplication.CreateBuilder(args);


string message = "Welcome to Class;";

DateTime now = DateTime.Now;

string finalMessage = $"The Message {message} and it is now {now:T}";

var app = builder.Build();

app.MapGet("/message", () =>
{
    return Results.Ok(finalMessage);
});

app.Run();