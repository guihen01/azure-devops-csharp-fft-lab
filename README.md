# Azure DevOps CI/CD Pipeline for a C# FFT Console Application

This project demonstrates a complete CI/CD pipeline using Azure DevOps for a .NET 8 C# console application performing Fast Fourier Transform (FFT) calculations.

## Technologies

- C#
- .NET 8
- Azure DevOps
- YAML Pipelines
- GitHub
- xUnit
- MathNet.Numerics

## Features

- FFT computation using MathNet.Numerics
- Automated unit testing
- Azure DevOps CI pipeline
- Artifact publishing
- GitHub integration

## Pipeline Workflow

```text
GitHub
   ↓
Azure DevOps Pipeline
   ↓
dotnet restore
   ↓
dotnet build
   ↓
dotnet test
   ↓
dotnet publish
   ↓
Published Artifact

## Project Structure

```text
azure-devops-csharp-fft-lab/
│
├── src/
│   └── FftConsoleApp/
│
├── tests/
│   └── FftConsoleApp.Tests/
│
├── azure-pipelines.yml
├── FftDevOpsLab.sln
└── README.md
```

## Run Locally

```bash
dotnet build
dotnet test
dotnet run --project src/FftConsoleApp
```

## Azure DevOps

The pipeline automatically:

- restores NuGet packages
- builds the application
- runs unit tests
- publishes build artifacts

## Future Improvements

- Docker support
- Azure Container Registry (ACR)
- Azure Container Apps deployment
- Terraform integration
- Custom FFT NuGet package
