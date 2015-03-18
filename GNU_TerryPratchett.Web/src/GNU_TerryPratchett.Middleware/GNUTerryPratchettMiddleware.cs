using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace GNU_TerryPratchett.Middleware
{
    public class GNUTerryPratchettMiddleware
    {
        private readonly RequestDelegate _next;
        
        /// <summary>
        /// Creates a default web page for new applications.
        /// </summary>
        /// <param name="next"></param>
        public GNUTerryPratchettMiddleware(RequestDelegate next)
        {
            if (next == null)
            {
                throw new ArgumentNullException("next");
            }
        
            _next = next;
        }

        /// <summary>
        /// Process an individual request.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task Invoke(HttpContext context)
        {
            HttpResponse response = context.Response;
            response.Headers.Set("X-Clacks-Overhead", "GNU Terry Pratchett");

            return _next(context);
        }

    }

    //public static class GNUTerryPratchettMiddleware
    //{
    //    public static GTPServicesBuilder AddGNUTerryPratchett(this IServiceCollection services)
    //    {
    //        return services.AddGNUTerryPratchett(configuration: null);
    //    }

    //    public static GTPServicesBuilder AddGUNTerryPratchett(this IServiceCollection services, IConfiguration configuration)
    //    {
    //        services.TryAdd(ServiceDescriptor.Singleton<IHeader)

    //    }
    //}

    //public class GTPServicesBuilder
    //{
    //    private readonly IServiceCollection _serviceCollection;

    //    public GTPServicesBuilder(IServiceCollection serviceCollection)
    //    {
    //        _serviceCollection = serviceCollection;
    //    }

    //    public virtual IServiceCollection ServiceCollection
    //    {
    //        get { return _serviceCollection; }
    //    }
    //}
}



//public static class SignalRServiceCollectionExtensions
//{
//    public static SignalRServicesBuilder AddSignalR(this IServiceCollection services, Action<SignalROptions> configureOptions = null)
//    {
//        return services.AddSignalR(configuration: null, configureOptions: configureOptions);
//    }

//    public static SignalRServicesBuilder AddSignalR(this IServiceCollection services, IConfiguration configuration, Action<SignalROptions> configureOptions = null)
//    {
//        // Dependencies
//        services.AddOptions();
//        services.AddDataProtection();
//        services.AddMessageBus();

//        // SignalR services
//        services.TryAdd(ServiceDescriptor.Singleton<IMemoryPool, MemoryPool>());
//        services.TryAdd(ServiceDescriptor.Singleton<ITransportManager, TransportManager>());
//        services.TryAdd(ServiceDescriptor.Singleton<ITransportHeartbeat, TransportHeartbeat>());
//        services.TryAdd(ServiceDescriptor.Singleton<IConnectionManager, ConnectionManager>());
//        services.TryAdd(ServiceDescriptor.Singleton<IAckHandler, AckHandler>());
//        services.TryAdd(ServiceDescriptor.Singleton<AckSubscriber, AckSubscriber>());
//        services.TryAdd(ServiceDescriptor.Singleton<IAssemblyLocator, DefaultAssemblyLocator>());
//        services.TryAdd(ServiceDescriptor.Singleton<IHubManager, DefaultHubManager>());
//        services.TryAdd(ServiceDescriptor.Singleton<IMethodDescriptorProvider, ReflectedMethodDescriptorProvider>());
//        services.TryAdd(ServiceDescriptor.Singleton<IHubDescriptorProvider, ReflectedHubDescriptorProvider>());
//        services.TryAdd(ServiceDescriptor.Singleton<JsonSerializer, JsonSerializer>());
//        services.TryAdd(ServiceDescriptor.Singleton<IUserIdProvider, PrincipalUserIdProvider>());
//        services.TryAdd(ServiceDescriptor.Singleton<IParameterResolver, DefaultParameterResolver>());
//        services.TryAdd(ServiceDescriptor.Singleton<IHubActivator, DefaultHubActivator>());
//        services.TryAdd(ServiceDescriptor.Singleton<IJavaScriptProxyGenerator, DefaultJavaScriptProxyGenerator>());
//        services.TryAdd(ServiceDescriptor.Singleton<IJavaScriptMinifier, NullJavaScriptMinifier>());
//        services.TryAdd(ServiceDescriptor.Singleton<IHubRequestParser, HubRequestParser>());
//        services.TryAdd(ServiceDescriptor.Singleton<IHubPipelineInvoker, HubPipeline>());

//        services.TryAdd(ServiceDescriptor.Singleton(typeof(IPersistentConnectionContext<>), typeof(PersistentConnectionContextService<>)));
//        services.TryAdd(ServiceDescriptor.Singleton(typeof(IHubContext<>), typeof(HubContextService<>)));
//        services.TryAdd(ServiceDescriptor.Singleton(typeof(IHubContext<,>), typeof(HubContextService<,>)));

//        // TODO: Just use the new IDataProtectionProvider abstraction directly here
//        services.TryAdd(ServiceDescriptor.Singleton<IProtectedData, DataProtectionProviderProtectedData>());

//        // Setup the default SignalR options
//        services.TryAdd(ServiceDescriptor.Transient<IConfigureOptions<SignalROptions>, SignalROptionsSetup>());

//        if (configuration != null)
//        {
//            services.Configure<SignalROptions>(configuration);
//        }

//        if (configureOptions != null)
//        {
//            services.Configure(configureOptions);
//        }

//        return new SignalRServicesBuilder(services);
//    }
//}

//public class SignalRServicesBuilder
//9     { 
//10         private readonly IServiceCollection _serviceCollection; 
//11 

//12         public SignalRServicesBuilder([NotNull] IServiceCollection serviceCollection)
//13         { 
//14             _serviceCollection = serviceCollection; 
//15         } 
//16 

//17         public virtual IServiceCollection ServiceCollection
//18         { 
//19             get { return _serviceCollection; } 
//20         } 
//21     } 
