module.exports = function() {
  var instanceRoot = "D:\\Software\\IIS\\inetpub\\wwwroot\\dev.habitat";
  var config = {
    websiteRoot: instanceRoot + "\\Website",
    sitecoreLibraries: instanceRoot + "\\Website\\bin",
    licensePath: instanceRoot + "\\Data\\license.xml",
    solutionName: "Sitecore.Demo.Group",
    buildConfiguration: "Debug",
    runCleanBuilds: false
  };
  return config;
}