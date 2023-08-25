using System;
using System.Collections.Generic;

namespace memoria_dinamica
{
     class MemoriaD
    {
        static void Main()
        {
            // Cola = Estructura FIFO
            Queue<int> cola =new Queue<int>();
            cola.Enqueue(20);
            cola.Enqueue(10);
            cola.Enqueue(5);

            while (cola.Count > 0)
            {
                int dato = cola.Dequeue();
                Console.WriteLine(dato);
            }

        }
    }
}
