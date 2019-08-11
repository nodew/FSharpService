namespace FSharp.Service

open System.Diagnostics
open System.ServiceProcess

type public TestService() as service =
    inherit ServiceBase()

    let eventLog = new EventLog();

    let initService = 
        service.ServiceName <- "TestService"

        let eventSource = "TestService"
        let logName = "Application"

        if not (EventLog.SourceExists(eventSource)) then
            EventLog.CreateEventSource(eventSource, logName)

        eventLog.Source <- eventSource
        eventLog.Log <- logName

    do 
        initService

    override service.OnStart(args:string[]) =
        base.OnStart(args)
        eventLog.WriteEntry("Service Started")

    override service.OnStop() =
        base.OnStop()
        eventLog.WriteEntry("Service Ended")
