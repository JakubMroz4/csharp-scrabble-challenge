// See https://aka.ms/new-console-template for more information
using csharp_scrabble_challenge.Main;
using System.IO;

Console.WriteLine("Hello, World!");

Scrabble s = new Scrabble("[h}ous{e}]");
var score = s.score();

Console.WriteLine($"score = {score}");