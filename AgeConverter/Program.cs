// for number formattion
using System.Globalization;

Console.WriteLine("Age converter into secounds");
Thread.Sleep(1000);
Console.WriteLine("Enter your age in years");
int ageYears = Convert.ToInt32(Console.ReadLine());

// number formattion
var nfi = new NumberFormatInfo { NumberDecimalSeparator = ",", NumberGroupSeparator = "," };

// calculate result
int ageSecounds = ageYears * 31556926;
Console.WriteLine(ageYears + " * 31.556.926 = " + ageSecounds.ToString("#,##0", nfi));

// outputs result
Console.WriteLine("Your age in secounds is: " + ageSecounds.ToString("#,##0", nfi));