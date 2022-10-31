using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddIndexedDbSharpRaw(
            this IServiceCollection services,
            ServiceLifetime lifetime = ServiceLifetime.Scoped)
        {
            var descriptor = new ServiceDescriptor(
                serviceType: typeof(IAsyncIndexedDbSharpRawEntry),
                factory: (services) => {
                    var jsRuntime = services.GetRequiredService<IJSRuntime>();
                    return new AsyncIndexedDbSharpRawEntry(jsRuntime);
                },
                lifetime: lifetime);
            services.Add(descriptor);
            return services;
        }
    }
}
