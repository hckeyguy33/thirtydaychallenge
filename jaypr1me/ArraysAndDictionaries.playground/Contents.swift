//: Playground - noun: a place where people can play

import UIKit

// Array

var array = [1, 3, 3, 7]

print(array[2])

print(array.count)

array.append(42)

array.remove(at: 2)

array.sort()

print(array)


// Challenge
var challengeArray = [3.87, 7.1, 8.9]
challengeArray.remove(at: 1)
challengeArray.append(challengeArray[0] * challengeArray[1])

let mixArray = ["Name", 29, true] as Any

let arrayTest = [String](arrayLiteral: "hello", "world", "!")


// Dictionary

var dictionary = ["computer": "Something to do work on",
                  "coffee": "Worst drink ever"] // Same thing as a C++ std::map

print(dictionary["computer"])

print(dictionary.count)

dictionary["pen"] = "Old fashioned writing tool"

dictionary.removeValue(forKey: "computer")

print(dictionary)

var gameCharacters = [String:Double]()
gameCharacters["ghost"] = 8.7


// Challenge
let challengeDictionary = ["pizza": 10.99, "ice cream": 4.99, "salad": 7.99]
print("The total cost of my meal is \(challengeDictionary["pizza"]! + challengeDictionary["ice cream"]!)")