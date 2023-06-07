namespace CalculadoraGrupov3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            string operador = "";

               Console.WriteLine("Entre com uma opção:");
               Console.WriteLine("\nSoma (1)\nDivisão (2)\nSubtracao (3)\nMultiplicação (4)");
               Console.WriteLine("\nSair(S)");
               Console.Write("\n> ");
               opcao = Console.ReadLine().ToLower();

               switch (opcao)
               {
                    case "1": operador = "+"; break;
                    case "2": operador = "/"; break;
                    case "3": operador = "-"; break;
                    case "4": operador = "*"; break;
                    case "s": Environment.Exit(0); break;
                    default: Console.WriteLine("Entre com uma opção válida!"); break;
               }

            Console.WriteLine($"\nA operação escolhida foi {operador}.");

            Console.Write("\nEntre com o primeiro valor:\n> ");
            int valor1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("\nEntre com o segundo valor:\n> ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int resultado = fazerCalculo(operador, valor1, valor2);

            Console.WriteLine($"O resultado da operação é: {resultado}");
        }

        private static int fazerCalculo(string operador, int valor1, int valor2)
        {
            int resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
            }

            return resultado;
        }
    }
}