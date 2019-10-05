module Accumulate

let rec accumulate (func: 'a -> 'b) (input: 'a list): 'b list =
    let rec go(input, acc) =
        match input with
        | [] -> acc
        | head::tail -> go(tail, func(head)::acc)

    go(input, []) |> List.rev
