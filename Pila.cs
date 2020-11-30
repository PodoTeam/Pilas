using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Pila
    {
        private int[]elemento = new int [20];        
        private int tope;

        public Pila()
        {
            for (int i = 0; i < 20; i++)
            {
                elemento[i] = 0;
                tope = -1;
            }
        }

        public void Push(int a)
        {
            elemento[tope + 1] = a;
            tope += 1;                
        }
        public int Pop() {
            int auxiliar;
            auxiliar = elemento[tope];
            elemento[tope] =0 ;
            tope -= 1;
            return auxiliar;
        }
        public void ImprimirPila()
        {

            for (int i = 0; i <= tope; i++)
            {
                Console.WriteLine(elemento[i]);
            }
            Console.WriteLine("Esto es todo!");
        }
    }
}
