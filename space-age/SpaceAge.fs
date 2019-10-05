module SpaceAge

type Planet =
    | Earth
    | Mercury
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

let private earthYear = 365.25 * 24.0 * 3600.0

let rec private secondsInYear(planet: Planet): float =
    match planet with
        | Earth -> 1.0 * earthYear
        | Mercury -> 0.2408467 * earthYear
        | Venus -> 0.61519726 * earthYear
        | Mars -> 1.8808158 * earthYear
        | Jupiter -> 11.862615 * earthYear
        | Saturn -> 29.447498 * earthYear
        | Uranus -> 84.016846 * earthYear
        | Neptune -> 164.79132 * earthYear

let age (planet: Planet) (seconds: int64): float = (float seconds) / (secondsInYear planet)
