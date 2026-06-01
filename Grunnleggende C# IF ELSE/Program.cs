/*
//Oppgave 1:
//Lag en metode som tar imot to tall og returnerer true dersom tallene er like.

bool isEqual = false;

Console.WriteLine("Skriv inn tallene dine:");

var tall1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("og");
var tall2 = Convert.ToInt32(Console.ReadLine());


if(tall1 != tall2)
{
    Console.WriteLine("tallene er ikke like!");
}
else
{
    Console.WriteLine("Tallene er like!");
    isEqual = true;
};
*/

//------------------------------------------------------------------------------------------------------------------------//

/*
//Oppgave 2:
//Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike, og returnerer tallene multiplisert med hverandre dersom de er like

bool isEqual = false;

Console.WriteLine("Skriv inn tallene dine:");

var tall1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("og");
var tall2 = Convert.ToInt32(Console.ReadLine());

if(tall1 != tall2)
{
    Console.WriteLine(tall1 + tall2);
}
else
{
    Console.WriteLine(tall1 * tall2);
    isEqual = true;
};
*/

//------------------------------------------------------------------------------------------------------------------------//


//Oppgave 3:
//Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30, skal metoden returnere true. Ellers returnerer metoden false

bool golden30 = false;
var lykketall = 30;

Console.WriteLine("Skriv inn tallene dine:");

var tall1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("og");
var tall2 = Convert.ToInt32(Console.ReadLine());

if (tall1 == lykketall)
{
   golden30 = true;
}
if (tall2 == lykketall)
{
    golden30 = true;
}
if (tall1 + tall2 == lykketall)
{
    golden30 = true;
}
if (golden30)
{
    Console.WriteLine("Nå er bool'en true");
}
else
{
    Console.WriteLine("Bool'en er enda false");
};
