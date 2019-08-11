open System.ServiceProcess
open FSharp.Service

module Program =

    [<EntryPoint>]
    let main (args) = 
        let service = new TestService()
        let servicesToRun = [| service :> ServiceBase |]
        ServiceBase.Run(servicesToRun)

        0
