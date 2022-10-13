using System.Diagnostics;
using System.Linq;

//
//
// Equalize the Array
// https://www.hackerrank.com/challenges/equality-in-a-array/problem?isFullScreen=true
Console.WriteLine("Equalize the Array");
List<int> arr = new List<int>() { 1, 2, 2, 3 };
int iResult = EqualizeTheArray.EqualizeTheArrayClass.equalizeArray(arr);
Debug.Assert(iResult == 2);

arr = new List<int>() { 3, 3, 2, 1, 3 };
iResult = EqualizeTheArray.EqualizeTheArrayClass.equalizeArray(arr);
Debug.Assert(iResult == 2);

arr = new List<int>() { 1, 2, 3, 1, 2, 3, 3, 3 };
iResult = EqualizeTheArray.EqualizeTheArrayClass.equalizeArray(arr);
Debug.Assert(iResult == 4);

