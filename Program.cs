using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double  montante, capital, taxaJuros, tempo, Juros;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(" Bem vindo a calculadora de Juros simples! \n ");
            Console.WriteLine(" Entre com os dados na ordem dos solicitados \n ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Digite o valor de capital:");
            capital = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite a taxa de juros ...:");
            taxaJuros = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite o tempo em meses ..: ");
            tempo = Convert.ToDouble(Console.ReadLine());
            
            Juros = capital * (taxaJuros / 100) * tempo;
            montante = (capital + Juros);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(" Juros simples (j) \n " );
            Console.WriteLine($" Capital [c] (R $).......: {capital} ");
            Console.WriteLine($" Taxa de juros [i] (%)..: {taxaJuros} ");
            Console.WriteLine($" Tempo [t] (meses)......: {tempo} \n ");
             Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($" Juros (R$).....: {Juros} ");
            Console.WriteLine($" montante (R$)..: {montante} ");
            Console.ResetColor();
        }
    }
}
