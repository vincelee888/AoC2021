namespace AdventOfCode2021.Helpers

module Lists =
    let first = function
        | first :: _ -> Some first
        | _ -> None
        
    let second = function
        | _ :: second :: _ -> Some second
        | _ -> None
        
    let third = function
        | _ :: _ :: third :: _ -> Some third
        | _ -> None
