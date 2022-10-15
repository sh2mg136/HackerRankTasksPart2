using EqualizeTheArray;
using System.Diagnostics;
using System.Linq;

//
//
// Modified Kaprekar Numbers
// https://www.hackerrank.com/challenges/kaprekar-numbers/problem?isFullScreen=true
Console.WriteLine("Modified Kaprekar Numbers");
bool hasKaprekar = ModifiedKaprekarNumbersClass.checkKaprekarNumbers(1, 1);
Debug.Assert(hasKaprekar);

hasKaprekar = ModifiedKaprekarNumbersClass.checkKaprekarNumbers(5, 5);
Debug.Assert(!hasKaprekar);

hasKaprekar = ModifiedKaprekarNumbersClass.checkKaprekarNumbers(9, 9);
Debug.Assert(hasKaprekar);

hasKaprekar = ModifiedKaprekarNumbersClass.checkKaprekarNumbers(10, 10);
Debug.Assert(!hasKaprekar);

hasKaprekar = ModifiedKaprekarNumbersClass.checkKaprekarNumbers(44, 44);
Debug.Assert(!hasKaprekar);

hasKaprekar = ModifiedKaprekarNumbersClass.checkKaprekarNumbers(45, 45);
Debug.Assert(hasKaprekar);

hasKaprekar = ModifiedKaprekarNumbersClass.checkKaprekarNumbers(55, 55);
Debug.Assert(hasKaprekar);

hasKaprekar = ModifiedKaprekarNumbersClass.checkKaprekarNumbers(999, 999);
Debug.Assert(hasKaprekar);

hasKaprekar = ModifiedKaprekarNumbersClass.checkKaprekarNumbers(2223, 2223);
Debug.Assert(hasKaprekar);

hasKaprekar = ModifiedKaprekarNumbersClass.checkKaprekarNumbers(99999, 99999);
Debug.Assert(hasKaprekar);


var s = ModifiedKaprekarNumbersClass.kaprekarNumbers(1, 100);
Debug.Assert(s == "1 9 45 55 99");

s = ModifiedKaprekarNumbersClass.kaprekarNumbers(99999, 99999);
Debug.Assert(s == "99999");

s = ModifiedKaprekarNumbersClass.kaprekarNumbers(1, 99999);
Debug.Assert(s == "1 9 45 55 99 297 703 999 2223 2728 4950 5050 7272 7777 9999 17344 22222 77778 82656 95121 99999");



//
//
// Sort emplyees (certificate task)
var eList = EmployeeOperations.OldestAgeForEachCompany2(EmployeeOperations.Employees);
Debug.Assert(eList.Count > 0);
foreach (var e in eList)
{
    Console.WriteLine(e.Value);
}

//
//
// Equalize the Array
// https://www.hackerrank.com/challenges/equality-in-a-array/problem?isFullScreen=true
Console.WriteLine(Environment.NewLine);
Console.WriteLine(Environment.NewLine);
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

