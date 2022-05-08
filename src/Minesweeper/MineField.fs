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
        let itemsWithBomb items n =
            items |> Seq.updateAt n (Covered Bomb)
        
        let itemsWithBombs w h b =
            let mutable ret = items w h 
            for i in randoms w h b do
                ret <- itemsWithBomb ret i
            ret
        
        match v with
        | Setup (w, h, b) -> Playing (w, h, (itemsWithBombs w h b))
        | x -> x
