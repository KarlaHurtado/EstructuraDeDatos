using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalabraPalindroma
{
    public class Palindroma
    {
        static void Main()
    {
        Console.Write("Ingresa una palabra: ");
            string ? palabra = Console.ReadLine(); 
            string cadena = palabra ?? "";
        Pila pila = new Pila(palabra.Length);

        // Apilamos cada carácter
        foreach (char c in palabra)
        {
            pila.Push(c);
        }

        // Desapilamos para invertir la palabra
        string invertida = "";
        while (!pila.Vacia())
        {
            invertida += pila.Pop();
        }

        // Comparamos
        if (palabra == invertida)
        {
            Console.WriteLine($" \"{palabra}\" es un palíndromo.");
        }
        else
        {
            Console.WriteLine($" \"{palabra}\" no es un palíndromo.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
    }
}