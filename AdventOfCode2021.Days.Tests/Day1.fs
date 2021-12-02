module AdventOfCode2021.Days.Tests.Day1

open AdventOfCode2021.Days
open AdventOfCode2021.Helpers
open NUnit.Framework

[<Test>]
let ``isIncrease returns true if second item is greater`` () =
    Assert.IsTrue(Day1.isIncrease(0, 1))

[<Test>]
let ``isIncrease returns false if second item is not greater`` () =
    Assert.IsFalse(Day1.isIncrease(0, 0))
    
[<Test>]
let ``given no Readings, totalIncreases is 0`` () =
    Assert.AreEqual(0, Day1.totalIncreases [])
    
[<Test>]
let ``given one Reading, totalIncreases is 0`` () =
    Assert.AreEqual(0, Day1.totalIncreases [0])
    
[<Test>]
let ``given all equal Readings, totalIncreases is 0`` () =
    Assert.AreEqual(0, Day1.totalIncreases [0; 0; 0])
    
[<Test>]
let ``given fluctuating Readings, totalIncreases is correct`` () =
    Assert.AreEqual(2, Day1.totalIncreases [0; 1; 1; 0; 2])
    
[<Test>]
let ``given continually ascending Readings, totalIncreases is total readings - 1`` () =
    let continuallyIncreasing = [1..10]
    Assert.AreEqual(List.length continuallyIncreasing - 1, Day1.totalIncreases continuallyIncreasing)
    
[<Test>]
let ``given 0 Readings, mapScanningWindowTotals returns 0 items`` () =
    let result = Day1.mapScanningWindowTotals []
    Assert.AreEqual(0, List.length(result))
    
[<Test>]
let ``given 1 Reading, mapScanningWindowTotals returns 1 item`` () =
    let result = Day1.mapScanningWindowTotals [1]
    Assert.AreEqual(1, List.length(result))
    
[<Test>]
let ``given 3 Readings, mapScanningWindowTotals first item is sum of first 3 readings`` () =
    let readings = [1; 5; 10]
    
    let result = Day1.mapScanningWindowTotals readings
    let first = Lists.first result
        
    Assert.AreEqual(List.sum readings, first.Value)

    
    