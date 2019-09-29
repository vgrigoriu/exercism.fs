module QueenAttack

let create (position: int * int) =
    let row, column = position
    0 < row && row < 8 && 0 < column && column < 8

let canAttack (queen1: int * int) (queen2: int * int) =
    let row1, column1 = queen1
    let row2, column2 = queen2
    row1 = row2 || column1 = column2 || abs (row1 - row2) = abs (column2 - column1)