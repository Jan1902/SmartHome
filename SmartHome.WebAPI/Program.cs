var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.WebHost.UseUrls("http://*:80", "https://*:443");

builder.WebHost.UseKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(80);
    /* serverOptions.ListenAnyIP(443, listenOptions =>
    {
        listenOptions.UseHttps("certificate.pfx", "12345678");
    }); */
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
