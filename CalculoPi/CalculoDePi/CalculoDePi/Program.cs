using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número de puntos a lanzar: ");
        int numPuntos = int.Parse(Console.ReadLine());

        int dentroDelCirculo = 0;
        Random random = new Random();

        for (int i = 0; i < numPuntos; i++)
        {
            double x = random.NextDouble(); // Genera un número aleatorio entre 0 y 1
            double y = random.NextDouble();

            double distanciaAlOrigen = Math.Pow(x, 2) + Math.Pow(y, 2);

            if (distanciaAlOrigen <= 1)
            {
                dentroDelCirculo++;
            }
        }

        double estimacionPi = (double)(dentroDelCirculo) / numPuntos * 4;
        Console.WriteLine($"Estimación de Pi con {numPuntos} puntos: {estimacionPi}");
    }
}

