![](https://github.com/sergiobarriel/azure-storage-15-nov/blob/master/images/web.PNG)

[Download](https://github.com/sergiobarriel/azure-storage-15-nov/blob/master/files/presentation.pptx) PPT from presentation.

# Infrastructure

To test this application you need deploy the following resources on Microsoft Azure:

- Azure SQL
- Azure Storage
- App Service

You can help yoursef with the [ARM template](https://github.com/sergiobarriel/azure-storage-15-nov/blob/master/files/arm-template.zip)

# Skynet
[Skynet](https://github.com/sergiobarriel/azure-storage-15-nov/tree/master/src/Skynet) solution contains projects:
- [Skynet.WebAPI](https://github.com/sergiobarriel/azure-storage-15-nov/tree/master/src/Skynet/Skynet.WebAPI): Exposes methods to insert captures from Raspberry PI 3.
- [Skynet.Web](https://github.com/sergiobarriel/azure-storage-15-nov/tree/master/src/Skynet/Skynet.Web): VUE.js SPA to consume the API.


### Skynet.WebAPI 

Open Package Manager Console an set default project to Skynet.Infrastructure.Persistence. Then type the following command to update database:

`PM> update-database`

(Make sure you have set a valid connection strings for Azure Storage and Azure SQL Server in the appsettings.json file)

You can run the application on your local machine or publish on Azure App Service (this demo was configured to run on App Service accesible on http://skynet-ciber.azurewebsites.net)

![](https://github.com/sergiobarriel/azure-storage-15-nov/blob/master/images/swagger.PNG)

### Skynet.Web

To run SPA you only needs open `index.html` file on your local machine.

(This demo was configured to run on App Service accesible on http://skynet-ciber-spa.azurewebsites.net)

# Raspberry PI 3

For test this application you need:
- Buy [Raspberry PI 3](https://www.raspberrypi.org/products/raspberry-pi-3-model-b/)
- Buy [Camera module V2](https://www.raspberrypi.org/products/camera-module-v2/)

## Install NET Core SDK

On your Raspberry PI 3 terminal type de following comands: 

`> sudo apt-get install curl libunwind8 gettext`

`> curl -sSL -o dotnet.tar.gz https://dotnetcli.blob.core.windows.net/dotnet/Runtime/master/dotnet-runtime-latest-linux-arm.tar.gz`

`> sudo mkdir -p /opt/dotnet && sudo tar zxf dotnet.tar.gz -C `

`> sudo ln -s /opt/dotnet/dotnet /usr/local/bin`

`> dotnet --help.`

If you have any doubt, read this [article](https://blogs.msdn.microsoft.com/david/2017/07/20/setting_up_raspian_and_dotnet_core_2_0_on_a_raspberry_pi/) from MSDN

## SkynetPI.Eye
[SkynetEye](https://github.com/sergiobarriel/azure-storage-15-nov/tree/master/src/SkynetPI/SkynetPI.Eye) solution contains contains the code that must be deploy on Raspberry PI 3

### Step 1: Publish application

Type de following comand on solution folder:

`> dotnet publish -r linux-arm`

Copy files from `SkynetPI.Eye\bin\Debug\netcoreapp2.0\linux-arm\publish` folder to Raspberry PI 3 file system (with SSH or WinSCP)

_Ensure that appsettings.json contains correct connection string of Skynet.WebAPI endpoint_

### Step 2: Run application

Type de following comand on Raspberry PI 3 with SSH:

`dotnet SkynetPI.Eye.dll -r 8d225a2f-2bed-45a6-ae73-b756e1528948`

_Note that `-r` paramenter is de robot identifier defined on Skynet.WebAPI project_

## SkynetPI.Target
[SkynetPI.Target](https://github.com/sergiobarriel/azure-storage-15-nov/tree/master/src/SkynetPI/SkynetPI.Target) solution contains contains the code that must be deploy on Raspberry PI 3 and it using **Azure Storage SDK** to read last messages.

### Step 1: Publish application

Type de following comand on solution folder:

`> dotnet publish -r linux-arm`

Copy files from `SkynetPI.Target\bin\Debug\netcoreapp2.0\linux-arm\publish` folder to Raspberry PI 3 file system (with SSH or WinSCP)

_Ensure that appsettings.json contains correct connection string of Skynet.WebAPI endpoint_

### Step 2: Run application

Type de following comand on Raspberry PI 3 with SSH:

`dotnet SkynetPI.Target.dll`


# SkynetTarget
[SkynetTarget](https://github.com/sergiobarriel/azure-storage-15-nov/tree/master/src/SkynetTarget) solution contains contains JAVA code that using **Azure Storage SDK** to insert messages on Azure Storage Queue.

To run JAVA application type command on output directory:

`> java SkynetTarget`

_Now you can type military target names... be careful_