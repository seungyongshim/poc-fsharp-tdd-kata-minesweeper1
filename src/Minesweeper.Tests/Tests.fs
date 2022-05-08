module Tests

open System
open Xunit
open Minesweeper

[<Fact>]
let ``Should number is 3`` () =
    let sut = Three
    let ret = MineItem.ToString sut
    Assert.Equal("3", ret)

