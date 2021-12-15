# Readme

## Setup a token in Metamask

Metamask will automatically recognise the RIPHToken smart contract once given the address.

Click on the account options menu (three dots)
Click import tokens.
Enter the provided contract address
The token symbol is RIPH, the decimals are 18 and the contract name is 'RIPHToken'. Metamask should be able to retreive all three from the token contract automatically.

## Helpful hints
Useful tutorial
https://medium.com/my-blockchain-development-daily-journey/interfacing-net-and-ethereum-blockchain-smart-contracts-with-nethereum-2fa3729ac933
Also useful
https://medium.com/coinmonks/create-and-deploy-a-defi-app-to-ethereum-a02bb680aa78

To compile the contract a deploy it to ganache
`truffle deploy --reset --network ganache`

Keep a record of the contact address in a file (this address changes on each run)
`truffle deploy --reset --network ganache > build/truffle_output.txt`

From ganache-cli from the command line to get a reproducable blockchain

```
ganache-cli --accounts  10  --mnemonic "fitness vendor stage catch height total rain rural expand merit path jacket club strike potato"
```
Make sure you have installed ganache-cli globally

Or run from a docker container
```
docker run --publish 8545:8545 trufflesuite/ganache-cli:latest --accounts 10 --mnemonic "fitness vendor stage catch height total rain rural expand merit path jacket club strike potato"
```

Below is the out from ganache-cli with some useful addresses

PS C:\code\dotnet_ganache_example> ganache-cli --accounts  10  --mnemonic "fitness vendor stage catch height total rain rural expand merit path jacket club strike potato"
Ganache CLI v6.12.2 (ganache-core: 2.13.2)

Available Accounts
==================
(0) 0x2a87Fa2D95dAf4ffc5ACC6b24af7904f90a85a6a (100 ETH)
(1) 0x9D2cF142e35063d172cf4C2Cad18fAb3EdE465af (100 ETH)
(2) 0x0743a7b1B5AB432e805d8B7c4E15d1841332324d (100 ETH)
(3) 0xaC648DDc36ea44DDdAeEd916d18700ba45906292 (100 ETH)
(4) 0xB11252117cBDf19Ed6dE7B7B10a9FABd890D6479 (100 ETH)
(5) 0x6c6D88f5819C29f0bB27A4B5C326a14e1A442412 (100 ETH)
(6) 0x97404391a6e7Dc11D461401D8Cb4934f5d67A4eb (100 ETH)
(7) 0x6a73406b6b3B8234460140CED6A4d86662b9e07F (100 ETH)
(8) 0x92D7A667596f0bADd37077FBd7339c41D84542CD (100 ETH)
(9) 0x0d9ec43C60c4A59d2f59D74E8f9D621c4925B4bE (100 ETH)

Private Keys
==================
(0) 0xcd40b3c05afd72a48fb78bfd8b98d3acf96e1a83240bec5eeb2fc3eb3fa73794
(1) 0xa1a7a65e9804bcd31cd2c7f7bfcac8c2e8d7d3144f908d73d589d47d8085e9a4
(2) 0x388da0b343925d37ce124b142606f1e3c43a37cd11e9af9a71c94e8ba5927b85
(3) 0x2deedba1ba496fe1be14411d840ca38ddbfc3eed6c0f264452d4f795d5c646b2
(4) 0xcaf4cf7ae5de96bee1e4a268f9be70a11883387d7c3344909573c5babd9fef4a
(5) 0xe03f967f619267e9392aad98f7285682719cf7fb5d960787e9c8ef236be1b172
(6) 0xc00a0689f7208b8b56588fa40c019f7650a4e09ea68f7d218d5a4d2919435e6d
(7) 0xce98cdba7801e1bf6422587f62c65a6023b8ecc04a782510667e341f353a9751
(8) 0xb0345566deb0c55f494806ce99bbda854ec5dc33086ac77a518393326f3bb9a3
(9) 0x91e1100149368abb9bed6f9d011f33bfa374e3a26a8f3e4920e21871bcfc27d6

HD Wallet
==================
Mnemonic:      fitness vendor stage catch height total rain rural expand merit path jacket club strike potato
Base HD Path:  m/44'/60'/0'/0/{account_index}

Gas Price
==================
20000000000

Gas Limit
==================
6721975

Call Gas Limit
==================
9007199254740991

Listening on 127.0.0.1:8545
P