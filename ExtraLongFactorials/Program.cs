using ExtraLongFactorials;
using System.Diagnostics;


//
//
// Extra Long Factorials
// https://www.hackerrank.com/challenges/extra-long-factorials/problem?isFullScreen=true
Console.WriteLine("Extra Long Factorials");
string str = ExtraLongFactorialsClass.Run(4);
Debug.Assert(str == "24");

str = ExtraLongFactorialsClass.Run(9);
Debug.Assert(str == "362880");

str = ExtraLongFactorialsClass.Run(10);
Debug.Assert(str == "3628800");

str = ExtraLongFactorialsClass.Run(20);
Debug.Assert(str == "2432902008176640000");

str = ExtraLongFactorialsClass.Run(21);
Debug.Assert(str == "51090942171709440000");

str = ExtraLongFactorialsClass.Run(25);
Debug.Assert(str == "15511210043330985984000000");