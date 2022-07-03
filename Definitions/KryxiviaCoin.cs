using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Kryxivia.Contracts.Definitions.KryxiviaCoin
{
    public partial class KryxiviaCoinDeployment : KryxiviaCoinDeploymentBase
    {
        public KryxiviaCoinDeployment() : base(BYTECODE) { }
        public KryxiviaCoinDeployment(string byteCode) : base(byteCode) { }
    }

    public class KryxiviaCoinDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "6080604052620000126012600a62000362565b6200002290630ee6b28062000377565b6006556007805460ff60a01b191690553480156200003f57600080fd5b506040516200172a3803806200172a833981016040819052620000629162000466565b8151829082906200007b906004906020850190620001a7565b50805162000091906005906020840190620001a7565b5050600780546001600160a01b03191633908117909155600654620000b79250620000bf565b505062000527565b6001600160a01b0382166200011a5760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f206164647265737300604482015260640160405180910390fd5b80600360008282546200012e9190620004d0565b90915550506001600160a01b038216600090815260016020526040812080548392906200015d908490620004d0565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35050565b828054620001b590620004eb565b90600052602060002090601f016020900481019282620001d9576000855562000224565b82601f10620001f457805160ff191683800117855562000224565b8280016001018555821562000224579182015b828111156200022457825182559160200191906001019062000207565b506200023292915062000236565b5090565b5b8082111562000232576000815560010162000237565b634e487b7160e01b600052601160045260246000fd5b600181815b80851115620002a45781600019048211156200028857620002886200024d565b808516156200029657918102915b93841c939080029062000268565b509250929050565b600082620002bd575060016200035c565b81620002cc575060006200035c565b8160018114620002e55760028114620002f05762000310565b60019150506200035c565b60ff8411156200030457620003046200024d565b50506001821b6200035c565b5060208310610133831016604e8410600b841016171562000335575081810a6200035c565b62000341838362000263565b80600019048211156200035857620003586200024d565b0290505b92915050565b6000620003708383620002ac565b9392505050565b60008160001904831182151516156200039457620003946200024d565b500290565b634e487b7160e01b600052604160045260246000fd5b600082601f830112620003c157600080fd5b81516001600160401b0380821115620003de57620003de62000399565b604051601f8301601f19908116603f0116810190828211818310171562000409576200040962000399565b816040528381526020925086838588010111156200042657600080fd5b600091505b838210156200044a57858201830151818301840152908201906200042b565b838211156200045c5760008385830101525b9695505050505050565b600080604083850312156200047a57600080fd5b82516001600160401b03808211156200049257600080fd5b620004a086838701620003af565b93506020850151915080821115620004b757600080fd5b50620004c685828601620003af565b9150509250929050565b60008219821115620004e657620004e66200024d565b500190565b600181811c908216806200050057607f821691505b6020821081036200052157634e487b7160e01b600052602260045260246000fd5b50919050565b6111f380620005376000396000f3fe608060405234801561001057600080fd5b506004361061014d5760003560e01c806342966c68116100c357806395d89b411161007c57806395d89b41146102ca578063a217fddf146102d2578063a457c2d7146102da578063a9059cbb146102ed578063d547741f14610300578063dd62ed3e1461031357600080fd5b806342966c68146102425780634ff686af146102555780635ce289ba1461026857806370a082311461027b57806379cc6790146102a457806391d14854146102b757600080fd5b8063248a9ca311610115578063248a9ca3146101c75780632f2ff15d146101ea578063313ce567146101ff57806332424aa31461021457806336568abe1461021c578063395093511461022f57600080fd5b806301ffc9a71461015257806306fdde031461017a578063095ea7b31461018f57806318160ddd146101a257806323b872dd146101b4575b600080fd5b610165610160366004610eb0565b610326565b60405190151581526020015b60405180910390f35b61018261035d565b6040516101719190610f06565b61016561019d366004610f55565b6103ef565b6003545b604051908152602001610171565b6101656101c2366004610f7f565b610407565b6101a66101d5366004610fbb565b60009081526020819052604090206001015490565b6101fd6101f8366004610fd4565b61042b565b005b60125b60405160ff9091168152602001610171565b610202601281565b6101fd61022a366004610fd4565b610455565b61016561023d366004610f55565b6104d8565b6101fd610250366004610fbb565b6104fa565b6101fd610263366004610fbb565b610507565b6101fd610276366004611000565b610568565b6101a6610289366004611022565b6001600160a01b031660009081526001602052604090205490565b6101fd6102b2366004610f55565b6105d6565b6101656102c5366004610fd4565b6105eb565b610182610614565b6101a6600081565b6101656102e8366004610f55565b610623565b6101656102fb366004610f55565b61069e565b6101fd61030e366004610fd4565b6106ac565b6101a661032136600461103d565b6106d1565b60006001600160e01b03198216637965db0b60e01b148061035757506301ffc9a760e01b6001600160e01b03198316145b92915050565b60606004805461036c90611067565b80601f016020809104026020016040519081016040528092919081815260200182805461039890611067565b80156103e55780601f106103ba576101008083540402835291602001916103e5565b820191906000526020600020905b8154815290600101906020018083116103c857829003601f168201915b5050505050905090565b6000336103fd8185856106fc565b5060019392505050565b600033610415858285610820565b61042085858561089a565b506001949350505050565b60008281526020819052604090206001015461044681610a68565b6104508383610a72565b505050565b6001600160a01b03811633146104ca5760405162461bcd60e51b815260206004820152602f60248201527f416363657373436f6e74726f6c3a2063616e206f6e6c792072656e6f756e636560448201526e103937b632b9903337b91039b2b63360891b60648201526084015b60405180910390fd5b6104d48282610af6565b5050565b6000336103fd8185856104eb83836106d1565b6104f591906110b7565b6106fc565b6105043382610b5b565b50565b600754600160a01b900460ff166104fa576007546001600160a01b031633146104fa5760405162461bcd60e51b8152602060048201526013602482015272556e617574686f72697a65642061636365737360681b60448201526064016104c1565b6007546001600160a01b031633146105b85760405162461bcd60e51b8152602060048201526013602482015272556e617574686f72697a65642061636365737360681b60448201526064016104c1565b60078054911515600160a01b0260ff60a01b19909216919091179055565b6105e1823383610820565b6104d48282610b5b565b6000918252602082815260408084206001600160a01b0393909316845291905290205460ff1690565b60606005805461036c90611067565b6000338161063182866106d1565b9050838110156106915760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b60648201526084016104c1565b61042082868684036106fc565b6000336103fd81858561089a565b6000828152602081905260409020600101546106c781610a68565b6104508383610af6565b6001600160a01b03918216600090815260026020908152604080832093909416825291909152205490565b6001600160a01b03831661075e5760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b60648201526084016104c1565b6001600160a01b0382166107bf5760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b60648201526084016104c1565b6001600160a01b0383811660008181526002602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b600061082c84846106d1565b9050600019811461089457818110156108875760405162461bcd60e51b815260206004820152601d60248201527f45524332303a20696e73756666696369656e7420616c6c6f77616e636500000060448201526064016104c1565b61089484848484036106fc565b50505050565b6001600160a01b0383166108fe5760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b60648201526084016104c1565b6001600160a01b0382166109605760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b60648201526084016104c1565b6001600160a01b038316600090815260016020526040902054818110156109d85760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b60648201526084016104c1565b6001600160a01b03808516600090815260016020526040808220858503905591851681529081208054849290610a0f9084906110b7565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef84604051610a5b91815260200190565b60405180910390a3610894565b6105048133610ca9565b610a7c82826105eb565b6104d4576000828152602081815260408083206001600160a01b03851684529091529020805460ff19166001179055610ab23390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b610b0082826105eb565b156104d4576000828152602081815260408083206001600160a01b0385168085529252808320805460ff1916905551339285917ff6391f5c32d9c69d2a47ea670b442974b53935d1edc7fd64eb21e047a839171b9190a45050565b6001600160a01b038216610bbb5760405162461bcd60e51b815260206004820152602160248201527f45524332303a206275726e2066726f6d20746865207a65726f206164647265736044820152607360f81b60648201526084016104c1565b6001600160a01b03821660009081526001602052604090205481811015610c2f5760405162461bcd60e51b815260206004820152602260248201527f45524332303a206275726e20616d6f756e7420657863656564732062616c616e604482015261636560f01b60648201526084016104c1565b6001600160a01b0383166000908152600160205260408120838303905560038054849290610c5e9084906110cf565b90915550506040518281526000906001600160a01b038516907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a3505050565b610cb382826105eb565b6104d457610ccb816001600160a01b03166014610d0d565b610cd6836020610d0d565b604051602001610ce79291906110e6565b60408051601f198184030181529082905262461bcd60e51b82526104c191600401610f06565b60606000610d1c83600261115b565b610d279060026110b7565b67ffffffffffffffff811115610d3f57610d3f61117a565b6040519080825280601f01601f191660200182016040528015610d69576020820181803683370190505b509050600360fc1b81600081518110610d8457610d84611190565b60200101906001600160f81b031916908160001a905350600f60fb1b81600181518110610db357610db3611190565b60200101906001600160f81b031916908160001a9053506000610dd784600261115b565b610de29060016110b7565b90505b6001811115610e5a576f181899199a1a9b1b9c1cb0b131b232b360811b85600f1660108110610e1657610e16611190565b1a60f81b828281518110610e2c57610e2c611190565b60200101906001600160f81b031916908160001a90535060049490941c93610e53816111a6565b9050610de5565b508315610ea95760405162461bcd60e51b815260206004820181905260248201527f537472696e67733a20686578206c656e67746820696e73756666696369656e7460448201526064016104c1565b9392505050565b600060208284031215610ec257600080fd5b81356001600160e01b031981168114610ea957600080fd5b60005b83811015610ef5578181015183820152602001610edd565b838111156108945750506000910152565b6020815260008251806020840152610f25816040850160208701610eda565b601f01601f19169190910160400192915050565b80356001600160a01b0381168114610f5057600080fd5b919050565b60008060408385031215610f6857600080fd5b610f7183610f39565b946020939093013593505050565b600080600060608486031215610f9457600080fd5b610f9d84610f39565b9250610fab60208501610f39565b9150604084013590509250925092565b600060208284031215610fcd57600080fd5b5035919050565b60008060408385031215610fe757600080fd5b82359150610ff760208401610f39565b90509250929050565b60006020828403121561101257600080fd5b81358015158114610ea957600080fd5b60006020828403121561103457600080fd5b610ea982610f39565b6000806040838503121561105057600080fd5b61105983610f39565b9150610ff760208401610f39565b600181811c9082168061107b57607f821691505b60208210810361109b57634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052601160045260246000fd5b600082198211156110ca576110ca6110a1565b500190565b6000828210156110e1576110e16110a1565b500390565b7f416363657373436f6e74726f6c3a206163636f756e742000000000000000000081526000835161111e816017850160208801610eda565b7001034b99036b4b9b9b4b733903937b6329607d1b601791840191820152835161114f816028840160208801610eda565b01602801949350505050565b6000816000190483118215151615611175576111756110a1565b500290565b634e487b7160e01b600052604160045260246000fd5b634e487b7160e01b600052603260045260246000fd5b6000816111b5576111b56110a1565b50600019019056fea26469706673582212201b34a5bfe542d204c0a823fa14a66f286a3b3740d0dc67151f6101d3cfb96e9464736f6c634300080e0033";
        public KryxiviaCoinDeploymentBase() : base(BYTECODE) { }
        public KryxiviaCoinDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("string", "name", 1)]
        public virtual string Name { get; set; }
        [Parameter("string", "symbol", 2)]
        public virtual string Symbol { get; set; }
    }

    public partial class DefaultAdminRoleFunction : DefaultAdminRoleFunctionBase { }

    [Function("DEFAULT_ADMIN_ROLE", "bytes32")]
    public class DefaultAdminRoleFunctionBase : FunctionMessage
    {

    }

    public partial class AllowanceFunction : AllowanceFunctionBase { }

    [Function("allowance", "uint256")]
    public class AllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2)]
        public virtual string Spender { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve", "bool")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class BurnFunction : BurnFunctionBase { }

    [Function("burn")]
    public class BurnFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class BurnFromFunction : BurnFromFunctionBase { }

    [Function("burnFrom")]
    public class BurnFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class BurnKXAFunction : BurnKXAFunctionBase { }

    [Function("burnKXA")]
    public class BurnKXAFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class DecimalsFunction : DecimalsFunctionBase { }

    [Function("decimals", "uint8")]
    public class DecimalsFunctionBase : FunctionMessage
    {

    }

    public partial class DecreaseAllowanceFunction : DecreaseAllowanceFunctionBase { }

    [Function("decreaseAllowance", "bool")]
    public class DecreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "subtractedValue", 2)]
        public virtual BigInteger SubtractedValue { get; set; }
    }

    public partial class GetRoleAdminFunction : GetRoleAdminFunctionBase { }

    [Function("getRoleAdmin", "bytes32")]
    public class GetRoleAdminFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
    }

    public partial class GrantRoleFunction : GrantRoleFunctionBase { }

    [Function("grantRole")]
    public class GrantRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class HasRoleFunction : HasRoleFunctionBase { }

    [Function("hasRole", "bool")]
    public class HasRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class IncreaseAllowanceFunction : IncreaseAllowanceFunctionBase { }

    [Function("increaseAllowance", "bool")]
    public class IncreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "addedValue", 2)]
        public virtual BigInteger AddedValue { get; set; }
    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceRoleFunction : RenounceRoleFunctionBase { }

    [Function("renounceRole")]
    public class RenounceRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class RevokeRoleFunction : RevokeRoleFunctionBase { }

    [Function("revokeRole")]
    public class RevokeRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class SetBurnStateFunction : SetBurnStateFunctionBase { }

    [Function("setBurnState")]
    public class SetBurnStateFunctionBase : FunctionMessage
    {
        [Parameter("bool", "state", 1)]
        public virtual bool State { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFunction : TransferFunctionBase { }

    [Function("transfer", "bool")]
    public class TransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom", "bool")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2, true )]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class RoleAdminChangedEventDTO : RoleAdminChangedEventDTOBase { }

    [Event("RoleAdminChanged")]
    public class RoleAdminChangedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("bytes32", "previousAdminRole", 2, true )]
        public virtual byte[] PreviousAdminRole { get; set; }
        [Parameter("bytes32", "newAdminRole", 3, true )]
        public virtual byte[] NewAdminRole { get; set; }
    }

    public partial class RoleGrantedEventDTO : RoleGrantedEventDTOBase { }

    [Event("RoleGranted")]
    public class RoleGrantedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "sender", 3, true )]
        public virtual string Sender { get; set; }
    }

    public partial class RoleRevokedEventDTO : RoleRevokedEventDTOBase { }

    [Event("RoleRevoked")]
    public class RoleRevokedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "sender", 3, true )]
        public virtual string Sender { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class DefaultAdminRoleOutputDTO : DefaultAdminRoleOutputDTOBase { }

    [FunctionOutput]
    public class DefaultAdminRoleOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class DecimalsOutputDTO : DecimalsOutputDTOBase { }

    [FunctionOutput]
    public class DecimalsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }

    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetRoleAdminOutputDTO : GetRoleAdminOutputDTOBase { }

    [FunctionOutput]
    public class GetRoleAdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class HasRoleOutputDTO : HasRoleOutputDTOBase { }

    [FunctionOutput]
    public class HasRoleOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }



    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }







    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }




}
