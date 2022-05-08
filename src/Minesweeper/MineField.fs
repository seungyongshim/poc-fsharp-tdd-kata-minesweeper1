namespace Minesweeper

open FSharpPlus.Data
open Microsoft.FSharp.Collections
open System
open System.Security.Cryptography

type MineField =
   | Setup of width : int * height : int * bombs : int
   | Playing of width : int * height : int * seq<MineItem> 
   | Win
   | Loose


module MineField =
    let randoms w h t =
        Seq.initInfinite(fun x -> RandomNumberGenerator.GetInt32(w * h))
        |> Seq.distinct
        |> Seq.take t
        |> Seq.toArray

    let items x y =
        seq {0 .. x * y}
        |> Seq.map (fun x -> Covered Zero)

    let setup v =
        let itemsWithBombs w h b =
            let bombPos = randoms w h b
            (items w h)
            |> Seq.indexed
            // 이부분을 map2로 수정 할 수 있을지도
            |> Seq.map(fun (i, l) ->
                if bombPos |> Seq.contains(i)
                then match l with
                     | Covered _ -> Covered Bomb
                     | x -> Bomb
                else l)
        match v with
        | Setup (w, h, b) -> Playing (w, h, (itemsWithBombs w h b))
        | x -> x
