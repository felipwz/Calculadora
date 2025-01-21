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

            while (true)
            {

                Console.Clear();

                Console.WriteLine("Bem vindo! Escolha uma opção:");
                Console.WriteLine("1 - Soma:");
                Console.WriteLine("2 - Subtração:");
                Console.WriteLine("3 - Multiplicação:");
                Console.WriteLine("4 - Divisão:");
                Console.WriteLine("5 - Sair:");

                short res;
                while (!short.TryParse(Console.ReadLine(), out res) || res < 1 || res > 5)
                {

                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");


                }

                switch (res)
                {
                    case 1: Soma(); break;
                    case 2: Subtracao(); break;
                    case 3: Multiplicacao(); break;
                    case 4: Divisao(); break;
                    case 5: Console.Clear(); System.Environment.Exit(0); break;

                    default:
                        Console.WriteLine("Erro!"); break;
                }
            }
        }

        static void Soma()
        {
            float v1, v2;

            Console.WriteLine("Escreva um número: ");
            while (!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            }

            Console.WriteLine("Escreva mais um número: ");
            while (!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            }

            float somaResultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {somaResultado}");

            Console.WriteLine("Deseja fazer mais alguma operação?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            short res;
            while (!short.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            }

            switch (res)
            {
                case 1: Menu(); break;
                case 2: Console.Clear(); System.Environment.Exit(0); break;
                case 5: Console.Clear(); System.Environment.Exit(0); break;
            }
        }


        static void Subtracao()
        {
            float v1, v2;

            Console.WriteLine("Escreva um número: ");
            while (!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            }

            Console.WriteLine("Escreva mais um número: ");
            while (!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            }

            float subtracaoResultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {subtracaoResultado}");

            Console.WriteLine("Deseja fazer mais alguma operação?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            short res;
            while (!short.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            }


            switch (res)
            {
                case 1: Menu(); break;
                case 2: Console.Clear(); System.Environment.Exit(0); break;
                case 5: Console.Clear(); System.Environment.Exit(0); break;
            }
        }

        static void Multiplicacao()
        {
            float v1, v2;

            Console.WriteLine("Escreva um número: ");
            while (!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");

            }

            Console.WriteLine("Escreva mais um número: ");
            while (!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");

            }

            float multiplicacaoResultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {multiplicacaoResultado}");

            Console.WriteLine("Deseja fazer mais alguma operação?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            short res;
            while (!short.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");

            }

            switch (res)
            {
                case 1: Menu(); break;
                case 2: Console.Clear(); System.Environment.Exit(0); break;
                case 5: Console.Clear(); System.Environment.Exit(0); break;
            }
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

            if (v2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return;
            }

            float divisaoResultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {divisaoResultado}");

            Console.WriteLine("Deseja fazer mais alguma operação?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            short res;
            while (!short.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            }

            switch (res)
            {
                case 1: Menu(); break;
                case 2: Console.Clear(); System.Environment.Exit(0); break;
                case 5: Console.Clear(); System.Environment.Exit(0); break;
            }
        }
    }
}