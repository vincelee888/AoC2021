#r "./bin/Debug/net5.0/AdventOfCode2021.Days.dll"

let exampleData = System.IO.File.ReadLines("./AdventOfCode2021.Runners/bin/Debug/net5.0/Day2ExampleData.txt")
let puzzleData = System.IO.File.ReadLines("./AdventOfCode2021.Runners/bin/Debug/net5.0/Day2PuzzleInput.txt")


let sub:AdventOfCode2021.Days.Day2.Sub = {
    Horiz = 0
    Depth = 0
}

let lines = Seq.toList puzzleData
let parsedCommands = List.map AdventOfCode2021.Days.Day2.parseCommand lines
let rec getRealCommands commands =
    match commands with
    | (Some(command), amount) :: tail -> (command, amount) :: getRealCommands tail
    | (None, _) :: tail -> getRealCommands tail
    | [] -> []

let result = AdventOfCode2021.Days.Day2.move (sub, parsedCommands)

let answer = result.Depth * result.Horiz