using Kryxivia.Contracts;
using Kryxivia.Contracts.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Nethereum.Web3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kryxivia.Domain.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddKryxContracts(this IServiceCollection services, Action<KryxContractsOptions> configureOptions)
        {
            services.Configure(configureOptions);

            var kryxContractsOptions = new KryxContractsOptions();
            configureOptions(kryxContractsOptions);

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.MainnetNftContractAddress))
            {
                services.AddScoped<MainnetKryxiviaNftService>();
                services.AddScoped<KryxiviaNftServiceWithSigner>();
            }

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.TestnetNftContractAddress))
            {
                services.AddScoped<TestnetKryxiviaNftService>();
                services.AddScoped<TestnetKryxiviaNftServiceWithSigner>();
            }

            return services;
        }
    }
}
