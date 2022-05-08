namespace Minesweeper

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

module MineItem =
    let ToString v =
        match v with
        | Covered _ -> "."
        | Three -> "3"
