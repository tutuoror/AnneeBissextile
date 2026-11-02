using System.ComponentModel.Design;

namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.

        int annee;

        Console.WriteLine("quel annee voulez-vous verifier ?");
        annee = Convert.ToInt32(Console.ReadLine());

        if (annee % 4 != 0);
            {
            Console.WriteLine("l'annee" + annee + "est pas une annee bissextile");
            }
            else if (annee % 4 == 0);
            {
            Console.WriteLine("l'annee" + annee + "est une annee bissextile");
            }
    }
}