module Leap

let leapYear (year: int): bool =
    let isDivisibleBy n = year % n = 0
    isDivisibleBy 4 && (not (isDivisibleBy 100) || isDivisibleBy 400)