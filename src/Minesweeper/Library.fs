namespace Minesweeper

type MineItem(NearBombsCount : int) =
    new() = MineItem(0)
    member this.NearBombsCount with get() = NearBombsCount
