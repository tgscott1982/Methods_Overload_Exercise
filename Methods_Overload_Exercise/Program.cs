using Methods_Overload_Exercise;

var a = 12;
var b = 34;
var intAnswer = Methods.Add(a, b);

var c = 12.3m;
var d = 45.6m;
var decAnswer = Methods.Add(c, d);

string mixedAnswer = Methods.Add(0, 1, true);

Console.WriteLine(intAnswer);
Console.WriteLine();
Console.WriteLine(decAnswer);
Console.WriteLine();
Console.WriteLine(mixedAnswer);