//Ved å bruke det vi har lært, skal vi nå lage en konsollapplikasjon som tildeler en person en random hobby.

//Skriv navn inn i konsollen, la en funksjon trekke en tilfeldig hobby - og vis dette sammen med navnet i konsollen.
//La det være 3-5 forskjellige hobbyer som kan trekkes.


Random rand = new Random();
var newHobby = rand.Next(0, 6);




Console.WriteLine("Skriv inn navnet ditt:");
string name = Console.ReadLine();
Console.Clear();
Console.WriteLine($"Hei {name}!");

Console.WriteLine("Ønsker du deg en hobby?");
string answer = Console.ReadLine();
Console.Clear();



if (answer == "ja")
{
    Console.WriteLine($"Så gøy! Her er din nye hobby!");
}
else
{
    Console.WriteLine("Så trist :( Jeg håper du ombestemmer deg");
}



if(newHobby == 0)
{
    Console.WriteLine("Du fikk ikke noen ny hobby :(");
}
else if (newHobby == 1)
{
    Console.WriteLine("Du har nå begynt å samle på lyder som gamle kjøleskap lager klokken 03:17 på natten! O_o");
}
else if(newHobby == 2)
{
    Console.WriteLine("Du har nå begynt med profesjonell vurdering av hvor truende forskjellige typer grøt ser ut! Kulinarisk! :D");
}
else if(newHobby == 3)
{
    Console.WriteLine("Du har nå begynt med konkurransestirring med duer på offentlige torg! Jeg tror jeg har en ''glad i seg selv'' trøye liggende til deg en plass");
}
else if(newHobby == 4)
{
    Console.WriteLine("Du har nå begynt å trene gullfisk til å ignorere deg med mer selvtillitt! Litt ensomt i lengden, men verdt det!");
}
else if(newHobby == 5)
{
    Console.WriteLine("Du har nå begynt med konspirasjonsteorier om hvorfor bananer bøyer seg! Filosofisk!");
}