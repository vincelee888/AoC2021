#r "./bin/Debug/net5.0/AdventOfCode2021.Days.dll"

let toInt (readings:seq<string>) =
    Seq.map (fun s -> s |> int) readings
let readings = System.IO.File.ReadLines("./AdventOfCode2021.Runners/bin/Debug/net5.0/Day1PuzzleInput.txt")

readings
|> toInt
|> Seq.toList
|> AdventOfCode2021.Days.Day1.totalIncreases