A windows service template for F# developer [REFERENCE](https://blogs.msdn.microsoft.com/mcsuksoldev/2011/05/31/f-windows-application-template-for-windows-service/)

## Usage

```powershell
git clone https://github.com/nodew/FSharpService.git

cd FSharpService

MsBuild
```

### Install service

```powershell
installutil .\bin\Debug\net472\FSharpService.exe
```

### Uninstall service

```powershell
installutil /u .\bin\Debug\net472\FSharpService.exe
```