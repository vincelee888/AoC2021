#r "./bin/Debug/net5.0/AdventOfCode2021.Days.dll"

let exampleData = System.IO.File.ReadLines("./AdventOfCode2021.Runners/bin/Debug/net5.0/Day2ExampleData.txt")
let puzzleData = System.IO.File.ReadLines("./AdventOfCode2021.Runners/bin/Debug/net5.0/Day2PuzzleInput.txt")


let sub:AdventOfCode2021.Days.Day2.Sub = {
    Horiz = 0
    Depth = 0
}

let c = (puzzleData
|> Seq.toList
|> List.map AdventOfCode2021.Days.Day2.parseCommand)

let result = AdventOfCode2021.Days.Day2.move (sub, c)

let answer = result.Depth * result.Horiz