module Bob

let response (input: string): string =
    let isShout = input |> Seq.filter System.Char.IsLetter |> Seq.forall System.Char.IsUpper
    let isQuestion = (input |> Seq.last) = '?'
    if isQuestion && isShout then
        "Calm down, I know what I'm doing!"
    else if isQuestion then
        "Sure."
    else if isShout then
        "Whoa, chill out!"
    else
        "Whatever."