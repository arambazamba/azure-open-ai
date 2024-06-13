# Releasing to Production

[Azure Container Apps](https://learn.microsoft.com/en-us/azure/container-apps/overview)

[Azure Container Apps Dynamic Sessions](https://github.com/Azure-Samples/container-apps-dynamic-sessions-samples?tab=readme-ov-file)

[Understanding AI plugins in Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/agents/plugins/?tabs=Csharp)

[Semantic Kernel with React Frontend on ACA](https://techcommunity.microsoft.com/t5/apps-on-azure/semantic-kernel-container-apps-with-react-and-python/m-p/3958787)

## Demos

- Semantic Kernel Function Calling Entity Framework
- Deploy to Azure Container Apps

# Semantic Kernel Function Calling Entity Framework

This demo is a .NET application that uses the Semantic Kernel for function calling in order to demonstrate ai chats about student metadata received by Entity Framework.

 The Semantic Kernel is a part of Microsoft's OpenAI framework, which is designed to facilitate the development of AI applications.

The Student class in the Models directory and the ApplicationDbContext class in the Data directory are used to provide the Entity Framework data that is used in function calling. The Semantic Kernel is used to process and interpret this data in a meaningful way. It could be used to perform complex tasks such as understanding natural language queries about the data, making predictions based on the data, or identifying patterns in the data.

The project is designed for deployment on Azure Container Apps, as suggested by the links in the readme.md file. This means the application is designed to be scalable and to run efficiently in a cloud environment.

# Deploy to Azure Container Apps

[create-container-app.azcli](create-container-app.azcli) is written in Azure CLI (Command Line Interface), a command-line tool for managing Azure resources. It's used to automate tasks and scripts in Azure.

Here's a step-by-step explanation of what the script does:

1. It sets up several environment variables that will be used throughout the script. These include the environment (`env`), resource group (`grp`), location (`loc`), Azure Container Registry (`acr`), Azure Container Apps environment (`acaenv`), and application name (`app`).

2. It creates a new resource group in Azure with the name and location specified by the `grp` and `loc` variables.

3. It creates a new Azure Container Registry (ACR) in the resource group, with the name specified by the `acr` variable. The `--sku Basic` option sets the tier of the ACR to Basic, and `--admin-enabled true` enables the admin user for the ACR.

4. It logs into the ACR using the `az acr login` command.

5. It retrieves the password for the ACR and stores it in the `acrPWD` variable.

6. It retrieves the fully qualified domain name (FQDN) of the ACR and stores it in the `srcFQN` variable.

7. It changes the current directory to the application directory (`cd $app`).

8. It builds a Docker image from the Dockerfile in the current directory and pushes it to the ACR.

9. It changes back to the previous directory (`cd ..`).

10. It creates a new Azure Container Apps environment with the name specified by the `acaenv` variable.

11. It creates a new Azure Container App with the specified name, in the specified resource group, using the Docker image stored in the ACR. It also sets the target port for the app to 8080 and configures the app to be accessible externally. It uses the ACR credentials to pull the Docker image.
