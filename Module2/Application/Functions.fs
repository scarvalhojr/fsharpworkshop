module Functions

open Types

let tryPromoteToVip purchases =
    let customer, amount = purchases
    if amount > 100M then { customer with IsVip = true }
    else customer

let getPurchases customer =
    if customer.Id % 2 = 0 then (customer, 120M)
    else (customer, 80M)

let increaseCredit condition customer =
    if condition customer then {customer with Credit = 100M + customer.Credit}
    else {customer with Credit = 50M + customer.Credit}

let increaseCreditUsingVip = increaseCredit (fun c -> c.IsVip)

// let upgradeCustomer customer =
//     customer
//     |> getPurchases
//     |> tryPromoteToVip
//     |> increaseCreditUsingVip

let upgradeCustomer = getPurchases >> tryPromoteToVip >> increaseCreditUsingVip