using HackerRankTasksPart2;
using System.Diagnostics;

//
//
// Print the Elements of a Linked List
var head = new SinglyLinkedListNode(2);

ElementsOfALinkedList.printLinkedList(head);


//
//
// Cavity Map
// https://www.hackerrank.com/challenges/cavity-map/problem?isFullScreen=true
Console.WriteLine("Cavity Map");
List<string> result = new List<string>();
List<string> correct = new List<string>();
result = CavityMapClass.cavityMap(new List<string>()
{
    "1112",
    "1912",
    "1892",
    "1234"
});
correct = new List<string>()
{
    "1112",
    "1X12",
    "18X2",
    "1234"
};
var mer = result.Intersect(correct);
Debug.Assert(mer.Count() == 4);
var dis = result.Except(correct);
Debug.Assert(dis.Count() == 0);

//
//
// Left Rotation
// https://www.hackerrank.com/challenges/array-left-rotation/problem?isFullScreen=true
List<int> result_list;
List<int> correct_list;
result_list = LeftRotationClass.rotateLeft(2, new List<int>() { 1, 2, 3, 4, 5 });
correct_list = new List<int>() { 3, 4, 5, 1, 2 };
var merg = result_list.Intersect(correct_list);
Debug.Assert(merg.Count() == correct_list.Count());
var dist = result_list.Except(correct_list);
Debug.Assert(dist.Count() == 0);

result_list = LeftRotationClass.rotateLeft(4, new List<int>() { 1, 2, 3, 4, 5 });
correct_list = new List<int>() { 5, 1, 2, 3, 4 };
merg = result_list.Intersect(correct_list);
Debug.Assert(merg.Count() == correct_list.Count());
dist = result_list.Except(correct_list);
Debug.Assert(dist.Count() == 0);

//
//
// Sparse Arrays
// https://www.hackerrank.com/challenges/sparse-arrays/problem?isFullScreen=true
List<int> ints;
List<int> corr;
ints = SparseArraysClass.matchingStrings(new List<string>() { "ab", "ab", "abc" }, new List<string>() { "ab", "abc", "bc" });
corr = new List<int> { 2, 1, 0 };
merg = ints.Intersect(corr);
Debug.Assert(merg.Count() == corr.Count());
dist = ints.Except(corr);
Debug.Assert(dist.Count() == 0);

ints = SparseArraysClass.matchingStrings(
    new List<string>() { "aba", "baba", "aba", "xzxb" },
    new List<string>() { "aba", "xzxb", "ab" });
corr = new List<int> { 2, 1, 0 };
merg = ints.Intersect(corr);
Debug.Assert(merg.Count() == corr.Count());
dist = ints.Except(corr);
Debug.Assert(dist.Count() == 0);

ints = SparseArraysClass.matchingStrings(
    new List<string>() { "def", "de", "fgh" },
    new List<string>() { "de", "lmn", "fgh" });
corr = new List<int> { 1, 0, 1 };
merg = ints.Intersect(corr).ToList();
Debug.Assert(merg.Count() == corr.Distinct().Count());
dist = ints.Except(corr);
Debug.Assert(dist.Count() == 0);

