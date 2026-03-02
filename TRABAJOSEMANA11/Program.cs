using System;
using System.Collections.Generic;

class TraductorBasico
{
    // Diccionario principal: Clave (Inglés) -> Valor (Español)
    static Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        {"time", "tiempo"}, {"person", "persona"}, {"year", "año"},
        {"way", "camino"}, {"day", "día"}, {"thing", "cosa"},
        {"man", "hombre"}, {"world", "mundo"}, {"life", "vida"},
        {"hand", "mano"}, {"part", "parte"}, {"child", "niño/a"},
        {"eye", "ojo"}, {"woman", "mujer"}, {"place", "lugar"},
        {"work", "trabajo"}, {"week", "semana"}, {"case", "caso"},
        {"point", "punto"}, {"government", "gobierno"}, {"company", "empresa"}
    };

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n================ MENU ================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

            switch (opcion)
            {
                case 1: TraducirFrase(); break;
                case 2: AgregarPalabra(); break;
                case 0: Console.WriteLine("¡Hasta luego!"); break;
                default: Console.WriteLine("Opción no válida."); break;
            }
        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("\nIngrese la frase a traducir: ");
        string frase = Console.ReadLine();
        
        // Dividimos la frase en palabras (separando por espacios)
        string[] palabras = frase.Split(' ');
        List<string> resultado = new List<string>();

        foreach (string p in palabras)
        {
            // Limpiamos signos de puntuación básicos para buscar la palabra limpia
            string limpia = p.Trim(new char[] { '.', ',', '!', '?' });
            
            if (diccionario.ContainsKey(limpia))
            {
                // Reemplazamos manteniendo los signos originales si es posible
                resultado.Add(p.ToLower().Replace(limpia.ToLower(), diccionario[limpia]));
            }
            else
            {
                resultado.Add(p);
            }
        }

        Console.WriteLine("Traducción esperada: " + string.Join(" ", resultado));
    }

    static void AgregarPalabra()
    {
        Console.Write("\nIngrese palabra en inglés: ");
        string ingles = Console.ReadLine().Trim();
        Console.Write("Ingrese traducción en español: ");
        string espanol = Console.ReadLine().Trim();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine("¡Palabra agregada con éxito!");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}