// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

var processList = Process.GetProcesses();
var process = processList.Where(p=> p.ProcessName == "dotnet").First();
Console.WriteLine("Processing your feelings is " + process.PriorityClass);
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);
