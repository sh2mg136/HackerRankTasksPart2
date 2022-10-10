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

