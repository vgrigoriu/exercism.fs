module Clock

type Clock = {hours: int; minutes: int}

let private modulo n m = ((n % m) + m) % m

let create hours minutes =
    let minutes' = modulo minutes 60
    let hours' = hours + (minutes - minutes') / 60
    { hours = modulo hours' 24; minutes = minutes }

let add minutes (clock: Clock) = create clock.hours (clock.minutes + minutes)

let subtract minutes (clock: Clock) = create clock.hours (clock.minutes - minutes)

let display (clock: Clock) = sprintf "%02i:%02i" clock.hours clock.minutes
