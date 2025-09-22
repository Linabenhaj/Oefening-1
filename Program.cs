namespace Oefening_1
{
    internal class Program
    {
        // Hoofdmethode
        static void Main(string[] args)
        {
            // Tekst van gebruiker vragen
            Console.Write("Geef de tekst die je wil omkeren: ");
            string tekst = Console.ReadLine();

            // Menu tonen en keuze van gebruiker
            Console.WriteLine("\nKies een methode:");
            Console.WriteLine("1 = For-loop");
            Console.WriteLine("2 = While-loop");
            Console.WriteLine("3 = Do-while-loop");
            Console.WriteLine("4 = Recursie");
            Console.Write("\nUw keuze: ");
            string keuze = Console.ReadLine();

            string resultaat = "";

            switch (keuze)
            {
                case "1": // For-loop
                    for (int i = tekst.Length - 1; i >= 0; i--)
                        resultaat += tekst[i];
                    break;

                case "2": // While-loop
                    int i = tekst.Length - 1;
                    while (i >= 0)
                    {
                        resultaat += tekst[i];
                        i--;
                    }
                    break;

                case "3": // Do-while-loop
                    i = tekst.Length - 1;
                    if (tekst.Length > 0)
                    {
                        do
                        {
                            resultaat += tekst[i];
                            i--;
                        } while (i >= 0);
                    }
                    break;

                case "4": // Recursie met First en Last(
                    resultaat = OmkerenRecursief(tekst);
                    break;

                default:
                    Console.WriteLine("Ongeldige keuze!");
                    return;
            }

            Console.WriteLine($"\nOmgekeerde tekst: {resultaat}");
        }
    }
    }
