//: Playground - noun: a place where people can play

import UIKit

// var and let

var str = "Hello, playground"

str = "Hi, playground"

let otherStr = "Hi, Jason" // otherStr cannot be changed

// Strings

let name = "Jason"

print("Hello " + name)

// Integer

var myInt = 8

print(myInt * 2)

print(myInt + 100)

myInt = myInt + 1

myInt /= 5

print("myInt has value: \(myInt)")

let myAge = 36

print("My name is \(name) and I am \(myAge) years old.")

// Doubles and Floats

var a: Double = 1.337

var b: Float = 2.5

var c = 0.33

print(a/c)

// print(a/b) can't combine two different types

print(Double(myInt) + a)

// Boolean

let gameOver = false

var gameOverString = String(gameOver)

var quizDouble: Double = 5.76
var quizInt: Int = 8
print("The product of \(quizDouble) and \(quizInt) is \(quizDouble * Double(quizInt))")