var name = "Michał";
var gender = "mężczyzna";
var age  = 23;
if (gender == "kobieta" && age < 30)
    Console.WriteLine("Kobieta poniżej 30");
else if (age < 18 && gender == "mężczyzna")
    Console.WriteLine("Niepełnoletni mężczyzna");
else
    Console.WriteLine(name + ", lat " + age);

