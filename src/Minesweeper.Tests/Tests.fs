module Tests

open System
open Xunit
open Minesweeper

[<Fact>]
let ``Should number is 3`` () =
    let sut = MineItem(3)
    Assert.Equal(3, sut.NearBombsCount)
