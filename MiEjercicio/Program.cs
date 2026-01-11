using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Crear y almacenar los números del 1 al 10
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 2. Mostrar en orden inverso
        for (int i = numeros.Count - 1; i >= 0; i--)
        {
            Console.Write(numeros[i]);

            // Agregar coma solo si no es el último número en mostrarse
            if (i > 0)
            {
                Console.Write(", ");
            }
        }
    }
}