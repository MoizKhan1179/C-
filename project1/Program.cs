// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello World!");
//Console.WriteLine("Wake up to Reality ~Uchiha_  Madara");

//following is variable as reserved keywords

using System.Runtime.Intrinsics.X86;

string @class = "2210B3";
Console.WriteLine(@class);

string Name = "Mosa";
int Age = 19;
Console.WriteLine("My name is " + Name + " and i am " + Age);

            
if (Age > 20) {
    Console.WriteLine("you are eligible");
}else
    Console.WriteLine("you are not old enough");


//String interpolation
//Calculate BMI

double weight = 75,
    height = 6,
bmi;

bmi = weight / (height * height);

Console.WriteLine($"BMI: {bmi:0.##}");


