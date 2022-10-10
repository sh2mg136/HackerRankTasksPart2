//
// Cavity Map
// https://www.hackerrank.com/challenges/cavity-map/problem?isFullScreen=true
using HackerRankTasksPart2;
using System.Diagnostics;

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
