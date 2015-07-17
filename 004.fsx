let palindrome (a : string) = 
    let r = new string( Array.rev (a.ToCharArray()))
    r.Equals(a)

let best x y = 
    if x > y then x
    else y

let winner = 0

for i in {100..110} do
    for j in {100..110} do
        let t = i*j
        if (palindrome (t.ToString())) then
            best winner t
