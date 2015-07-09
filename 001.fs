// first solution

let seqAdd x = x * (x + 1) / 2
let iPart x y = (x - x % y)/y

let M = 999
let a = 3
let b = 5
let c = a * b

((seqAdd (iPart M a))*a) + ((seqAdd (iPart M b))*b) - ((seqAdd (iPart M c))*c)

// second solution

let arithmeticSum multiples maxInt = 
    List.sum([multiples .. multiples .. maxInt])

printfn "%i" (arithmeticSum 3 1000 + arithmeticSum 5 1000 - arithmeticSum 15 1000)
