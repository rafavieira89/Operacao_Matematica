using System;

namespace Operacoes_matematicas_dede
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, operacao_selecionada, resultado;
            double resultado_fracionado;

            // Instrução para o usuario inputar informações necessarias para o calculo.

            Console.WriteLine("Selecione a operação que deseja fazer:");         
            Console.WriteLine("Adição - 1");
            Console.WriteLine("Subtração - 2");
            Console.WriteLine("Multiplicação - 3");
            Console.WriteLine("Divisão - 4");
            
            operacao_selecionada = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine(" Digite o primeiro numero: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Digite o segundo numero: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if(operacao_selecionada == 1)
            {
                resultado = number1 + number2;
                Console.WriteLine(" O resultado foi : " + resultado);
            }
            else if (operacao_selecionada == 2)
            {
                resultado = number1 - number2;
                Console.WriteLine(" O resultado foi : " + resultado);
            }
            else if( operacao_selecionada == 3)
            {
                resultado = number1 * number2;
                Console.WriteLine(" O resultado foi : " + resultado);
            }
            else if (operacao_selecionada == 4)
            {
                resultado_fracionado = (double)number1 / number2;
                Console.WriteLine(" O resultado foi : " + resultado_fracionado);
            }



                    
            

        }
    }
}
