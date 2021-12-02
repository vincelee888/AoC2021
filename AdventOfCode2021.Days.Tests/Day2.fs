module AdventOfCode2021.Days.Tests.Day2

open AdventOfCode2021.Days
open NUnit.Framework

let sub:Day2.Sub = {
    Horiz = 0
    Depth = 0
}

let newSub:Day2.Sub =
    {
        sub with Horiz = sub.Horiz; Depth = sub.Depth;
    }
    
[<Test>]
let ``move with no commands returns original sub`` () =
    let result = Day2.move(newSub, [])
    
    Assert.AreEqual(sub.Horiz, result.Horiz)
    Assert.AreEqual(sub.Depth, result.Depth)

[<Test>]
let ``forward command increases horiz`` () =
    let result = Day2.move(newSub, [(Day2.Forward, 5)])
    
    Assert.AreEqual(5, result.Horiz)
    Assert.AreEqual(sub.Depth, result.Depth)

[<Test>]
let ``down command increases depth`` () =
    let result = Day2.move(newSub, [(Day2.Down, 5)])
    
    Assert.AreEqual(sub.Horiz, result.Horiz)
    Assert.AreEqual(5, result.Depth)

[<Test>]
let ``up command decreases depth`` () =
    let result = Day2.move(newSub, [(Day2.Up, 5)])
    
    Assert.AreEqual(sub.Horiz, result.Horiz)
    Assert.AreEqual(-5, result.Depth)
