using Microsoft.Extensions.DependencyInjection;

namespace ToDo.Application
{
    public static class DI
    {
        public static void Register(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DI).Assembly);
        }
    }
}
