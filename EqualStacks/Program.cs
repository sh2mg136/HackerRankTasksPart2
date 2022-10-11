using EqualStacks;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("__TestProject")]

//
// Equal Stacks
// https://www.hackerrank.com/challenges/equal-stacks/problem?isFullScreen=true
Console.WriteLine("Equal Stacks");
int result = 0;

result = EqualStacksClass.equalStacks(
    new List<int>() { 1, 2, 1, 1 },
    new List<int> { 1, 1, 2 },
    new List<int> { 1, 1 });

Debug.Assert(result == 2);

result = EqualStacksClass.equalStacks(
    new List<int>() { 3, 2, 1, 1, 1 },
    new List<int> { 4, 3, 2 },
    new List<int> { 1, 1, 4, 1 });

Debug.Assert(result == 5);

result = EqualStacksClass.equalStacks(
    new List<int>() { 12, 22, 5, 4, 33, 2, 2, 3, 2, 1, 1, 1 },
    new List<int> { 4, 3, 2 },
    new List<int> { 1, 1, 4, 1 });

Debug.Assert(result == 5);