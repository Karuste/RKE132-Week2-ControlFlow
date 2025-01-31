// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt tema sugu (m/f)
//rakendus küsib kasutajalt sisestada Pnimi
//lähtudas kasutaja valikust, rakendus tervitab kasutajat järgmiselt 
// "Welcome, Mr.[kasutaja Pnimi] / "Welcome, [kasutaja Pnimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your last name:");

string userLastName = Console.ReadLine(); 



if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}");
}
else
{
    Console.WriteLine($"Welcome {userLastName}");
}


