using System;

public class PierwiastkiKwadratowe
{
    public int a;
    public int b;
    public int c;
    public int delta;
    public double pierwKw;
    public double x1, x2, x3, x4;
    public float x0;
    public PierwiastkiKwadratowe(int a, int b, int c)
    {
        Console.WriteLine("Algorytm oblicza pierwiastki kwadratowe z równania kwadratowego ax^2 + bx + c = 0");
        Console.WriteLine();

        if (a != 0)
        {
            delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                pierwKw = Math.Sqrt(delta);

                x1 = (-b - pierwKw) / (2 * a);
                x2 = (-b + pierwKw) / (2 * a);

                x3 = c / (a * x1);
                x4 = c / (a * x2);

                Console.WriteLine("Dostępne są 2 pierwiastki kwadratowe");
                Console.WriteLine($"Pierwiastek nr. 1: {x1} oraz wynik ze wzoru Viete'a wynoszący {x3}");
                Console.WriteLine($"Pierwiastek nr. 2: {x2} oraz wynik ze wzoru Viete'a wynoszący {x4}");
            }

            else if (delta == 0)
            {
                x0 = -b / (2 * a);

                Console.WriteLine("Dostępny jest tylko jeden pierwiastek kwadratowy");
                Console.WriteLine($"Pierwiatek nr. 0: {x0}");
            }

            else
            {
                Console.WriteLine("Delta jest zmniejsza od zera. Brak pierwiastków kwadratowych.");
            }
        }

        else
        {
            Console.WriteLine("Parametr a musi być dodatni");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Podaj parametr a: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj parametr b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj parametr c: ");
        int c = int.Parse(Console.ReadLine());

        PierwiastkiKwadratowe pierwiastki = new PierwiastkiKwadratowe(a, b, c);
    }
}