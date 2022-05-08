module Tests

open System
open Xunit
open Minesweeper

[<Fact>]
let ``Should number is 3`` () =
    let sut = Three
    let ret = MineItem.ToString sut
    Assert.Equal("3", ret)

[<Fact>]
let CoveredSpec() =
    let sut = Covered Zero
    let ret = MineItem.ToString sut
    Assert.Equal(".", ret)

[<Fact>]
let AddSpec() =
    let sut = Covered One
    let ret = MineItem.add sut
    Assert.Equal(Two, match ret with Covered x -> x)
