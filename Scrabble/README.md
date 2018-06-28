# Scrabble Scorer

#### Epicodus C#: Objects in Objecs 06/28/2018

#### By Devin Mounts & Matt Smith

## Description

A program that will allow user to enter a word and returns the scrabble score for this word.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Program stores a dictionary that holds keys for each letter of the alphabet and their associated scrabble scores**|  "{{ "A", 1} {"B", 2}...}"  |
| **Program gets a word**| Input: "cat" | Output: "cat" |
| **Program converts word to character array**| Input: "cat" | Output: "['c', 'a', 't']" |
| **Program takes each character in array and finds corresponding letter in the dictionary, returning the value**| Input: 'c' | Output: "1" |
| **When program reaches end of character array, it returns the sum of the scrabble score values**| Input: ['c', 'a', 't'] | Output: "[1, 1, 1] sum = 3" |

and converts it to a character array

## Setup/Contribution Requirements

1. Follow the instructions for downloading C#, .NET Core 1.1 and Mono from: https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c
1. Clone the repo at
1. Make a new branch
1. Commit and push your changes
1. Create a PR

## Technologies Used

* .NET Core 1.1 SDK
* .NET runtime
* Mono

## Links

*

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Devin Mounts & David Ngo**