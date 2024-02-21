To ensure a smooth and productive experience during the workshop, please follow the steps below to set up your environment:

## Prerequisites:

- **Visual Studio Code**: Ensure you have the latest version of Visual Studio Code installed. [Download here](https://code.visualstudio.com/Download).

- **Docker**: You'll need Docker installed and running on your machine. [Get Docker](https://docs.docker.com/get-docker/).

- **Remote - Containers Extension for VS Code**: Install the 'Remote - Containers' extension from Microsoft. You can find this in the VS Code Extensions Marketplace or [install it directly here](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers).

## Getting Started:

Once you have the prerequisites in place, you're ready to clone the workshop repository into a remote container:

1. Open Visual Studio Code.
2. Access the Command Palette by pressing `Ctrl+Shift+P` (Windows/Linux) or `Cmd+Shift+P` (macOS).
3. Search for "Dev Containers: Clone Repository in Container Volume..." from the list of commands.
4. Enter the Workshop Repository URL when prompted: `https://github.com/tliebl/dev-container-workshop.git`
5. Wait for VS Code to Set Up Your Environment: This process may take a few minutes. Visual Studio Code will build the dev container and clone the repository into a Docker volume.

## What to Expect:

Your development environment will be fully configured for you, including all the necessary dependencies and tools to participate in the workshop activities. This setup ensures that everyone is on the same page, regardless of individual computer configurations.

During the Workshop, we'll dive into various challenges that will require you to utilize the skills and knowledge gained from setting up and working within your dev container. Our expert-led exercises are designed to enhance your understanding and capabilities in working with containers, providing you with hands-on experience in solving real-world development scenarios.

## Starting the Workshop UI (Blazor App)

Once your development environment is set up, follow these steps to start the Blazor application, which serves as the workshop's UI:

1. In Visual Studio Code, open a new terminal window.

2. Navigate to the `BlazorWorkshopApp` folder within the cloned repository by running the following command:

    ```bash
    cd BlazorWorkshopApp
    ```

3. Start the Blazor application by executing:

    ```bash
    dotnet run
    ```

4. Once the application is running, access the UI by opening a web browser and navigating to [http://localhost:5026](http://localhost:5026).

This will launch the Blazor Workshop UI, allowing you to interact with the application and complete the workshop activities directly through your browser. Make sure to keep the terminal running as you work through the workshop exercises.

