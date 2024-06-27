using Application.DTO.Config;
using Application.Interfaces;
using Application.UseCase.Services;
using Infraestructure.ApiClient;
using Infraestructure.Command;
using Infraestructure.Persistence;
using Infraestructure.Query;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1.0.0",
        Title = "Offer Management MS",
        Description = "Basic architecture of the project.",
        Contact = new OpenApiContact
        {
            Name = "Ivan Brestt",
            Url = new Uri("https://github.com/ivyab97")
        }
    });

    //Swagger Documentation
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

//Swagger Authentication
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Ingrese el token JWT sin el prefijo 'Bearer'. Ejemplo: {token}",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new List<string>()
        }
    });
});

var key = builder.Configuration.GetValue<string>("ApiSettings:Secret");

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(x => {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
});



//Custom
var connectionString = builder.Configuration["ConnectionString"];

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));


builder.Services.AddScoped<IOfferCommand, OfferCommand>();
builder.Services.AddScoped<IOfferQuery, OfferQuery>();
builder.Services.AddScoped<IOfferCommandService, OfferCommandService>();
builder.Services.AddScoped<IOfferQueryService, OfferQueryService>();

builder.Services.AddScoped<IApplicationCommand, ApplicationCommand>();
builder.Services.AddScoped<IApplicationQuery, ApplicationQuery>();
builder.Services.AddScoped<IApplicationCommandService, ApplicationCommandService>();
builder.Services.AddScoped<IApplicationQueryService, ApplicationQueryService>();

builder.Services.AddScoped<ICategoryQuery, CategoryQuery>();
builder.Services.AddScoped<ICategoryQueryService, CategoryQueryService>();

builder.Services.AddScoped<ISkillQuery, SkillQuery>();
builder.Services.AddScoped<ISkillQueryService, SkillQueryService>();

builder.Services.AddScoped<IJobOfferModeQuery, JobOfferModeQuery>();
builder.Services.AddScoped<IJobOfferModeQueryService, JobOfferModeQueryService>();

builder.Services.AddScoped<IProvinceQuery, ProvinceQuery>();
builder.Services.AddScoped<IProvinceQueryService, ProvinceQueryService>();

builder.Services.AddScoped<ISkillQuery, SkillQuery>();
builder.Services.AddScoped<ISkillQueryService, SkillQueryService>();

builder.Services.AddScoped<IStudyTypeQuery, StudyTypeQuery>();
builder.Services.AddScoped<IStudyTypeQueryService, StudyTypeQueryService>();

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddHttpClient();
builder.Services.AddTransient<ICompanyApi, CompanyApi>();
builder.Services.AddTransient<IApplicantApi, ApplicationApi>();


builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("NewPolicy", app =>
    {
        app.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
    }); 
});


var config = new AutoMapper.MapperConfiguration(
    options =>
    {
        options.AllowNullDestinationValues = true;
        options.AllowNullCollections = true;
        options.AddProfile(new AutoMapperProfile());
    });
builder.Services.AddSingleton(config.CreateMapper());

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseCors("NewPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
