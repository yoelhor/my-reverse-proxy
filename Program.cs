var builder = WebApplication.CreateBuilder(args);

// Add the reverse proxy services to the container
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

// Configure the HTTP request pipeline for the reverse proxy
app.MapReverseProxy();

app.Run();
