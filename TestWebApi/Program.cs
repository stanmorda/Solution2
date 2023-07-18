using TestWebApi.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.UseLogUrls();

// app.UseRouting();
// app.UseEndpoints(endPoints =>
// {
//     endPoints.MapGet("/hello", async context => await context.Response.WriteAsync("hello!"));
// });

app.MapGet("/hello", async context =>
{
    
    await context.Response.WriteAsync("map1");
    
    await context.Response.WriteAsync("map2");
    
});

//app.MapGet("/hello", async context => await context.Response.WriteAsync("map2"));

//app.MapPost("/hello123", async context => await context.Response.WriteAsync("map1"));

app.Run();

