# DSA (Data Structures & Algorithms)
C# implementations of various data structures and algorithms. Regularly updated. Taking inspiration from [*Data Structures and Algorithms in Java*](http://a.co/48Cqup7), by Robert Lafore. Developed using TDD.

## Note on Resources

As mentioned, my primary reference is *Data Structures and Algorithms in Java*, by Robert LaFore.

I can't recommend it enough, especially since it's almost never mentioned. I think it's the best textbook on data structures and algorithms I've come across for those without a working knowledge of the math, e.g. linear algebra, one generally finds in such books. It manages, despite the un-mathy presentation, to be very thorough.

Disregard the fact that it uses Java as a language if you find yourself saying "I don't know Java". The language choice is totally irrelevant as long as you have a basic understanding of OOP concepts (which the book actually takes time to introduce should you not).

[*Cracking the Coding Interview*, by Gayle Laakman McDowell](http://a.co/i4kVn6P) is also worth a look, but I wouldn't recommend it as a standalone introductory volume. It's best used to refocus or reinforce an already sufficient understanding of algorithm analysis specifically for the purpose of interviewing.

If you are in need of a very accessible, but in no way patronizing introduction, check out [*Grokking Algorithms*, by Aditya Y. Bhargava](http://a.co/bXdEhJN). It's short, non-mathy, includes excellent illustrations, and hits upon some major themes. I think it's a great way to get your feet wet.

## How to Run

Currently, the best way to run the implementations is to first confirm you have NUnit installed via Nuget in Visual Studio, then run the tests in the test suite. The tests will pass. Depending on your disposition, this may be exciting.

A console, char-based visualization frontend for the implementations is planned. 

## Algorithms
* [Binary Search](https://github.com/ryanklee/DSA/blob/master/DSA/Algorithms/BinarySearch.cs)
* [Bubble Sort](https://github.com/ryanklee/DSA/blob/master/DSA/Algorithms/BubbleSort.cs)
* [Selection Sort](https://github.com/ryanklee/DSA/blob/master/DSA/Algorithms/SelectionSort.cs)
* [Insertion Sort](https://github.com/ryanklee/DSA/blob/master/DSA/Algorithms/InsertionSort.cs)

## Data Structures
* [Stack](https://github.com/ryanklee/DSA/blob/master/DSA/DataStructures/LIFOStack.cs)
* [Circular Queue](https://github.com/ryanklee/DSA/blob/master/DSA/DataStructures/CircularQueue.cs)
* [Priority Queue](https://github.com/ryanklee/DSA/blob/master/DSA/DataStructures/PriorityQueue.cs)

## Toy Programs using DSA implementations
* [String Reverser](https://github.com/ryanklee/DSA/blob/master/DSA/ToyExamples/StringReverser.cs)
* [Delimiter matcher](https://github.com/ryanklee/DSA/blob/master/DSA/ToyExamples/DelimiterMatcher.cs)
