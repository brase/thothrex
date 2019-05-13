// Learn more about F# at http://fsharp.org

open System
open Thoth.Json.Net

type MyRecType =
    { Name: string
      Children: MyRecType List }

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let model = { Name = "This will fail"
                  Children = [] }
    let json = Encode.Auto.toString(0, model)

    sprintf "%s" json
    |> ignore

    0 // return an integer exit code
