using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Contracts
{
    public interface IDependencyResolver
    {
        void ResolveDb(IServiceCollection services, IConfiguration configuration);
        void ResolveRepositories(IServiceCollection services);

    }
}
