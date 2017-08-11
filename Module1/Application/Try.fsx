#load "Types.fs"
#load "Functions.fs"

open Types
open Functions

let a = 1
let duplicated = "original value"
let duplicated2 = "new value"

let myTuple = (42, "hello")
let number, message = myTuple

let customer = { Id = 1; IsVip = false; Credit = 10M}

let purchases = (customer, 101M)
let vipCustomer = tryPromoteToVip purchases

let calculatedPurchases = getPurchases customer