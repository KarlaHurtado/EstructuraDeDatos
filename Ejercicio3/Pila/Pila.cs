using System;

namespace Pila
{
    public class Pila
    {
        private char[] datos;  
        private int indiceTope;    

        public Pila(int capacidadMaxima)
        {
            datos = new char[capacidadMaxima];
            indiceTope = -1; 
        }

        public void Push(char dato)
        {
            if (indiceTope == datos.Length - 1)
            {
                Console.WriteLine("La pila está llena.");
                return;
            }
            datos[++indiceTope] = dato;
        }

        public char Pop()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila está vacía.");
                return '\0'; 
            }
            return datos[indiceTope--];
        }

        public bool EstaVacia()
        {
            return indiceTope == -1;
        }
    }
}
