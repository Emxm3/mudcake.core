
### Packages Install script
Run this in Package manager console when developing new plugins

``` 
Install-Package Microsoft.AspNetCore.Components.Web -Version 8.0.4
Install-Package Microsoft.AspNetCore.Http.Connections.Client -Version 8.0.4
Install-Package Microsoft.AspNetCore.Http.Connections.Common -Version 8.0.4
Install-Package Microsoft.AspNetCore.SignalR.Client -Version 8.0.4
Install-Package Microsoft.AspNetCore.SignalR.Client.Core -Version 8.0.4
Install-Package Microsoft.AspNetCore.SignalR.Common -Version 8.0.4
Install-Package Microsoft.AspNetCore.SignalR.Protocols.Json -Version 8.0.4
Install-Package MudBlazor -Version 6.19.1

```

### Post-build Event
Place this in the Post-Build events of a plugins project properties
```
IF EXIST "$(ProjectDir)..\MudCake\bin\Debug\net8.0" xcopy /y "$(TargetDir)$(ProjectName).dll" "$(ProjectDir)..\MudCake\bin\Debug\net8.0" || exit /b -1
```
Remember to set it to run "Always"