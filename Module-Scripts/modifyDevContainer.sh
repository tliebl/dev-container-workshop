#!/bin/bash

# Path to the devcontainer.json
DEVCONTAINER_PATH="./.devcontainer/devcontainer.json"

# Use sed to replace the .NET version to an incorrect one
sed -i 's/"version": "8.0.100"/"version": "9.9.9"/' $DEVCONTAINER_PATH

echo "devcontainer.json has been modified."
