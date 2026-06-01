//Oppgave 1

Console.WriteLine("Hei, hva heter du?");

var userInput = Console.ReadLine();
Console.WriteLine($"Velkommen {userInput}!");

//Vi bruker var for å kunne tilordne en verdi til userInput uten å måtte spesifisere datatypen, da den kan være både string eller null, 
//avhengig av hva brukeren skriver inn. Hvis vi hadde brukt string, ville det ikke fungert hvis brukeren ikke skrev inn noe og trykket enter, 
//da det ville gi en null-verdi som ikke kan tilordnes til en string-variabel.