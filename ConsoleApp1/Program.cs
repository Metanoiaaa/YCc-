// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

game NewGame = new game();
//NewGame.rating = 5;
//NewGame.Name = "LOTR";
//NewGame.costs = 26.95;
NewGame.StelNameEnRatingIn("LOTR", 6);
NewGame.StelAllesIn("LOTR2", 4, 23.95, "Steam", true);

game G2 = new game();
//G2.Name = "GTA6";
//G2.rating = 10;
//G2.costs = 12.95;
//G2.Start();
//G2.PrintRating();
//G2.PrintCosts();
G2.StelNameEnRatingIn("GTA6", 0);
G2.StelAllesIn("GTA7", 0, 574.95, "Steam", false);

//Console.WriteLine(NewGame.Name);
//Console.WriteLine(G2.Name);

int r = G2.WatIsDeRating();
Console.WriteLine("de waar van r = " + r);

Boolean wg5 = G2.IsRatingHogerDan5();

Console.WriteLine("Is de Rating hoger dan 5 " + wg5);
