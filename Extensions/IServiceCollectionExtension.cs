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

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.MainnetShardCoinContractAddress))
            {
                services.AddScoped<MainnetKryxiviaShardCoinService>();
                if (kryxContractsOptions.MainnetWeb3WithSigner != null) services.AddScoped<MainnetKryxiviaShardCoinServiceWithSigner>();
            }

            // Testnet

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.TestnetNftContractAddress))
            {
                services.AddScoped<TestnetKryxiviaNftService>();
                if (kryxContractsOptions.TestnetWeb3WithSigner != null) services.AddScoped<TestnetKryxiviaNftServiceWithSigner>();
            }

            if (!string.IsNullOrWhiteSpace(kryxContractsOptions.TestnetShardCoinContractAddress))
            {
                services.AddScoped<TestnetKryxiviaShardCoinService>();
                if (kryxContractsOptions.TestnetWeb3WithSigner != null) services.AddScoped<TestnetKryxiviaShardCoinServiceWithSigner>();
            }

            return services;
        }
    }
}
