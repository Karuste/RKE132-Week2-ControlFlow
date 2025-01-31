// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada oma vanus
//kui vanus on väiksem kui 13 konsoolis kuvatakse To young 
//muul juhul
//konsoolis kuvatakse Welcome 

using System.ComponentModel.Design;

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);


//  Console.WriteLine("You are too young to use Instagram");


Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
 else
{
    Console.WriteLine("Could not read your age");
}