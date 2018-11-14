# Azure Infrastructure

Include capture...

### Step 1: Implement Azure SQL Database

Pending...

### Step 2: Implement Azure Storage

Pending...

### Step 3: Implement Web API App Service

Pending...v

### Step 4: Implement Web App Service

Pending...

### Step 5: Implement Conginive Services

Pending...

# Skynet
[Skynet](https://github.com/sergiobarriel/events/tree/master/azure-storage-15-nov-2018/src/Skynet) solution contains projects:
- Web API: build with .NET Core
- Web: build with VUE.js


### Step 1: Publish Web API

Open Package Manager Console an set default project to Skynet.Infrastructure.Persistence. Then type the following command to update database:
`PM> update-database`

Pending...
Include capture...

### Step 2: Publish Web

Pending...

# SkynetEye
[SkynetEye](https://github.com/sergiobarriel/events/tree/master/azure-storage-15-nov-2018/src/SkynetEye) solution contains contains the code that must be deploy on Raspberry PI 3

### Step 1: Make your device (do it yourself)
- Buy [Raspberry PI 3](https://www.raspberrypi.org/products/raspberry-pi-3-model-b/)
- Buy [Camera module V2](https://www.raspberrypi.org/products/camera-module-v2/)

### Step 2: Install NET Core Runtime on Raspberry PI 3

On your Raspberry PI 3 terminal type de following comands: 

`> sudo apt-get install curl libunwind8 gettext`
`> curl -sSL -o dotnet.tar.gz https://dotnetcli.blob.core.windows.net/dotnet/Runtime/master/dotnet-runtime-latest-linux-arm.tar.gz`
`> sudo mkdir -p /opt/dotnet && sudo tar zxf dotnet.tar.gz -C `
`> sudo ln -s /opt/dotnet/dotnet /usr/local/bin`

`> dotnet --help.`

If you have any doubt, read this [article](https://blogs.msdn.microsoft.com/david/2017/07/20/setting_up_raspian_and_dotnet_core_2_0_on_a_raspberry_pi/) from MSDN

### Step 3: Deploy application

`> dotnet publish -r linux-arm`

### Step 4: Run application

Pending...

# SkynetPI
[SkynetTarget](https://github.com/sergiobarriel/events/tree/master/azure-storage-15-nov-2018/src/SkynetTarget) solution contains contains JAVA code that using Azure Storage SDK to publish messages on Azure Storage Queue

### Step 1: Build application 
### Step 2: Run application

To run JAVA application type command on output directory:

`> java Skynet`