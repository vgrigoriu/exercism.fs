module Bob

let response (input: string): string =
    let letters = input |> Seq.filter System.Char.IsLetter
    let isShout = not (Seq.isEmpty(letters)) && letters |> Seq.forall System.Char.IsUpper
    let isSilence = input.Trim() = ""
    let isQuestion = not (isSilence) && (input.Trim() |> Seq.last) = '?'

    if isQuestion && isShout then
        "Calm down, I know what I'm doing!"
    else if isQuestion then
        "Sure."
    else if isShout then
        "Whoa, chill out!"
    else if isSilence then
        "Fine. Be that way!"
    else
        "Whatever."