## Testing Azure Functions

[Azure Functions](https://docs.microsoft.com/en-us/azure/azure-functions/)

- [x] Javascript
  - Node v15 not support??
  ```js
    // only the below verions of Node are supported
    var supportedVersions:string[] = ["v8", "v10", "v12", "v14"]
    
    //  https://github.com/Azure/azure-functions-nodejs-worker/blob/v2.1.0/src/nodejsWorker.ts
     ```
  - [Official Documentation](https://docs.microsoft.com/en-gb/azure/developer/javascript/)
  - [Use Azure Functions to develop Node.js serverless code](https://docs.microsoft.com/en-gb/azure/developer/javascript/how-to/develop-serverless-apps)
  - [Create and deploy Azure Functions from Visual Studio Code](https://docs.microsoft.com/en-gb/azure/developer/javascript/tutorial/tutorial-vscode-serverless-node-install?tabs=bash)
- [x] C#
  - <s>.NET Core on M1 Mac currently not support</s> 
  - .Net Core 3 and .Net 5 working on M1 Mac
  - Azure Functions only supporting .Net Core 3
    - .Net 5 Support (https://techcommunity.microsoft.com/t5/apps-on-azure/net-5-support-on-azure-functions/ba-p/1973055)
  - `F5` to run debug to test Functions locally
  - [Official Documentation](https://docs.microsoft.com/en-us/azure/azure-functions/functions-overview)
  - [Quickstart](https://docs.microsoft.com/en-us/azure/azure-functions/create-first-function-vs-code-csharp)
- [ ] Typescript
- [ ] Python

https://test-serverless-csharp.azurewebsites.net/api/RandomNumber?
https://test-serverless-javascript.azurewebsites.net/api/RandomNumber?
https://test-serverless-python.azurewebsites.net/api/RandomNumber?
