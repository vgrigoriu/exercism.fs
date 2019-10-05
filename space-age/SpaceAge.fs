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

let age (planet: Planet) (seconds: int64): float = failwith "You need to implement this function."