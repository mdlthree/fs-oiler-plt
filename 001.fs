let seqAdd x = x * (x + 1) / 2
let iPart x y = (x - x % y)/y

let M = 999
let a = 3
let b = 5
let c = a * b

((seqAdd (iPart M a))*a) + ((seqAdd (iPart M b))*b) - ((seqAdd (iPart M c))*c)
