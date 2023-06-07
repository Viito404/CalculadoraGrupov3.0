namespace CalculadoraGrupov3._0
{
     internal class Program
     {
          static void Main(string[] args)
          {
               string opcao = "";
               string operador = "";

               Console.WriteLine("Entre com uma opção:");
               Console.WriteLine("\nSoma(1)");
               Console.WriteLine("\nDivisão(2)");
               Console.WriteLine("\nSubtracao(3)");
               Console.WriteLine("\nSair(S)");
               opcao = Console.ReadLine();

               switch (opcao)
               {
                    case "1": operador = "+"; break;
                    case "2": operador = "/"; break;
                    case "3": operador = "-"; break;
                    case "s": Environment.Exit(0); break;
                    default: Environment.Exit(0); Console.WriteLine("Saindo..."); break;

               }

               Console.WriteLine($"\nA operação escolhida foi {operador}.");

               Console.Write("\nEntre com o primeiro valor:\n> ");
               int valor1 = Convert.ToInt32(Console.ReadLine());


               Console.Write("\nEntre com o segundo valor:\n> ");
               int valor2 = Convert.ToInt32(Console.ReadLine());
          }
     }
}