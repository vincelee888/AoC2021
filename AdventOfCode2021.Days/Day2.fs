namespace AdventOfCode2021.Days

open System

module Day2 =
    type Sub = {
        Horiz: int
        Depth: int
        Aim: int
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
    
    let performCommand2 (sub:Sub, command:Option<Command>) =
        match command with
        | Some(Forward, amount) -> { sub with Horiz = sub.Horiz + amount; Depth = sub.Depth + sub.Aim * amount }
        | Some(Down, amount) -> { sub with Aim = sub.Aim + amount }
        | Some(Up, amount) -> { sub with Aim = (sub.Aim - amount) }
        | _ -> sub
            
    let move (sub:Sub, commands:List<Command>) =
        List.fold (fun acc command -> performCommand(acc, Some(command))) sub commands
            
    let move2 (sub:Sub, commands:List<Command>) =
        List.fold (fun acc command -> performCommand2(acc, Some(command))) sub commands
        
    let mapDirection (input:string) =
        match input with
        | "forward" -> Some(Forward)
        | "down" -> Some(Down)
        | "up" -> Some(Up)
        | _ -> None 
        
    let parseCommand (line:String): Command =
        let parts = line.Split " "
        let direction = mapDirection parts.[0]
        let amount = parts.[1] |> int
        
        (direction.Value, amount)