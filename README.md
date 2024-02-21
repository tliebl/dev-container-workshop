# Introduction

Welcome to the Remote Dev Container Workshop! This project is designed to empower developers with the skills and knowledge needed to utilize dev containers effectively in their development workflows. By leveraging Visual Studio Code and Docker, this workshop introduces participants to a seamless development environment setup that enhances productivity and ensures consistency across teams.

## Getting Started

This section will guide you through the process of getting the workshop code running on your system.

### Installation Process

1. **Prerequisites**:
    - Install [Docker](https://docs.docker.com/get-docker/) on your system.
    - Install [Visual Studio Code](https://code.visualstudio.com/Download).
    - Install the [Remote - Containers](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers) extension for VS Code.

2. **Clone the Repository into a Container Volume**:
    - Open Visual Studio Code.
    - Press `F1` to open the Command Palette or use `Ctrl+Shift+P`.
    - Type and select "Remote-Containers: Clone Repository in Container Volume..."
    - Enter the URL of this repository when prompted.
    - Select the appropriate dev container configuration when asked. Visual Studio Code will then build the dev container and clone the repository into a volume, completely within Docker.

3. **Open in VS Code**:
    - Open the cloned repository folder in Visual Studio Code.
    - VS Code might prompt you to reopen the folder in a container. Select "Reopen in Container" to start the dev container setup. If not prompted, you can open the Command Palette (`Ctrl+Shift+P`) and select "Remote-Containers: Open Folder in Container..."

### Software Dependencies

- Docker: Used for creating isolated development environments.
- .NET SDK 8.0.100: Required for building and running the .NET application.
- Visual Studio Code Extensions (included in the dev container setup):
    - C# (ms-dotnettools.csharp)
    - GitHub Copilot (GitHub.copilot)
    - Additional extensions as per project requirements.

### Latest Releases

Stay tuned for updates and latest release information.

### API References

Refer to the [Microsoft .NET documentation](https://docs.microsoft.com/en-us/dotnet/) for detailed API references and development guides.

## Build and Test

To build and test the project:

1. **Build the Project**:
    - Use the `dotnet build` command in the integrated terminal within VS Code to compile the project.

2. **Run Tests**:
    - Execute `dotnet test` to run the unit tests and verify the application's functionality.

## Contribute

We welcome contributions to enhance this workshop project! Whether it's adding new features, improving documentation, or reporting issues, your input is valuable. Here's how you can contribute:

1. **Fork the Repository**: Start by forking the repository to your GitHub account.
2. **Make Your Changes**: Implement your changes or improvements in your forked version.
3. **Submit a Pull Request**: Create a pull request against the main repository with a clear description of your changes and the benefits they bring.
4. **Code Review**: Your pull request will be reviewed, and feedback may be provided to ensure quality and consistency.

## Learn More

For more detailed instructions on working with dev containers and Visual Studio Code, visit the [VS Code Documentation on Developing inside a Container](https://code.visualstudio.com/docs/remote/containers).

