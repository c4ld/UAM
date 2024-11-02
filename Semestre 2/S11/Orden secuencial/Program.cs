using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario el tamaño del vector
        Console.Write("Ingrese el tamaño del vector: ");
        int tamaño = int.Parse(Console.ReadLine());

        // Solicitar al usuario el valor mínimo
        Console.Write("Ingrese el valor mínimo: ");
        int min = int.Parse(Console.ReadLine());

        // Solicitar al usuario el valor máximo
        Console.Write("Ingrese el valor máximo: "); 
        int max = int.Parse(Console.ReadLine());

        // Verificar que el valor máximo sea mayor que el mínimo
        if (max <= min)
        {
            Console.WriteLine("El valor máximo debe ser mayor que el valor mínimo.");
            return;
        }

        // Crear un vector de números aleatorios
        int[] vector = new int[tamaño];
        Random random = new Random();

        // Llenar el vector con números aleatorios entre el mínimo y el máximo
        for (int i = 0; i < tamaño; i++)
        {
            vector[i] = random.Next(min, max + 1);
        }

        Console.WriteLine("Vector generado: \n");  
        for (int i = 0; i < tamaño; i++)
        {
            Console.Write(vector[i] + " ");
        }
        // Ordenar el vector usando el método burbuja
        for (int i = 0; i < vector.Length - 1; i++)
        {
            for (int j = 0; j < vector.Length - 1 - i; j++)
            {
                if (vector[j] > vector[j + 1])
                {
                    int temp = vector[j];
                    vector[j] = vector[j + 1];
                    vector[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("\n\nVector ordenado: \n");  
        for (int i = 0; i < tamaño; i++)
        {
            Console.Write(vector[i] + " ");
        }
        // Solicitar al usuario un número dentro del rango
        Console.WriteLine("\n\nIngrese un número entre " + min + " y " + max + ":");
        int numeroBuscado = int.Parse(Console.ReadLine());

        // Verificar que el número esté dentro del rango
        if (numeroBuscado < min || numeroBuscado > max)
        {
            Console.WriteLine("El número ingresado está fuera del rango.");
            return;
        }

        // Contar las ocurrencias del número buscado en el vector
        int ocurrencias = 0;
        foreach (int num in vector)
        {
            if (num == numeroBuscado)
            {
                ocurrencias++;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"\nEl número {numeroBuscado} aparece {ocurrencias} veces en el vector.");
    }
}
