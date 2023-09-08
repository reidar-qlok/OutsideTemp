using System.Runtime.InteropServices;

namespace OutsideTemp
{
    internal class Program
    {
        // Ett övnings exempel utan felhantering, vi kommer till det senare
        // Det man läser in från en console app blir alltid text (string)
        // Jag använder int.Parse(string) för att porta svaret över till ett heltal
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, vad är det för temeratur där du bor i dag");
            string answer = Console.ReadLine();
            int temp = int.Parse(answer);
            if(temp >=30)
            {
                Console.WriteLine("Varmt");
            }
            else if (temp < 30 && temp > 20)
            {
                Console.WriteLine("Sommar");
            }
            else
            {
                Console.WriteLine("Höst/Vinter");
            }
        }
    }
}