using System;
namespace RevisarEscrito
{
class Pila
    {
        private char[] elementos;
        private int tope;

        public Pila(int tamaño)
        {
            elementos = new char[tamaño];
            tope = -1;
        }

        public void Push(char c)
        {
            elementos[++tope] = c;
        }

        public char Pop()
        {
            return elementos[tope--];
        }

        public bool Vacia()
        {
            return tope == -1;
        }
    }
}