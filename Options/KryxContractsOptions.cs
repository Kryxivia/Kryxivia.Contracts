using Nethereum.Web3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kryxivia.Contracts.Options
{
    public class KryxContractsOptions
    {
        public Web3 TestnetWeb3 { get; set; }
        public Web3 TestnetWeb3WithSigner { get; set; }
        public string TestnetNftContractAddress { get; set; }
        public string TestnetKryxitShardContractAddress { get; set; }
        public string TestnetKryxiviaCoinContractAddress { get; set; }

        public Web3 MainnetWeb3 { get; set; }
        public Web3 MainnetWeb3WithSigner { get; set; }
        public string MainnetNftContractAddress { get; set; }
        public string MainnetKryxitShardContractAddress { get; set; }
        public string MainnetKryxiviaCoinContractAddress { get; set; }
    }
}
