// problem two

let fibSeq a b max = Seq.unfold (fun (a,b) -> if (a > max) then None else Some(a, (b, a + b))) (a,b)

let evens aSeq = Seq.choose(fun x -> 
                            match x with
                            | x when x%2=0 -> Some(x)
                            | _ -> None ) aSeq

printfn "%i" (
                fibSeq 1 2 4000000
                |> evens
                |> Seq.sum)
