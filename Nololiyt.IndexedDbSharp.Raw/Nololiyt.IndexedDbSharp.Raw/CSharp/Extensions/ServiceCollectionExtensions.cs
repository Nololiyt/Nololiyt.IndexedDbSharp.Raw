using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp;

namespace Nololiyt.BlazorIndexedDb.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddIndexedDbSharpRaw(
            this IServiceCollection services, ServiceLifetime lifetime = ServiceLifetime.Scoped)
        {
            var descriptor = new ServiceDescriptor(
                serviceType: typeof(IIndexedDbSharpRawEntry),
                factory: (services) => {
                    var jsRuntime = services.GetRequiredService<IJSRuntime>();
                    return new IndexedDbSharpRawEntry(jsRuntime);
                },
                lifetime: lifetime);
            services.Add(descriptor);
            return services;
        }
    }
}
