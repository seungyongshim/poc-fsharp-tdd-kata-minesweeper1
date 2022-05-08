namespace Minesweeper

type MineItem =
    | Covered of MineItem
    | Bomb
    | Zero
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
        | Bomb -> "*"
        | Zero -> "0"
        | One -> "1"
        | Two -> "2"
        | Three -> "3"
        | Four -> "4"
        | Five -> "5"
        | Six -> "6"
        | Seven -> "7"
        | Eight -> "8"
    let rec add v =
        match v with
        | Covered x -> Covered (add x)
        | Bomb -> Bomb
        | Zero -> One
        | One -> Two
        | Two -> Three
        | Three -> Four
        | Four -> Five
        | Five -> Six
        | Six -> Seven
        | Seven -> Eight

