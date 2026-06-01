//Når man ønsker å lage en tilfeldig verdi, så trenger man et Random objekt.
//Dette objektet har en funksjon som heter Next() der man kan sende in minimum og maksimum verdi.
//OBS!! Den returnerer tall mellom min og max verdi, og tar ikke med max verdien. 
//Da må du legge til 1 på max verdien for å få med den.

//Eksempel:
Random rand = new Random();
var randomNumber = rand.Next(0, 3);

if (randomNumber == 0)
{
    Console.WriteLine("Tallet ble 0");
}
else if (randomNumber == 1)
{
    Console.WriteLine("Tallet ble 1");
}
else
{
    Console.WriteLine("Tallet ble 2");
}