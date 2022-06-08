open System

[<EntryPoint>]
let main argV =
    let Person =
        if argV.Length > 0 then
            argV.[0]
        else 
            "Otávio"
    printf "Hello %s from F#!" Person
    0