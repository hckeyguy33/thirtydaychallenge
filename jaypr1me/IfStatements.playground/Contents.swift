//: Playground - noun: a place where people can play

import UIKit

let age = 13

if age >= 18
{
    print("You can play!")
}
else
{
    print("You're too young!")
}

// Check username
let name = "Jason"

if name == "Jason"
{
    print("Hi " + name + "! You can play!")
}
else
{
    print("Sorry, " + name + ", you can't play")
}

// 2 If statements

if name == "Jason" && age >= 18
{
    print("You can play!")
}
else if name == "Jason"
{
    print("Sorry Jason, you need to get older!")
}

if name == "Jason" || name == "Jim"
{
    print("Welcome " + name)
}

// Booleans with If statements
let isMale = true

if isMale
{
    print("You're male!")
}

// Challenge
// Login system, username/password variables
let username = "jhorsman"
let password = "admin1234"

if username == "johndoe" && password == "admin1234"
{
    print("Login information correct!")
}
else if (username != "johndoe" && password != "admin1234")
{
    print("Username and password are both incorrect!")
}
else if (password == "admin1234")
{
    print("Username is incorrect!")
}
else
{
    print("Password is incorrect!")
}
