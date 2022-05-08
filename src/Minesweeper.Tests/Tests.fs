module Tests

open System
open Xunit
open Minesweeper

[<Fact>]
let ``Should number is 3`` () =
    let sut = MineItem.Three
    let ret = MineItem.mineItemToString(sut)
    Assert.Equal("3", ret)

