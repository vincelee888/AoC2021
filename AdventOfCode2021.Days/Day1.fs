namespace AdventOfCode2021.Days

module Day1 =
    let isIncrease (first, second) =
        second > first
    
    let countIncrease result =
        match result with
        | true -> 1
        | false -> 0

    let rec totalIncreases readings =
        match readings with
        | head :: next :: rest -> countIncrease (isIncrease(head, next)) + totalIncreases (next :: rest)
        | _ -> 0