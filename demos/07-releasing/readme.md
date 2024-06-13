# Releasing to Production

[Azure Container Apps](https://learn.microsoft.com/en-us/azure/container-apps/overview)

[Azure Container Apps Dynamic Sessions](https://github.com/Azure-Samples/container-apps-dynamic-sessions-samples?tab=readme-ov-file)

[Understanding AI plugins in Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/agents/plugins/?tabs=Csharp)

[Semantic Kernel with React Frontend on ACA](https://techcommunity.microsoft.com/t5/apps-on-azure/semantic-kernel-container-apps-with-react-and-python/m-p/3958787)

## Demos

This project is a .NET application that uses the Semantic Kernel for function calling. The Semantic Kernel is a part of Microsoft's OpenAI framework, which is designed to facilitate the development of AI applications.

The Student class in the Models directory and the ApplicationDbContext class in the Data directory are used to provide the Entity Framework data that is used in function calling. The Semantic Kernel is used to process and interpret this data in a meaningful way. It could be used to perform complex tasks such as understanding natural language queries about the data, making predictions based on the data, or identifying patterns in the data.

The project is designed for deployment on Azure Container Apps, as suggested by the links in the readme.md file. This means the application is designed to be scalable and to run efficiently in a cloud environment.

- Semantic Kernel Function Calling Entity Framework to ACA
- Deploy to Azure Container Apps