using System;

namespace Estructuras
{
    public class Cola
    {
        private int[] elementos;
        private int Top;   
        private int Final;
        private int Tamanio;   
        private int Cantidad; 

        public Cola(int capacidad)
        {
            elementos = new int[capacidad];
            Tamanio = capacidad;
            Top = 0;
            Final = -1;
            Cantidad = 0;
        }

        public void Insertar(int dato)
        {
            if (Llena())
            {
                Console.WriteLine("⚠️ La cola está llena.");
                return;
            }
            Final = (Final + 1) % Tamanio;
            elementos[Final] = dato;
            Cantidad++;
        }

        public int Extraer()
        {
            if (Vacia())
            {
                Console.WriteLine("⚠️ La cola está vacía.");
                return -1; // Valor de error
            }
            int dato = elementos[Top];
            Top = (Top + 1) % Tamanio;
            Cantidad--;
            return dato;
        }

        public int Principio()
        {
            if (Vacia())
            {
                Console.WriteLine("⚠️ La cola está vacía.");
                return -1;
            }
            return elementos[Top];
        }

        public bool Vacia()
        {
            return Cantidad == 0;
        }

        public bool Llena()
        {
            return Cantidad == Tamanio;
        }
    }
}
