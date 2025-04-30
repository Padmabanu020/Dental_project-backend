

using Dental_project.DataBase;
using Dental_project.Handlers;
using Dental_project.Repositories;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<DataBaseConnection>();
//builder.Services.AddScoped<DataBaseConnection>();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<ContactHandlers>();
builder.Services.AddScoped<HeroSectionHandlers>();
builder.Services.AddScoped<NavigationBarHandlers>();
builder.Services.AddScoped<IconHandlers>();



// Add services to the container.
builder.Services.AddControllers();
// Register DbConnection

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});


var app = builder.Build();
app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

