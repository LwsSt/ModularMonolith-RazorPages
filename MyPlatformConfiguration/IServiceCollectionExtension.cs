using Microsoft.Extensions.DependencyInjection;

using UICommon;

namespace MyPlatformConfiguration
{
    public static class IServiceCollectionExtension
    {
        public static void AddPlatformConfigurationArea(this IServiceCollection services)
        {
            services.Configure<TabOptions>(options =>
            {
                options.AddTab("PlatformConfiguration", "Platform Config");
            });
        }
    }
}
