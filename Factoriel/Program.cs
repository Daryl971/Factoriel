namespace Factoriel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrez un nombre : ");
        int n = int.Parse(Console.ReadLine());

        int compteur = 1, resultat = 1;

        while (compteur <= n)
        {
            resultat = resultat * compteur;
            compteur++;
        }
        Console.WriteLine($"Le resultat est de {n}! = {resultat}");
    }
}