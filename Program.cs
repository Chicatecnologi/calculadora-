using System;

class Calculadora
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("Calculadora\n");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");
            Console.WriteLine("5 - Elevar un número a la potencia");
            Console.WriteLine("6 - Salir");
            Console.Write("introduce un numero dependiendo de lo que quieras hacer: ");

            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 6)
            {
                Console.Write("Opción inválida. Intente de nuevo: ");
            }

            if (opcion == 6)
            {
                Console.WriteLine("Saliendo de la calculadora...");
                break;
            }

            double numero1, numero2 = 0, resultado = 0; 
            Console.Write("introduce el primer numero: ");
            while (!double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.Write("Entrada inválida. Intente de nuevo: ");
            }

            if (opcion != 5) 
            {
                Console.Write("introduce el segundo número: ");
                while (!double.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.Write("Entrada inválida. Intente de nuevo: ");
                }
            }

            switch (opcion)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultado}");
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultado}");
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado: {numero1} * {numero2} = {resultado}");
                    break;
                case 4:
                    if (numero2 == 0)
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    else
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado: {numero1} / {numero2} = {resultado}");
                    }
                    break;
                case 5:
                    Console.Write("Ingrese la potencia: ");
                    while (!double.TryParse(Console.ReadLine(), out numero2))
                    {
                        Console.Write("Entrada inválida. Intente de nuevo: ");
                    }
                    resultado = Math.Pow(numero1, numero2);
                    Console.WriteLine($"Resultado: {numero1} ^ {numero2} = {resultado}");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (opcion != 6);
    }
}
