using Nethereum.Web3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kryxivia.Contracts.Options
{
    public class KryxContractsOptions
    {
        public Web3 Web3 { get; set; }
        public Web3 Web3WithSigner { get; set; }

        public string NftContractAddress { get; set; }
    }
}
