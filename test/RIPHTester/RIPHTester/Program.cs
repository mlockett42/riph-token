using Microsoft.Extensions.Configuration;
using Nethereum.StandardTokenEIP20;
using Nethereum.Util;
using Nethereum.Web3;
using RIPHTester.Configuration;
using System;
using System.Threading.Tasks;
using Xunit;

namespace RIPHTester
{
    class Program
    {
        static async Task<BigDecimal> GetAccountBalanceAsync(StandardTokenService tokenService, byte decimals, string account)
        {
            var ownerBalance = await tokenService.BalanceOfQueryAsync(account);
            return new BigDecimal(ownerBalance, -1 * decimals);
        }

        static async Task Main(string[] args)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder();
            builder
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .AddUserSecrets<Program>();

            var configuration = builder.Build();

            var settings = configuration.Get<Settings>();

            // Allow us to sanity check that all the parameters are correct if the test fails
            Console.WriteLine($"SmartContractAddress={settings.RIPHTester.SmartContractAddress}");
            Console.WriteLine($"SmartContractAbiPath={settings.RIPHTester.SmartContractAbiPath}");
            Console.WriteLine($"BlockchainURL={settings.RIPHTester.BlockchainURL}");

            // Initialise the connection to the contract running on Ganache
            Web3 web3 = new Web3(settings.RIPHTester.BlockchainURL);
            var tokenService = new StandardTokenService(web3, settings.RIPHTester.SmartContractAddress);
            // We need decimals to format token balances in a useful way
            var decimals = await tokenService.DecimalsQueryAsync();
            // Verify the token balances are correct - this checks everything has worked.
            Assert.Equal(BigDecimal.Parse("850000"), await GetAccountBalanceAsync(tokenService, decimals, "0x2a87Fa2D95dAf4ffc5ACC6b24af7904f90a85a6a"));
            Assert.Equal(BigDecimal.Parse("100000"), await GetAccountBalanceAsync(tokenService, decimals, "0x9D2cF142e35063d172cf4C2Cad18fAb3EdE465af"));
            Assert.Equal(BigDecimal.Parse("50000"), await GetAccountBalanceAsync(tokenService, decimals, "0x0743a7b1B5AB432e805d8B7c4E15d1841332324d"));
            Console.WriteLine("Balances are correct");
        }
    }
}
