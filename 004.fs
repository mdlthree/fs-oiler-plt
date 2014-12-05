open System

let palindrome (x : string) = 
   (Array.Reverse (x.ToCharArray())).ToString()

palindrome "twister"
