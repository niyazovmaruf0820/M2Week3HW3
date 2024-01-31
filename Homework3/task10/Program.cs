using System;
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
Random random = new Random();
var shuffledNumbers = numbers.OrderBy(e => random.Next()).ToArray();
foreach (var number in shuffledNumbers)
{
    Console.Write(number + " ");
}