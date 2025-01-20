using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Bem vindo! Escolha uma opção:");
            Console.WriteLine("1 - Soma:");
            Console.WriteLine("2 - Subtração:");
            Console.WriteLine("3 - Multiplicação:");
            Console.WriteLine("4 - Divição:");
            Console.WriteLine("5 - Sair:");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracacao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção infalida"); break;
            }
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


        static void Multiplicacao()
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