var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Himanshu Kumar!");
app.MapGet("/mypage", () => "My Page!");
app.Run();
