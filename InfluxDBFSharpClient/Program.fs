open AdysTech.InfluxDB.Client.Net
open System.Collections.Concurrent

let events = ConcurrentQueue<IInfluxDatapoint>()
let event1 = InfluxDatapoint<IInfluxValueField>()
let field1a = InfluxValueField(42.99)
let field1b = InfluxValueField("a message")
let event2 = InfluxDatapoint<IInfluxValueField>()
let field2a = InfluxValueField(0.05)

let addEvents () = 
    event1.Fields.Add("amountRequestedUSD", field1a)
    event1.Fields.Add("message", field1b)
    events.Enqueue(event1)
    event2.Fields.Add("someDouble", field2a)
    events.Enqueue(event2)

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code

// <'T when 'T :> IComparable and 'T :> IComparable<'T>>
