
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_aula_de_logica
{
internal class Program
{
    static void Main(string[] args)
    {
        int num1;
        int num2;
        int opcao = 0;

        while (opcao != 8)
        {

            Console.WriteLine("\nCalculadora\n");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Somar mais de 2 números");
            Console.WriteLine("5 - Dividir");
            Console.WriteLine("6 - Media entre 2 ou mais números");
            Console.WriteLine("7 - ");
            Console.WriteLine("8 - Sair\n");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Digite o primeiro número:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                num2 = int.Parse(Console.ReadLine());
                somar(num1, num2);
                Console.WriteLine("O resultado da soma é:" + somar(num1, num2));
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite o primeiro número:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                num2 = int.Parse(Console.ReadLine());
                subtrair(num1, num2);
                Console.WriteLine("O resultado da subtração é:" + subtrair(num1, num2));
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Digite o primeiro número:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                num2 = int.Parse(Console.ReadLine());
                multiplicar(num1, num2);
                Console.WriteLine("O resultado da multiplicação é:" + multiplicar(num1, num2));
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Quantos números você quer somar");
                int quantidade = int.Parse(Console.ReadLine());
                int[] numeros = new int[quantidade];
                for (int i = 0; i < quantidade; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número");
                    numeros[i] = int.Parse(Console.ReadLine());
                    somarN(numeros);
                    Console.WriteLine("O resultado da soma é:" + somarN(numeros));
                }
            }
                else if (opcao == 5)
                {
                    Console.WriteLine("Digite o primeiro número:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("O resultado da divisão é: " + dividir(num1, num2));
                }
                else if (opcao == 6)
                {
                    Console.WriteLine("Quantos números você quer usar para calcular a média?");
                    int quantidade = int.Parse(Console.ReadLine());
                    int[] numeros = new int[quantidade];

                    for (int i = 0; i < quantidade; i++)
                    {
                        Console.WriteLine($"Digite o {i + 1}º número:");
                        numeros[i] = int.Parse(Console.ReadLine());
                    }

                    double resultadoMedia = calcularMedia(numeros);
                    Console.WriteLine("A média dos números é: " + resultadoMedia);
                }


            }
        }

    static int somar(int a, int b)
    {
        int resultadoSoma = a + b;
        return resultadoSoma;
    }
    static int subtrair(int a, int b)
    {
        int resultadosubtrair = a - b;
        return resultadosubtrair;
    }
    static int multiplicar(int a, int b)
    {
        int resultadomultiplicar = a * b;
        return resultadomultiplicar;
    }
    static int somarN(int[] numeros)
    {
        int resultadosomarN = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            resultadosomarN += numeros[i];
        }
;
        return resultadosomarN;
    }
    static double dividir(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: divisão por zero não é permitida.");
            return double.NaN; // Retorna "Not a Number"
        }
        double resultadoDivisao = (double)a / b;
        return resultadoDivisao;
    }
        static double calcularMedia(int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            double media = (double)soma / numeros.Length;
            return media;
        }


    }
}
