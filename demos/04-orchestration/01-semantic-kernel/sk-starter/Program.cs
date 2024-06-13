using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

IConfiguration configuration = builder.Build();

var deploymentModelName = configuration["SemanticKernel:DeploymentModelName"];
var endpoint = configuration["SemanticKernel:Endpoint"];
var resourceKey = configuration["SemanticKernel:ResourceKey"];
var deploymentModel = configuration["SemanticKernel:DeploymentModel"];

var kernelBuilder = Kernel.CreateBuilder();
kernelBuilder.Services.AddAzureOpenAIChatCompletion(
    deploymentModelName,
    endpoint,
    resourceKey,
    deploymentModel
);

var kernel = kernelBuilder.Build();

var prompt = "Give me a list of breakfast foods with eggs and cheese";
var result = await kernel.InvokePromptAsync(prompt);

Console.WriteLine(result);