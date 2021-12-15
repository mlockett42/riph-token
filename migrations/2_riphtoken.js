var riphToken = artifacts.require("RIPHToken");

module.exports = function (deployer) {
    // deployment steps
    deployer.deploy(riphToken);
};
