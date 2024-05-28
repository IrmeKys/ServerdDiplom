using Microsoft.EntityFrameworkCore;
using ServerdDiplom.ChlenZhopa;
using ServerdDiplom.Context;
using ServerdDiplom.Dota;
using ServerdDiplom.HyuPizda;
using ServerdDiplom.Services;
using ServerdDiplom.ZalupaVagina;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DiplomDB");
builder.Services.AddDbContext<DiplomDbContext>(options =>options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPassingScoreDayFreeFMService, PassingScoreDayFreeFMService>();
builder.Services.AddScoped<IExamsService, ExamsService>();
builder.Services.AddScoped<IRegionService, RegionService>();
builder.Services.AddScoped<ITrainingPeriodService, TrainingPeriodService>();
builder.Services.AddScoped<IFacultyService, FacultyService>();
builder.Services.AddScoped<ITownsService, TownsService>();
builder.Services.AddScoped<IComissionNumberService, ComisssionNumberService>();
builder.Services.AddScoped<ISpecialityService, SpecialityService>();
builder.Services.AddScoped<IUniversityService, UniversityService>();
builder.Services.AddScoped<IUniversityFacultyService, UniversityFacultyService>();
builder.Services.AddScoped<ISpecialityExamsService, SpecialityExamsService>();
builder.Services.AddScoped<ISpecialityFacultyService, SpecialityFacultyService>();
builder.Services.AddScoped<ISpecialityPassingScoreFreeService, SpecialityPassingScoreFreeService>();
builder.Services.AddScoped<IUniversityAdmissionService, UniversityAdmissionService>();
builder.Services.AddScoped<IUniversityInfoService, UniversityInfoService>();
builder.Services.AddScoped<IUniversitySearchService, UniversitySearchService>();
builder.Services.AddScoped<ISpecialitySearchService, SpecialitySearchService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
