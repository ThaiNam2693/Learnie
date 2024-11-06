using LearnieService.Core;
using LearnieService.LearnieDbContext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LearnieDatabaseContext>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.WithOrigins("http://localhost:5173")
                   .AllowAnyHeader()
                   .AllowAnyMethod()
                   .AllowCredentials();
        });
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("All", builder => builder
        .WithOrigins("http://localhost:5173")
        .AllowAnyMethod().AllowAnyHeader().AllowCredentials());
});

// Add session support
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(1);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll"); 
app.UseSession();
app.UseAuthorization();

app.MapControllers();

app.Run();
