using DataAccess.Data;
using DataAccess.DBAccess;
using MascotasBackendApi;

var builder = WebApplication.CreateBuilder(args);

var myAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins
        , policy =>
        {
            policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
        });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<IPetData, PetData>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapGet("/", () => Results.Redirect("/swagger/index.html"));
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader());
app.UseCors(myAllowSpecificOrigins);
app.ConfigureApi();

app.Run();
