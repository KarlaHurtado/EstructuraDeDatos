using System;

namespace RevisarEscrito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una expresión con (), {} o []:");
            string? Expresion = Console.ReadLine();
            string cadena = Expresion ?? "";

            if (VerificarBalanceo(cadena))
            {
                Console.WriteLine("\nLa expresión está correctamente balanceada.");
            }
            else
            {
                Console.WriteLine("\nLa expresión NO está bien balanceada.");
            }
        }

        static bool VerificarBalanceo(string cadena)
        {
            Pila pila = new Pila(cadena.Length);

            foreach (char c in cadena)
            {
                // Si es símbolo de apertura, lo metemos en la pila
                if (c == '(' || c == '{' || c == '[')
                {
                    pila.Push(c);
                }
                // Si es símbolo de cierre, verificamos si coincide con el tope
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Vacia()) return false; // Cierra sin abrir
                    char tope = pila.Pop();

                    if (!Coinciden(tope, c))
                    {
                        return false; // Tipo incorrecto de cierre
                    }
                }
            }

            // Si al final la pila está vacía, todo está bien balanceado
            return pila.Vacia();
        }

        static bool Coinciden(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') || (apertura == '{' && cierre == '}') || (apertura == '[' && cierre == ']');
        }
    }
}