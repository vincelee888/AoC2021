namespace AdventOfCode2021.Days

module Day1 =
    let isIncrease (first, second) =
        second > first
    
    let countIncrease = function 
        | true -> 1
        | false -> 0

    let rec totalIncreases = function
        | head :: next :: rest -> countIncrease (isIncrease(head, next)) + totalIncreases (next :: rest)
        | _ -> 0
        
    let getWindowValue = function
        | first :: second :: third :: _ -> [(first + second + third)]
        | first :: second :: _ -> [(first + second)]
        | first :: _ -> [(first)]
        | _ -> []
        
    let rec mapScanningWindowTotals readings =
        match readings with
        | _ :: second :: third :: rest -> (getWindowValue readings) @ mapScanningWindowTotals (second :: third :: rest)
        | first :: second :: rest -> [(first + second)]  @ mapScanningWindowTotals (second :: rest)
        | first :: _ -> [(first)]
        | _ -> []