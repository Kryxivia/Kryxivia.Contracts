using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Kryxivia.Contracts.Definitions.KryxiviaNft;
using static Kryxivia.Domain.Extensions.IServiceCollectionExtension;
using Kryxivia.Contracts.Options;
using Microsoft.Extensions.Options;

namespace Kryxivia.Contracts
{
    /// <summary>
    /// WARNING: This class must be instantiated ONLY with a Web3 object THAT IS BOUND to an account
    /// </summary>
    public class KryxiviaNftServiceWithSigner : _KryxiviaNftServiceBase
    {
        public KryxiviaNftServiceWithSigner(IOptions<KryxContractsOptions> kryxContractsOptions) : base(kryxContractsOptions?.Value.Web3WithSigner, kryxContractsOptions?.Value.NftContractAddress) { }
    }
}
