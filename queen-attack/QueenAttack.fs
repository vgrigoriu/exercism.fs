﻿module QueenAttack

let create (position: int * int) =
    let row, column = position
    0 < row && row < 8 && 0 < column && column < 8

let canAttack (queen1: int * int) (queen2: int * int) =
    false