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
            Console.WriteLine("4 - Divisão:");
            Console.WriteLine("5 - Sair:");

            if (!float.TryParse(Console.ReadLine(), out float res))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção inválida!"); break;
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

            Console.WriteLine("Deseja fazer mais alguma operação?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            if (!float.TryParse(Console.ReadLine(), out float res))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }

            switch (res)
            {
                case 1: Menu(); break;
                case 2: System.Environment.Exit(0); break;
                default: System.Environment.Exit(0); break;
            }
        }

        static void Subtracao()
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

            float subtracaoResultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {subtracaoResultado}");

            Console.WriteLine("Deseja fazer mais alguma operação?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            if (!float.TryParse(Console.ReadLine(), out float res))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }

            switch (res)
            {
                case 1: Menu(); break;
                case 2: System.Environment.Exit(0); break;
                default: System.Environment.Exit(0); break;
            }
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

            float multiplicacaoResultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {multiplicacaoResultado}");

            Console.WriteLine("Deseja fazer mais alguma operação?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            if (!float.TryParse(Console.ReadLine(), out float res))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }

            switch (res)
            {
                case 1: Menu(); break;
                case 2: System.Environment.Exit(0); break;
                default: System.Environment.Exit(0); break;
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
            if (!float.TryParse(Console.ReadLine(), out float res))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                return;
            }

            switch (res)
            {
                case 1: Menu(); break;
                case 2: System.Environment.Exit(0); break;
                default: System.Environment.Exit(0); break;
            }
        }
    }
}