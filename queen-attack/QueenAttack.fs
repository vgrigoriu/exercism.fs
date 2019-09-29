module QueenAttack

let create (position: int * int) =
    let row, column = position
    0 < row && row < 8

let canAttack (queen1: int * int) (queen2: int * int) = failwith "You need to implement this function."