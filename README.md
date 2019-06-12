# accounts-api-client
A client API wrapper around the Zuuse Accounts API, providing access to login and account management services.

## Generation
This project is a lightweight, code-generated wrapper around the Zuuse Accounts API.  It is generated using Autorest https://github.com/Azure/autorest/blob/master/docs/examples/generating-a-client.md in PowerShell as:

```
iwr https://accounts.azurewebsites.net/swagger/docs/v1 -o interface.xml
autorest --input-file=interface.xml --csharp --output-folder=Zuuse.Accounts.Client --namespace=Zuuse.Accounts.Client
```

Make sure to check the version in Zuuse.Accounts.Client.csproj for the NuGet package and make changes as necessary.
