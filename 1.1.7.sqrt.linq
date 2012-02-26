<Query Kind="FSharpProgram" />

let square a = a * a

let average a b = (a + b)/2.0

let a = average 2.0 1.0
a.Dump()

let improve guess x = average guess (x / guess)

let i = improve 2.0 1.0
i.Dump()

let goodEnough guess x = abs (x - square(guess)) < 0.00000000000001

let g = goodEnough 3.0 4.0
g.Dump()

let g2 = goodEnough 2.0 4.0
g2.Dump()

let rec sqrtIterator guess x =
  if goodEnough guess x then guess
  else sqrtIterator (improve guess x) x
  
let sqrt x = sqrtIterator 2.0 x

let answer =  sqrt (12.0) 
answer.Dump()