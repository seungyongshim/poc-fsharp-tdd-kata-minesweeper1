module MineFieldTests

open System
open Xunit
open Minesweeper
open Minesweeper.MineField

[<Fact>]
let randomSpec () =
    let sut = randoms 3 3 3
    let ret = sut |> Seq.length
    Assert.Equal(3, ret)

[<Fact>]
let createSpec () =
    let sut = Setup (8, 8, 3)
    let ret = setup sut 
    Assert.Equal(3, match ret with
                    | Playing (w, h, s) -> s
                    |> Seq.filter(fun x -> x = Bomb || x = Covered Bomb)
                    |> Seq.length)
