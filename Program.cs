using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila Mi_Pila = new Pila();
            Console.WriteLine("Cuántos datos desea ingresar=");
            int x;
            x = int.Parse(Console.ReadLine());
            for (int i=0;i<x;i++) {
                Console.WriteLine("Ingrese el número {0}",i+1);
                Mi_Pila.Push(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Cuántos datos desea Retirar");;
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Mi_Pila.Pop();
            }
            Mi_Pila.ImprimirPila();
        }
    }
}
