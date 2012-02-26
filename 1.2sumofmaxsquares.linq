<Query Kind="FSharpProgram" />

let max a b = 
	if a > b then a
	else b
	
let square a = a * a
	
let sumOfMaxSquare a b c = square (max a b) + square (max b c)
	
let soms = sumOfMaxSquare 3 2 1 

soms.Dump()

let s = square 5
s.Dump()

let m = max 1 200
m.Dump()

