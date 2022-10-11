using JumpingOnTheClouds;
using System.Diagnostics;

//
//
// Jumping on the Clouds
// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?isFullScreen=true
Console.WriteLine("Jumping on the Clouds");
int result = 0;

result = JumpingOnTheCloudsClass.jumpingOnClouds(new List<int>() { 0, 1, 0, 0, 0, 1, 0 });
Debug.Assert(result == 3);

result = JumpingOnTheCloudsClass.jumpingOnClouds(new List<int>() { 0, 0, 1, 0, 0, 1, 0 });
Debug.Assert(result == 4);