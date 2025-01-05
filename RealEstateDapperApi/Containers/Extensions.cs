using RealEstateDapperApi.Repositories.AppUserRepositories;
using RealEstateDapperApi.Repositories.BottomGridRepositories;
using RealEstateDapperApi.Repositories.CategoryRepository;
using RealEstateDapperApi.Repositories.ContactRepositories;
using RealEstateDapperApi.Repositories.EmployeeRepository;
using RealEstateDapperApi.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using RealEstateDapperApi.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using RealEstateDapperApi.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using RealEstateDapperApi.Repositories.MessageRepositories;
using RealEstateDapperApi.Repositories.PopularLocationRepositories;
using RealEstateDapperApi.Repositories.ProductImageRepositories;
using RealEstateDapperApi.Repositories.ProductRepository;
using RealEstateDapperApi.Repositories.PropertyAmenityRepositories;
using RealEstateDapperApi.Repositories.ServiceRepository;
using RealEstateDapperApi.Repositories.StatisticsRepositories;
using RealEstateDapperApi.Repositories.SubFeatureRepositories;
using RealEstateDapperApi.Repositories.TestimonialRepositories;
using RealEstateDapperApi.Repositories.ToDoListRepositories;
using RealEstateDapperApi.Repositories.WhoWeAreRepository;

namespace RealEstateDapperApi.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services) 
        {
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IToDoListRepository, ToDoListRepository>();

            services.AddTransient<IStatisticRepository, StatisticRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
            services.AddTransient<ILast5ProductsRepository, Last5ProductsRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();
            services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();
        }
    }
}
