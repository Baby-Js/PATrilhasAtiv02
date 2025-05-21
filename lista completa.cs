using System;
using System.Reflection.Metadata;
using System.Runtime;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        Console.WriteLine("1.Soma");
        Console.WriteLine("2.Dobre");
        Console.WriteLine("3.metade");
        Console.WriteLine("4.Quadrado");
        Console.WriteLine("5.Divisão");
        Console.WriteLine("6.Raiz Quadrada");
        Console.WriteLine("7.Subtração");
        Console.WriteLine("8.Absoluto");
        Console.WriteLine("9.multiplicação");
        Console.WriteLine("10.Divisão por 2");
        Console.Write("Digite uma opçao para escolher cada caso: ");
        int opcao = int.Parse(Console.ReadLine());


        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite um numero: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("digite outro numero: ");
                int num1 = int.Parse(Console.ReadLine());
                int res = num + num1;
                Console.WriteLine("resultado da soma é: {0}", res);
                break;

            case 2:
                Console.WriteLine("Digite um numero para saber o dobro: ");
                int num3 = int.Parse(Console.ReadLine());
                int dobro = num3 * 2;
                Console.WriteLine("O dobro de {0} é: {1}", num3, dobro);
                break;

            case 3:
                Console.WriteLine("Digite um numero: ");
                double numb = double.Parse(Console.ReadLine());
                double metade = numb / 2;
                Console.WriteLine("A metade de {0} é: {1}", numb, metade);
                break;

            case 4:
                Console.WriteLine("Digite uma numero");
                float num4 = float.Parse(Console.ReadLine());
                float resultado = num4 * num4;
                Console.WriteLine("O quadrado de {0} é {1}", num4, resultado);
                break;

            case 5:
                Console.WriteLine("Digite o primeiro numero: ");
                float numb1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                float numb2 = float.Parse(Console.ReadLine());
                float divisao = numb1 / numb2;
                Console.WriteLine("{0} / {1} = {2}", numb1, numb2, divisao);
                break;

            case 6:
                Console.WriteLine("Digite um numero para saber a raiz: ");
                float numb3 = float.Parse(Console.ReadLine());
                Console.WriteLine("a raiz quadrada {0} é: {1}", Math.Sqrt(numb3));

                break;

            case 7:
                Console.WriteLine("Digite o primeiro numero: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o segundo numero: ");
                int numero1 = int.Parse(Console.ReadLine());
                int calculo = numero - numero1;
                Console.WriteLine("{0} - {1} = {2}", numero, numero1, calculo);
                break;

            case 8:
                Console.WriteLine("Digite um numero: ");
                float number = float.Parse(Console.ReadLine());
                float result = Math.Abs(number);
                Console.WriteLine(result);
                break;

            case 9:
                Console.WriteLine("Digite o primerio numero: ");
                int numero3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int numero4 = int.Parse(Console.ReadLine());
                int multiplicacao = numero3 * numero4;
                Console.WriteLine("{0} x {1} = {2}", numero3, numero4, multiplicacao);
                break;

            case 10:
                Console.WriteLine("Digite um numero: ");
                float numb4 = float.Parse(Console.ReadLine());
                float resultado1 = numb4 / 2;
                Console.WriteLine("A divisão de {0} por 2 é: {1} ", numb4, resultado1);
                break;

            default:
                Console.WriteLine("Opção invalida");
                break;


                
        }
    }
}
