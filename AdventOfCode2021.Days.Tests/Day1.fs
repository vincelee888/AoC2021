module AdventOfCode2021.Days.Tests.Day1

open AdventOfCode2021.Days
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
    
    