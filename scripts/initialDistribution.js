const RIPHToken = artifacts.require("RIPHToken");
const { toBaseUnit } = require('../../utils');

module.exports = async function(callback) {
    const accounts = await new web3.eth.getAccounts();
    const riphToken = await RIPHToken.deployed(); 

    let decimals = await riphToken.decimals();
    decimals = decimals.toNumber();

    // Send test transfers to the second and third created accounts
    let transferAmount = toBaseUnit('100000', decimals, web3.utils.BN);
    await riphToken.transfer(accounts[1], transferAmount);

    transferAmount = toBaseUnit('50000', decimals, web3.utils.BN);
    await riphToken.transfer(accounts[2], transferAmount);

    console.log("Initial distribution complete");

    callback();
};
