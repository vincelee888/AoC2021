#r "./bin/Debug/net5.0/AdventOfCode2021.Days.dll"

let toInt (readings:seq<string>) =
    Seq.map (fun s -> s |> int) readings
let exampleData = System.IO.File.ReadLines("./AdventOfCode2021.Runners/bin/Debug/net5.0/Day1ExampleData.txt")
let puzzleData = System.IO.File.ReadLines("./AdventOfCode2021.Runners/bin/Debug/net5.0/Day1PuzzleInput.txt")

puzzleData
|> toInt
|> Seq.toList
|> AdventOfCode2021.Days.Day1.mapScanningWindowTotals
|> AdventOfCode2021.Days.Day1.totalIncreases