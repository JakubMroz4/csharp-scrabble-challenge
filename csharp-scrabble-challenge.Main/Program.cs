// See https://aka.ms/new-console-template for more information
using csharp_scrabble_challenge.Main;
using System.IO;

Console.WriteLine("Hello, World!");

Scrabble s = new Scrabble("{street}");
var score = s.score();

Console.WriteLine($"score = {score}");

Scrabble s2 = new Scrabble("[street]");
var score2 = s2.score();

Console.WriteLine($"score = {score2}");