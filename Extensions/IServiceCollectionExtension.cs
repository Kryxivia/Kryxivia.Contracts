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

            // Mainnet

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.MainnetNftContractAddress))
            {
                services.AddScoped<MainnetKryxiviaNftService>();
                if (kryxContractsOptions.MainnetWeb3WithSigner != null) services.AddScoped<MainnetKryxiviaNftServiceWithSigner>();
            }

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.MainnetKryxitShardContractAddress))
            {
                services.AddScoped<MainnetKryxitShardService>();
                if (kryxContractsOptions.MainnetWeb3WithSigner != null) services.AddScoped<MainnetKryxitShardServiceWithSigner>();
            }

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.MainnetKryxiviaCoinContractAddress))
            {
                services.AddScoped<MainnetKryxiviaCoinService>();
                if (kryxContractsOptions.MainnetWeb3WithSigner != null) services.AddScoped<MainnetKryxiviaCoinServiceWithSigner>();
            }

            // Testnet

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.TestnetNftContractAddress))
            {
                services.AddScoped<TestnetKryxiviaNftService>();
                if (kryxContractsOptions.TestnetWeb3WithSigner != null) services.AddScoped<TestnetKryxiviaNftServiceWithSigner>();
            }

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.TestnetKryxitShardContractAddress))
            {
                services.AddScoped<TestnetKryxitShardService>();
                if (kryxContractsOptions.TestnetWeb3WithSigner != null) services.AddScoped<TestnetKryxitShardServiceWithSigner>();
            }

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.TestnetKryxiviaCoinContractAddress))
            {
                services.AddScoped<TestnetKryxiviaCoinService>();
                if (kryxContractsOptions.TestnetWeb3WithSigner != null) services.AddScoped<TestnetKryxiviaCoinServiceWithSigner>();
            }

            return services;
        }
    }
}
