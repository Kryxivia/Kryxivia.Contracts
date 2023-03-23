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
        public static IServiceCollection AddKryxReadContracts(this IServiceCollection services, Action<KryxContractsOptions> configureOptions)
        {
            services.Configure(configureOptions);

            var kryxContractsOptions = new KryxContractsOptions();
            configureOptions(kryxContractsOptions);

            // Mainnet

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.MainnetNftContractAddress))
            {
                services.AddScoped<MainnetKryxiviaNftService>();
            }

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.MainnetKryxitShardContractAddress))
            {
                services.AddScoped<MainnetKryxitShardService>();
            }

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.MainnetKryxiviaCoinContractAddress))
            {
                services.AddScoped<MainnetKryxiviaCoinService>();
            }

            // Testnet

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.TestnetNftContractAddress))
            {
                services.AddScoped<TestnetKryxiviaNftService>();
            }

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.TestnetKryxitShardContractAddress))
            {
                services.AddScoped<TestnetKryxitShardService>();
            }

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.TestnetKryxiviaCoinContractAddress))
            {
                services.AddScoped<TestnetKryxiviaCoinService>();
            }

            return services;
        }
    }
}
