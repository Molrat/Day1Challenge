// See https://aka.ms/new-console-template for more information
using Day1Challenge;

Console.WriteLine("Hello, World!");
string input = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000";
int result = MaxCaloriesComputer.ComputeMaxCalories(input);
Console.WriteLine(result);