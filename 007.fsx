open System
open System.Collections
open System.Numerics

let primes max = 
    let array = new BitArray(max, true);
    let lastp = Math.Sqrt(float max) |> int
    for p in 2..lastp+1 do
        if array.Get(p) then
            for pm in p*2..p..max-1 do
                array.Set(pm, false);
    seq { for i in 2..max-1 do if array.Get(i) then yield i }

let p = primes 105000
        |> List.ofSeq

p.[10001]
