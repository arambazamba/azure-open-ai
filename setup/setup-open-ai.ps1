winget install -e --id Microsoft.VisualStudioCode
winget install -e --id Git.Git
winget install -e --id GitHub.cli

winget install -e --id Microsoft.DotNet.SDK.8
winget install -e --id Microsoft.AzureCLI
winget install -e --id CoreyButler.NVMforWindows

winget install -e --id Python.Python -v 3.11.0
winget install -e --id Anaconda.Miniconda3

code --install-extension github.copilot 
code --install-extension github.copilot-chat

code --install-extension ms-dotnettools.csharp
# code --install-extension ms-dotnettools.csdevkit //requires license

code --install-extension ms-toolsai.jupyter
code --install-extension ms-dotnettools.dotnet-interactive-vscode

code --install-extension prompt-flow.prompt-flow
code --install-extension ms-semantic-kernel.semantic-kernel

code --install-extension donjayamanne.python-environment-manager
code --install-extension kevinrose.vsc-python-indent
code --install-extension ms-python.python
code --install-extension ms-python.debugpy
code --install-extension ms-python.vscode-pylance
