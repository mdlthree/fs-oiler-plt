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

let bigDivide d = 
    let bigD = new BigInteger(int d)
    let zero = new BigInteger(int 0)
    let remainder = 600851475143I % bigD
    if remainder = zero then
        d
    else
        0

let isFactor aSeq = Seq.map bigDivide aSeq

printfn "%i"    (
                Math.Sqrt(float 600851475143I)
                |> int
                |> primes
                |> isFactor
                |> Seq.max
                )
