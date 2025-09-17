// See https://aka.ms/new-console-template for more information

//string Greeting = "Hello";
//string MyName = "Luan";
//int MyAge = 20;


//Console.WriteLine($"{Greeting} {MyName}. You are {MyAge} years old");


using oop_2025_a_0916_1.Modules;
using System.Runtime.Serialization;
using System.Xml.Linq;

//string superhero1Name  = "Tony Stark";
//string superhero1Alias = "Iron Man";

//string superhero2Name = "Peter Parker";
//string superhero2Alias = "Spiderman";

//Console.WriteLine($"{superhero1Name} is {superhero1Alias}");
//Console.WriteLine($"{superhero2Name} is {superhero2Alias}");

SuperHero SuperHero1 = new SuperHero();
SuperHero1.Alias = "Iron Man";
SuperHero1.Name = "Tony Stark";
SuperHero1.Age = 30;

SuperHero SuperHero2 = new SuperHero();
SuperHero2.Alias = "Spider man";
SuperHero2.Name = "Peter Parker";
SuperHero1.Age = 25;

SuperHero SuperHero3 = new SuperHero()
{
    Alias = "Hulk",
    Name = "Bruce Banner",
    Age = 35
};


Console.WriteLine($"{SuperHero1.Name} is {SuperHero1.Alias} his age is {SuperHero1.Age}");
Console.WriteLine($"{SuperHero2.Name} is {SuperHero2.Alias} his age is {SuperHero2.Age}");
Console.WriteLine($"{SuperHero3.Name} is {SuperHero3.Alias} his age is {SuperHero3.Age}");

Console.WriteLine(SuperHero1.ToString());
Console.WriteLine(SuperHero2.ToString());
Console.WriteLine(SuperHero3.ToString());