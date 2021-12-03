#r "./bin/Debug/net5.0/AdventOfCode2021.Days.dll"

let exampleData = System.IO.File.ReadLines("./AdventOfCode2021.Runners/bin/Debug/net5.0/Day3ExampleData.txt")
let puzzleData = System.IO.File.ReadLines("./AdventOfCode2021.Runners/bin/Debug/net5.0/Day3PuzzleInput.txt")

let result = (
                 puzzleData
                 |> Seq.toList
                 |> List.map AdventOfCode2021.Days.Day3.strToList
             )
             |> AdventOfCode2021.Days.Day3.transpose
             |> AdventOfCode2021.Days.Day3.getRateInput

let gamma = AdventOfCode2021.Days.Day3.getGammaRate result
let epsilon = AdventOfCode2021.Days.Day3.getEpsilonRate result

let x = gamma * epsilon