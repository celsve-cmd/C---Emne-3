/*
//Oppgave 1:

//Ha en variabel med datatypen int og gi den en value med et tall mellom 1 og 7.
//Bruk en switch for å finne ut hvilken dag i uken det tallet er, og print dagen ut med Console.WriteLine().
//Eksempel: Hvis variabelen har verdien 1, skal det printes "Mandag" ut i konsollen.


int dag = 4;
var resultat = dag switch
{
    1 => "Mandag",
    2 => "Tirsdag",
    3 => "Onsdag",
    4 => "Torsdag",
    5 => "Fredag",
    6 => "Lørdag",
    7 => "Søndag",
    _ => "Vi har ikke flere dager"
};
Console.WriteLine($"{resultat}");


//____________________________ELLER______________________________//


int dag1 = 1;
switch (dag1)
{
    case 1:
        Console.WriteLine("Mandag");
        break;

    case 2:
        Console.WriteLine("Tirsdag");
        break;

    case 3:
        Console.WriteLine("Onsdag");
        break;

    case 4:
        Console.WriteLine("Torsdag");
        break;

    case 5:
        Console.WriteLine("Fredag");
        break;

    case 6:
        Console.WriteLine("Lørdag");
        break;

    case 7:
        Console.WriteLine("Søndag");
        break;

    default:
        Console.WriteLine("Vi har ikke flere dager");
        break;
}
*/

//_________________________________________________________________//

//Oppgave 2:

//Ta utgangspunkt fra oppgave 1, men istedenfor å bruke en int eller en fastsatt value, bruker du Console.ReadLine() 
//for at man skal skrive inn et tall i konsollen. Hvis man ikke får inn et tall, skal switch-en kjøre programmet på nytt.

//HER KAN VI KUN BRUKE DENNE MÅTEN OG IKKE SOM EN EKSPRESSIV MÅTE.

void Run()
{
    var dag3 = Console.ReadLine();
    switch (dag3)
    {
        case "1":
            Console.WriteLine("Mandag");
            break;

        case "2":
            Console.WriteLine("Tirsdag");
            break;

        case "3":
            Console.WriteLine("Onsdag");
            break;

        case "4":
            Console.WriteLine("Torsdag");
            break;

        case "5":
            Console.WriteLine("Fredag");
            break;

        case "6":
            Console.WriteLine("Lørdag");
            break;

        case "7":
            Console.WriteLine("Søndag");
            break;

        default:
            Run();
            break;
    }
}
Run();


//BLI FLINKERE TIL Å BRUKE METODER!!!!!!!!!!!!