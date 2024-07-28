using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, introduce una palabra: ");
        string palabra = Console.ReadLine();

        // Convertir la palabra en un array de caracteres, invertir el array, y crear una nueva cadena
        char[] caracteres = palabra.ToCharArray();
        Array.Reverse(caracteres);
        string palabraInvertida = new string(caracteres);

        Console.WriteLine("Palabra invertida: " + palabraInvertida);
    }
}
