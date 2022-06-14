LondonStockApi
Small webapi to receive stocks

http://localhost:5252/api/allstocks

http://localhost:5252/api/stocks 

["A"]

http://localhost:5252/api/addstocks

{
    "TickerSymbol": "B",
    "Price": 23.45, 
    "NumberofShares": 3.0, 
    "BrokerId": 1
}

// TODO: similar tests can be added for other endpoints
// TODO: automated api tests of BDD style can be added using cucumber/gherkin
// TODO: swagger specs
// TODO: Logging sirilog/nlog
// TODO: Containerization and automated builds using JenkinsFile & DockerFile
// TODO: More document style and comments :)
// TODO: Autoscaling of pods based upon cpu/memory threshold if containerised
// TODO: Azure functions (AWS Lambda, API gateway) if serverless
// TODO: Some caching, appsettings (wherever/if applicable)
// TODO: fluent validation
// TODO: authentication & authorization
// TODO: Static code analysis
