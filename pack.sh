#!/bin/bash

nuget pack ./src/IdentityBase/IdentityBase.ServiceBase.nuspec -OutputDirectory ./artifacts/packages -version $APPVEYOR_BUILD_VERSION
#nuget pack ./src/IdentityBase/IdentityBase.ServiceBase.Events.RabbitMQ.nuspec -OutputDirectory ./artifacts/packages -version $APPVEYOR_BUILD_VERSION
nuget pack ./src/IdentityBase/IdentityBase.ServiceBase.Notification.SendGrid.nuspec -OutputDirectory ./artifacts/packages -version $APPVEYOR_BUILD_VERSION
nuget pack ./src/IdentityBase/IdentityBase.ServiceBase.Notification.Smtp.nuspec -OutputDirectory ./artifacts/packages -version $APPVEYOR_BUILD_VERSION
nuget pack ./src/IdentityBase/IdentityBase.ServiceBase.Notification.Twilio.nuspec -OutputDirectory ./artifacts/packages -version $APPVEYOR_BUILD_VERSION