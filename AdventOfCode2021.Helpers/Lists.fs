namespace AdventOfCode2021.Helpers

module Lists =
    let first = function
        | head :: _ -> Some head
        | _ -> None
