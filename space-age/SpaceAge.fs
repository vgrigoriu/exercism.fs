module SpaceAge

// TODO: define the Planet type
type Planet =
    | Earth
    | Mercury
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

let private secondsInYear(planet: Planet): float =
    match planet with
        | Earth -> 365.25 * 24.0 * 3600.0

let age (planet: Planet) (seconds: int64): float = (float seconds) / (secondsInYear planet)
