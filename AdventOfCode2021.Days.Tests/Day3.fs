module AdventOfCode2021.Days.Tests.Day3

open AdventOfCode2021.Days
open NUnit.Framework
    
[<Test>]
let ``strToList does what it says on the tin`` () =
    let input = "123"
    let result = Day3.strToList input
    CollectionAssert.AreEqual([1;2;3], result)

[<Test>]    
let ``transpose 1x1 is identity`` () =
    let input = [[1]]
    let result = Day3.transpose input
    
    CollectionAssert.AreEqual(input, result)
    
[<Test>]
let ``getCol`` () =
    let input = [
        [1;2;3]
        [4;5;6]
    ]
    let result = Day3.getCol 0 input
    
    CollectionAssert.AreEqual([1; 4], result)

[<Test>]    
let ``transpose 2x1 returns 1x2`` () =
    let input = [[1;2]]
    let result = Day3.transpose input
    let expected = [
        [1]
        [2]
    ]
    
    CollectionAssert.AreEqual(expected, result)
    
[<Test>]
let ``getMostCommonValue`` () =
    let input = [0; 1; 1]
    let result = Day3.getMostCommonValue input
    Assert.AreEqual(1, result)
    
[<Test>]
let ``getGammaRate`` () =
    let input = [1; 0]
    let result = Day3.getGammaRate input
    Assert.AreEqual(2, result)
    
[<Test>]
let ``invert bitString`` () =
    let input = "101"
    let result = Day3.invert input
    let expected = "010"
    Assert.AreEqual(expected, result)
    
[<Test>]
let ``getEpsilonRate`` () =
    let input = [1; 0]
    let result = Day3.getEpsilonRate input
    Assert.AreEqual(1, result)
    
[<Test>]
let ``getRateInput`` () =
    let transposed = [
        [1;0;1]
        [1;0;1]
    ]
    let result = Day3.getRateInput transposed
    
    CollectionAssert.AreEqual([1; 1], result)

