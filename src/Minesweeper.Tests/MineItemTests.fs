module MineItemTests

open System
open Xunit
open Minesweeper
open Minesweeper.MineItem

[<Fact>]
let ``Should number is 3`` () =
    let sut = Three
    let ret = toString sut
    Assert.Equal("3", ret)

[<Fact>]
let CoveredSpec() =
    let sut = Covered Zero
    let ret = toString sut
    Assert.Equal(".", ret)

[<Fact>]
let AddSpec() =
    let sut = Covered One
    let ret = add sut
    Assert.Equal(Two, match ret with Covered x -> x)

[<Fact>]
let ClickSpec() =
    let sut = Covered Two
    let ret = click sut
    Assert.Equal(Two, ret)

[<Fact>]
let ClickSpec2() =
    let sut = Four
    let ret = click sut
    Assert.Equal(Four, ret)
