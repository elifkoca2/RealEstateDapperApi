using RealEstateDapperApi.Models.DapperContext;
using RealEstateDapperApi.Repositories.BottomGridRepositories;
using RealEstateDapperApi.Repositories.CategoryRepository;
using RealEstateDapperApi.Repositories.EmployeeRepository;
using RealEstateDapperApi.Repositories.PopularLocationRepositories;
using RealEstateDapperApi.Repositories.ProductRepository;
using RealEstateDapperApi.Repositories.ServiceRepository;
using RealEstateDapperApi.Repositories.StatisticsRepositories;
using RealEstateDapperApi.Repositories.TestimonialRepositories;
using RealEstateDapperApi.Repositories.WhoWeAreRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<Context>();

builder.Services.AddTransient<ICategoryRepository , CategoryRepository>();
builder.Services.AddTransient<IProductRepository , ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository , WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository , ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository , BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository , PopularLocationRepository>();
builder.Services.AddTransient<IStatisticsRepository, StatisticsRepository>();
builder.Services.AddTransient<ITestimonialRepository , TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository , EmployeeRepository>();







builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
