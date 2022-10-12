using JumpingOnTheClouds;
using System.Diagnostics;

//
//
// Taum and B'day
// https://www.hackerrank.com/challenges/taum-and-bday/problem?isFullScreen=true
Console.WriteLine("Taum and B'day");
var long_res = TaumAndBdayClass.Run(10, 10, 1, 1, 1);
Debug.Assert(long_res == 20);

long_res = TaumAndBdayClass.Run(5, 9, 2, 3, 4);
Debug.Assert(long_res == 37);

long_res = TaumAndBdayClass.Run(3, 6, 9, 1, 1);
Debug.Assert(long_res == 12);

long_res = TaumAndBdayClass.Run(7, 7, 4, 2, 1);
Debug.Assert(long_res == 35);

long_res = TaumAndBdayClass.Run(3, 3, 1, 9, 2);
Debug.Assert(long_res == 12);

long_res = TaumAndBdayClass.Run(3, 5, 3, 4, 1);
Debug.Assert(long_res == 29);

long_res = TaumAndBdayClass.Run(27984, 1402, 619246, 615589, 247954);
Debug.Assert(long_res == 18192035842);

long_res = TaumAndBdayClass.Run(95677, 39394, 86983, 311224, 588538);
Debug.Assert(long_res == 20582630747);

long_res = TaumAndBdayClass.Run(68406, 12718, 532909, 315341, 201009);
Debug.Assert(long_res == 39331944938);

long_res = TaumAndBdayClass.Run(15242, 95521, 712721, 628729, 396706);
Debug.Assert(long_res == 70920116291);

long_res = TaumAndBdayClass.Run(21988, 67781, 645748, 353796, 333199);
Debug.Assert(long_res == 38179353700);




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


//
//
// ACM ICPC Team
// https://www.hackerrank.com/challenges/acm-icpc-team/problem?isFullScreen=true
var list = new List<int>();
list = ACM_ICPC_Team_Class.acmTeam(new List<string>() { "10101", "11110", "00010" });
Debug.Assert(list.Count == 2);
Debug.Assert(list[0] == 5);
Debug.Assert(list[1] == 1);


list = ACM_ICPC_Team_Class.acmTeam(new List<string>() { "10101", "11100", "11010", "00101" });
Debug.Assert(list.Count == 2);
Debug.Assert(list[0] == 5);
Debug.Assert(list[1] == 2);


list = ACM_ICPC_Team_Class.acmTeam(new List<string>() { "11101", "10101", "11001", "10111", "10000", "01110" });
Debug.Assert(list.Count == 2);
Debug.Assert(list[0] == 5);
Debug.Assert(list[1] == 6);

