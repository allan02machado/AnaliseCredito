using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            int parcelas;
            double valor;
            double valorParcela;
            double rendaMensal;
            double parcelaMaxima;

            
            Console.WriteLine("Precisando de um empréstimo?");
            Console.Write("Digite o valor que deseja: ");
            valor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de parcelas que deseja: ");
            parcelas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite sua renda mensal: ");
            rendaMensal = Convert.ToDouble(Console.ReadLine());
            
            valorParcela = valor / parcelas;
            parcelaMaxima = rendaMensal * 30 /100;

            Console.WriteLine($"Valor das parcelas ficariam: {valorParcela:C}");
            Console.WriteLine($"Valor da parcela máxima: {parcelaMaxima:C}");

            if(valorParcela <= parcelaMaxima)
            {
                Console.WriteLine("\nParabéns, seu crédito foi aprovado!!");
            }
            else
            {
                Console.WriteLine("\nSeu crédito não foi aprovado");
            }
        }
    }
}
