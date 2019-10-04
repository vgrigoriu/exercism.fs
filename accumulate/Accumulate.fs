module Accumulate

let rec accumulate (func: 'a -> 'b) (input: 'a list): 'b list =
    match input with
    | [] -> []
    | head::tail -> func(head)::accumulate(func)(tail)
