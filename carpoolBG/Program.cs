using carpoolBG;
using carpoolBG.Data;
using carpoolBG.Models;
using carpoolBG.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);

builder.Services.AddRazorPages();
builder.Services.AddControllers();

builder.Services.AddDbContext<CarpoolContext>(options =>
{
    options.UseMySQL(@"datasource=localhost;username=root;password=;Database=CARPOOLBG;");
});

builder.Services.AddIdentity<CarpoolUser, UserRole>()
    .AddEntityFrameworkStores<CarpoolContext>()
    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<RideService>();
builder.Services.AddScoped<PreferencesService>();

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//startup.Configure(app, builder.Environment); // calling Configure method

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

