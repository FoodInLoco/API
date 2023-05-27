using FoodInLoco.Application;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Repositories;
using FoodInLoco.Application.Repositories.Interfaces;
using FoodInLoco.Application.Extensions;
using FoodInLoco.Application.Factories;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Helpers;
using FoodInLoco.Application.Helpers.Interfaces;
using FoodInLoco.Application.Services;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.AspNetCore.Http.Json;
using FoodInLoco.Application.Converters;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog();

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.Converters.Add(new DateOnlyConverter());
    options.SerializerOptions.Converters.Add(new TimeOnlyConverter());
});

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {{
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" },
            Scheme = "oauth2", Name = "Bearer", In = ParameterLocation.Header,
        },
        new List<string>()
    }});
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Settings.Secret)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddResponseCompression();

builder.Services.AddCors();

builder.Services.AddContext<Context>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DbConnection")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
builder.Services.AddScoped(typeof(ICommandRepository<>), typeof(EFCommandRepository<>));
builder.Services.AddScoped(typeof(IQueryRepository<>), typeof(EFQueryRepository<>));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRestaurantService, RestaurantService>();
builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<IMenuItemService, MenuItemService>();
builder.Services.AddScoped<IAttractionService, AttractionService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<ITableService, TableService>();
builder.Services.AddScoped<IBillService, BillService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();
builder.Services.AddScoped<IMenuRepository, MenuRepository>();
builder.Services.AddScoped<IMenuItemRepository, MenuItemRepository>();
builder.Services.AddScoped<IAttractionRepository, AttractionRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ITableRepository, TableRepository>();
builder.Services.AddScoped<IBillRepository, BillRepository>();

builder.Services.AddScoped<IUserFactory, UserFactory>();
builder.Services.AddScoped<IRestaurantFactory, RestaurantFactory>();
builder.Services.AddScoped<IMenuFactory, MenuFactory>();
builder.Services.AddScoped<IMenuItemFactory, MenuItemFactory>();
builder.Services.AddScoped<IAttractionFactory, AttractionFactory>();
builder.Services.AddScoped<IReservationFactory, ReservationFactory>();
builder.Services.AddScoped<IReviewFactory, ReviewFactory>();
builder.Services.AddScoped<IOrderFactory, OrderFactory>();
builder.Services.AddScoped<ITableFactory, TableFactory>();
builder.Services.AddScoped<IBillFactory, BillFactory>();

builder.Services.AddSingleton<IHashService, HashService>();
var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);

//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.EnablePersistAuthorization();
    options.EnableDeepLinking();
});
//}

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHsts();

app.UseHttpsRedirection();

app.UseRouting();

app.UseResponseCompression();

app.UseAuthentication();
app.UseAuthorization();

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.MapControllers();

app.Run();
