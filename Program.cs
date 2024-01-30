using System;

public class Pierwiastki
{
    public Pierwiastki(int a, int b, int c)
    {
        double delta = b * b - 4 * a * c;

        if(delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        }

        if(delta == 0)
        {
            double x0 = -b / (2 * a);
        }

        if (delta < 0)
        {
            Console.WriteLine("Brak pierwiastków kwadratowych");
        }

        else
        {
            Console.WriteLine("Wprowadź poprawne dane");
        }
    }
}