ints = SparseArraysClass.matchingStrings(new List<string>()
{
"lekgdisnsbfdzpqlkg",
"eagemhdygyv",
"jwvwwnrhuai",
"urcadmrwlqe",
"mpgqsvxrijpombyv",
"mpgqsvxrijpombyv",
"urcadmrwlqe",
"mpgqsvxrijpombyv",
"eagemhdygyv",
"eagemhdygyv",
"jwvwwnrhuai",
"urcadmrwlqe",
"jwvwwnrhuai",
"kvugevicpsdf",
"kvugevicpsdf",
"mpgqsvxrijpombyv",
"urcadmrwlqe",
"mpgqsvxrijpombyv",
"exdafbnobg",
"qhootohpnfvbl",
"suffrbmqgnln",
"exdafbnobg",
"exdafbnobg",
"eagemhdygyv",
"mpgqsvxrijpombyv",
"urcadmrwlqe",
"jwvwwnrhuai",
"lekgdisnsbfdzpqlkg",
"mpgqsvxrijpombyv",
"lekgdisnsbfdzpqlkg",
"jwvwwnrhuai",
"exdafbnobg",
"mpgqsvxrijpombyv",
"kvugevicpsdf",
"qhootohpnfvbl",
"urcadmrwlqe",
"kvugevicpsdf",
"mpgqsvxrijpombyv",
"lekgdisnsbfdzpqlkg",
"mpgqsvxrijpombyv",
"kvugevicpsdf",
"qhootohpnfvbl",
"lxyqetmgdbmh",
"urcadmrwlqe",
"urcadmrwlqe",
"kvugevicpsdf",
"lxyqetmgdbmh",
"urcadmrwlqe",
"lxyqetmgdbmh",
"jwvwwnrhuai",
"qhootohpnfvbl",
"qhootohpnfvbl",
"jwvwwnrhuai",
"lekgdisnsbfdzpqlkg",
"kvugevicpsdf",
"mpgqsvxrijpombyv",
"exdafbnobg",
"kvugevicpsdf",
"lekgdisnsbfdzpqlkg",
"qhootohpnfvbl",
"exdafbnobg",
"qhootohpnfvbl",
"exdafbnobg",
"mpgqsvxrijpombyv",
"suffrbmqgnln",
"mpgqsvxrijpombyv",
"qhootohpnfvbl",
"jwvwwnrhuai",
"mpgqsvxrijpombyv",
"qhootohpnfvbl",
"lekgdisnsbfdzpqlkg",
"eagemhdygyv",
"jwvwwnrhuai",
"kvugevicpsdf",
"eagemhdygyv",
"eagemhdygyv",
"lxyqetmgdbmh",
"qhootohpnfvbl",
"lxyqetmgdbmh",
"exdafbnobg",
"qhootohpnfvbl",
"qhootohpnfvbl",
"exdafbnobg",
"suffrbmqgnln",
"mpgqsvxrijpombyv",
"urcadmrwlqe",
"eagemhdygyv",
"lxyqetmgdbmh",
"urcadmrwlqe",
"suffrbmqgnln",
"qhootohpnfvbl",
"kvugevicpsdf",
"lekgdisnsbfdzpqlkg",
"lxyqetmgdbmh",
"mpgqsvxrijpombyv",
"jwvwwnrhuai",
"lxyqetmgdbmh",
"lxyqetmgdbmh",
"lekgdisnsbfdzpqlkg",
"qhootohpnfvbl"
},
new List<string>()
{
"exdafbnobg",
"eagemhdygyv",
"mpgqsvxrijpombyv",
"kvugevicpsdf",
"lekgdisnsbfdzpqlkg",
"kvugevicpsdf",
"exdafbnobg",
"qhootohpnfvbl",
"eagemhdygyv",
"kvugevicpsdf",
"suffrbmqgnln",
"jwvwwnrhuai",
"lekgdisnsbfdzpqlkg",
"lekgdisnsbfdzpqlkg",
"mpgqsvxrijpombyv",
"jwvwwnrhuai",
"kvugevicpsdf",
"lekgdisnsbfdzpqlkg",
"exdafbnobg",
"suffrbmqgnln",
"qhootohpnfvbl",
"eagemhdygyv",
"exdafbnobg",
"suffrbmqgnln",
"jwvwwnrhuai",
"qhootohpnfvbl",
"eagemhdygyv",
"exdafbnobg",
"exdafbnobg",
"jwvwwnrhuai",
"qhootohpnfvbl",
"lxyqetmgdbmh",
"qhootohpnfvbl",
"suffrbmqgnln",
"lxyqetmgdbmh",
"qhootohpnfvbl",
"eagemhdygyv",
"jwvwwnrhuai",
"eagemhdygyv",
"qhootohpnfvbl",
"mpgqsvxrijpombyv",
"qhootohpnfvbl",
"jwvwwnrhuai",
"exdafbnobg",
"eagemhdygyv",
"eagemhdygyv",
"kvugevicpsdf",
"kvugevicpsdf",
"jwvwwnrhuai",
"urcadmrwlqe",
"lxyqetmgdbmh",
"qhootohpnfvbl",
"exdafbnobg",
"exdafbnobg",
"eagemhdygyv",
"qhootohpnfvbl",
"exdafbnobg",
"exdafbnobg",
"lekgdisnsbfdzpqlkg",
"jwvwwnrhuai",
"eagemhdygyv",
"urcadmrwlqe",
"kvugevicpsdf",
"lekgdisnsbfdzpqlkg",
"jwvwwnrhuai",
"eagemhdygyv",
"lekgdisnsbfdzpqlkg",
"exdafbnobg",
"kvugevicpsdf",
"jwvwwnrhuai",
"exdafbnobg",
"lxyqetmgdbmh",
"exdafbnobg",
"lxyqetmgdbmh",
"jwvwwnrhuai",
"mpgqsvxrijpombyv",
"eagemhdygyv",
"urcadmrwlqe",
"kvugevicpsdf",
"qhootohpnfvbl",
"jwvwwnrhuai",
"eagemhdygyv",
"urcadmrwlqe",
"urcadmrwlqe",
"exdafbnobg",
"qhootohpnfvbl",
"exdafbnobg",
"eagemhdygyv",
"exdafbnobg",
"jwvwwnrhuai",
"eagemhdygyv",
"jwvwwnrhuai",
"mpgqsvxrijpombyv",
"urcadmrwlqe",
"urcadmrwlqe",
"eagemhdygyv",
"eagemhdygyv",
"jwvwwnrhuai",
"suffrbmqgnln",
"eagemhdygyv"
});

corr = new List<int>() { 9, 8, 16, 10, 9, 10, 9, 14, 8, 10, 4, 10, 9, 9, 16, 10, 10, 9, 9,
4, 14, 8, 9, 4, 10, 14, 8, 9, 9, 10, 14, 9, 14, 4, 9, 14, 8, 10, 8, 14, 16, 14, 10, 9, 8,
8, 10, 10, 10, 11, 9, 14, 9, 9, 8, 14, 9, 9, 9, 10, 8, 11, 10, 9, 10, 8, 9, 9, 10, 10, 9,
9, 9, 9, 10, 16, 8, 11, 10, 14, 10, 8, 11, 11, 9, 14, 9, 8, 9, 10, 8, 10, 16, 11, 11, 8,
8, 10, 4, 8 };

merg = ints.Intersect(corr).ToList();
Debug.Assert(merg.Count() == corr.Distinct().Count());
dist = ints.Except(corr);
Debug.Assert(dist.Count() == 0);


