using Microsoft.EntityFrameworkCore;
using TripTracker.API.Extensions;
using TripTracker.DataAccess;
using TripTracker.BusinessLogic;

using TripTracker.BusinessLogic.Services;
using TripTracker.DataAccess.Context;
using Microsoft.OpenApi.Models;
using TripTracker.API.Helpers;

var builder = WebApplication.CreateBuilder(args);

var ConnectionString = builder.Configuration.GetConnectionString("TTCON");

// Add services to the container.


builder.Services.AddDbContext<db33063Context>(option => option.UseSqlServer(ConnectionString));

builder.Services.AddHttpContextAccessor();
builder.Services.DataAccess(ConnectionString);
builder.Services.BusinessLogic();

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(typeof(MappingProfileExtensions));
});

// ? Agregar CORS ANTES de `var app = builder.Build();`
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});


builder.Services.AddSwaggerGen(c => {

    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });

    // Configuración de ApiKey
    c.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        Description = "Ingrese la ApiKey en el encabezado 'X-Api-Key'",
        Type = SecuritySchemeType.ApiKey,
        Name = "X-Api-Key",
        In = ParameterLocation.Header,
        Scheme = "ApiKeyScheme"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "ApiKey"
                }
            },
            new string[] {}
        }
    });

});

builder.Services.AddSingleton<ApiKeyAuthorizationFilter>();
builder.Services.AddSingleton<IApiKeyValidator, ApiKeyValidator>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// ? Habilitar CORS ANTES de `UseAuthorization()`
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
