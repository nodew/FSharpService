namespace FSharp.Service

open System.Configuration.Install
open System.ComponentModel
open System.ServiceProcess

[<RunInstaller(true)>]
type public ProjectInstaller() as installer =
    inherit Installer()
    let processInstaller = new ServiceProcessInstaller();
    let serviceInstaller = new ServiceInstaller();
    let initInstaller =
        processInstaller.Account <- ServiceAccount.LocalSystem
        processInstaller.Password <- null
        processInstaller.Username <- null

        serviceInstaller.Description <- "A windows service demo for F# developer"
        serviceInstaller.ServiceName <- "TestService"
        serviceInstaller.StartType <- ServiceStartMode.Automatic;

    let installers = [| processInstaller :> Installer; serviceInstaller :> Installer|]
    do installer.Installers.AddRange(installers) 
    do initInstaller
