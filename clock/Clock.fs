module Clock

type Clock = {Hours: int; Minutes: int}

let private modulo n m = ((n % m) + m) % m

let create hours minutes =
    let normalizedMinutes = modulo minutes 60
    let totalHours = hours + (minutes - normalizedMinutes) / 60
    let normalizedHours = modulo totalHours 24
    { Hours = normalizedHours; Minutes = normalizedMinutes }

let add minutes (clock: Clock) = create clock.Hours (clock.Minutes + minutes)

let subtract minutes (clock: Clock) = add -minutes clock

let display (clock: Clock) = sprintf "%02i:%02i" clock.Hours clock.Minutes
