namespace Array_og_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tilgjengelige kategorier:");
            string[] kategorier = { "Frukt", "Grønnsaker", "Meieri", "Kjøtt", "Annet" };

            for (int i = 0; i < kategorier.Length; i++)
            {
                Console.WriteLine(kategorier[i]);
            }

            List<string> handleliste = new List<string>();

            handleliste.Add("melk");
            handleliste.Add("epler");
            handleliste.Add("kylling");
            handleliste.Add("brokkoli");

            foreach (var vare in handleliste)
            {
                Console.WriteLine(vare);
            }
        }
    }
}

