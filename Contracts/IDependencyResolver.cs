using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Contracts
{
    public interface IDependencyResolver
    {
        void ResolveDB(IServiceCollection services, IConfiguration configuration);
        void ResolveRepositories(IServiceCollection services);

    }
}
