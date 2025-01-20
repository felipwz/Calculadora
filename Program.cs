using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }


        static void Menu()
        {

        }
        static void Soma()

        {
            Console.WriteLine("Escreva um número: ");
            if (!float.TryParse(Console.ReadLine(), out float v1))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }

            Console.WriteLine("Escreva mais um número: ");
            if (!float.TryParse(Console.ReadLine(), out float v2))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }


            float somaResultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {somaResultado}");
        }


        static void Subtracacao()
        {
            Console.WriteLine("Escreva um número: ");
            if (!float.TryParse(Console.ReadLine(), out float v1))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }

            Console.WriteLine("Escreva mais um número: ");
            if (!float.TryParse(Console.ReadLine(), out float v2))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }


            float somaResultado = v1 - v2;
            Console.WriteLine($"O resultado da soma é: {somaResultado}");
        }


        static void Multicacao()
        {
            Console.WriteLine("Escreva um número: ");
            if (!float.TryParse(Console.ReadLine(), out float v1))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }

            Console.WriteLine("Escreva mais um número: ");
            if (!float.TryParse(Console.ReadLine(), out float v2))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }


            float somaResultado = v1 * v2;
            Console.WriteLine($"O resultado da soma é: {somaResultado}");
        }

        static void Divisao()
        {
            Console.WriteLine("Escreva um número: ");
            if (!float.TryParse(Console.ReadLine(), out float v1))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }

            Console.WriteLine("Escreva mais um número: ");
            if (!float.TryParse(Console.ReadLine(), out float v2))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }


            float somaResultado = v1 / v2;
            Console.WriteLine($"O resultado da soma é: {somaResultado}");
        }

    }



}