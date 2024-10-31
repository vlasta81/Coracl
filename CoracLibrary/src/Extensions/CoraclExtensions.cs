using CoracLibrary.Abstractions;
using CoracLibrary.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CoracLibrary.Extensions
{
    /// <summary>
    /// Provides extension methods for adding Coracl services to the IServiceCollection.
    /// </summary>
    public static class CoraclExtensions
    {
        /// <summary>
        /// Adds Coracl services to the specified IServiceCollection.
        /// </summary>
        /// <param name="services">The IServiceCollection to add services to.</param>
        /// <param name="assembly">The assembly to scan for types implementing ICommandHandler and IChainHandler interfaces.</param>
        /// <returns>The IServiceCollection with Coracl services added.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the services parameter is null.</exception>
        public static IServiceCollection AddCoracl(this IServiceCollection services, Assembly assembly)
        {
            ArgumentNullException.ThrowIfNull(services);
            services.AddScoped<ICoracl, Coracl>();
            Type[]? types = assembly.GetExportedTypes();
            foreach (Type type in types)
            {
                if (type.IsClass && !type.IsAbstract)
                {
                    Type[] interfaces = type.GetInterfaces();
                    foreach (Type @interface in interfaces)
                    {
                        if (@interface.IsGenericType && @interface.GetGenericTypeDefinition() == typeof(ICommandHandler<,>))
                        {
                            services.AddScoped(@interface, type);
                        }
                        if (@interface.IsGenericType && type.BaseType is { IsGenericType: true } && type.BaseType.GetGenericTypeDefinition() == typeof(ChainHandler<,>) && @interface.GetGenericTypeDefinition() == typeof(IChainHandler<,>))
                        {
                            services.AddScoped(type);
                        }
                    }
                }
            }
            return services;
        }
    }

}
