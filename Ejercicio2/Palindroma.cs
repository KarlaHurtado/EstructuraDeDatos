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
        string PalabraInv = "";
        while (!pila.Vacia())
        {
            PalabraInv += pila.Pop();
        }

        // Comparamos
        if (palabra == PalabraInv)
        {
            Console.WriteLine($" \"{palabra}\" es una palabra palíndroma.");
        }
        else
        {
            Console.WriteLine($" \"{palabra}\" no es una palabra palíndroma.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
    }
}