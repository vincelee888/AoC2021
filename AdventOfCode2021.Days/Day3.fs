namespace AdventOfCode2021.Days

open System
open AdventOfCode2021.Helpers

module Day3 =
    let strToList(line:string) =
        line
        |> Seq.toList
        |> List.map (fun c -> c.ToString())
        |> List.map Int32.TryParse
        |> List.map (fun o -> if fst o then snd o else -1)
        
    let getCol index matrix =
        matrix
        |> List.map (fun row -> (List.toArray row))
        |> Seq.map (fun row -> row.[index])
        
    let transpose(matrix:List<List<int>>): List<List<int>> =
        let first = Lists.first matrix
        
        let totalCols = first.Value.Length
        
        [0 .. totalCols - 1]
        |> List.map (fun colIndex -> Seq.toList(getCol colIndex matrix))
        
    let getMostCommonValue (content: List<int>) =
        let sorted = (content 
        |> List.groupBy (fun i -> i)
        |> List.sortByDescending(fun g -> List.length (snd g)))
        
        fst (Lists.first sorted).Value
        
    let getBitString content =
        content
            |> List.map (fun i -> i.ToString())
            |> String.concat ""
        
    let getGammaRate (content: List<int>) =
        let bitString = getBitString content
        Convert.ToInt32(bitString, 2)
        
    let invertChar = function
        | '1' -> '0'
        | '0' -> '1'
        | _ -> 'x'
        
    
    let invert (input:string): string =
        input
        |> Seq.toList
        |> List.map invertChar
        |> List.map (fun c -> c.ToString())
        |> String.concat ""
        
    let getEpsilonRate (content: List<int>) =
        let bitString = getBitString content
        Convert.ToInt32(invert bitString, 2)
        
    let getRateInput input =
        input
        |> List.map(fun row -> getMostCommonValue row)