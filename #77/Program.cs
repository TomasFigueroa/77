using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una SortedList inglés-español
        SortedList<string, string> diccionario = new SortedList<string, string>();

        // Agregar palabras al diccionario
        diccionario.Add("hello", "hola");
        diccionario.Add("goodbye", "adiós");
        diccionario.Add("cat", "gato");
        diccionario.Add("dog", "perro");
        diccionario.Add("house", "casa");

        string palabra;
        while (true)
        {
            Console.WriteLine("Ingresa una palabra en inglés para traducirla al español (o escribe 'exit' para salir):");
            palabra = Console.ReadLine().ToLower(); // Convertir la entrada a minúsculas

            if (palabra == "exit")
            {
                break; // Salir del bucle si se ingresa "exit"
            }

            if (diccionario.ContainsKey(palabra))
            {
                string traduccion = diccionario[palabra];
                Console.WriteLine($"{palabra} en español es {traduccion}");
            }
            else
            {
                Console.WriteLine($"La palabra {palabra} no está en el diccionario.");
            }
        }

        Console.WriteLine("Programa finalizado. Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
