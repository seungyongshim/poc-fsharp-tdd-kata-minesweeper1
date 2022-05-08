namespace Minesweeper

module MineItem =
    type MineItem =
        | Covered of MineItem
        | Bomb
        | One
        | Two
        | Three
        | Four
        | Five
        | Six
        | Seven
        | Eight

    let mineItemToString v =
        match v with
        | Covered _ -> "."
        | Three -> "3"
