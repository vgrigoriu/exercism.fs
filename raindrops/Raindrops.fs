module Raindrops

let factors = [
    (3, "Pling")
    (5, "Plang")
    (7, "Plong")
]

let convert (number: int): string =
    let outputs =
        factors
        |> List.filter (fun (f, _) -> number % f = 0)
        |> List.map (fun (_, w) -> w)

    match outputs with
    | [] -> number.ToString()
    | _ -> String.concat "" outputs
