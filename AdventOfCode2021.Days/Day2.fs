namespace AdventOfCode2021.Days

open System

module Day2 =
    type Sub = {
        Horiz: int
        Depth: int
    }
    
    type Direction =
        | Forward
        | Down
        | Up
        
    type Command = Direction * int
    
    let performCommand (sub:Sub, command:Option<Command>) =
        match command with
        | Some(Forward, amount) -> { sub with Horiz = sub.Horiz + amount }
        | Some(Down, amount) -> { sub with Depth = sub.Depth + amount }
        | Some(Up, amount) -> { sub with Depth = (sub.Depth - amount) }
        | _ -> sub
            
    let move (sub:Sub, commands:List<Command>) =
        List.fold (fun acc command -> performCommand(acc, Some(command))) sub commands
        
    let mapDirection (input:string) =
        match input with
        | "forward" -> Some(Forward)
        | "down" -> Some(Down)
        | "up" -> Some(Up)
        | _ -> None 
        
    let parseCommand (line:String): Command =
        let parts = line.Split " "
        let command = mapDirection parts.[0]
        let amount = parts.[1] |> int
        
        (command.Value, amount)