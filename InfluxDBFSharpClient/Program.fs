open AdysTech.InfluxDB.Client.Net
//open System.Collections.Concurrent

//let events = ConcurrentQueue<IInfluxDatapoint>()
let event1 = InfluxDatapoint<'T>()
let field1 = InfluxValueField(42.99) // :> IComparable<InfluxValueField>
do event1.Fields.["amountRequestedUSD"] <- field1 // //Error	FS0001	The type 'InfluxValueField' is not compatible with the type 'IComparable<InfluxValueField>'.
//let event2 = InfluxDatapoint<double>()
//do events.Enqueue(event1)
//do events.Enqueue(event2)

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
