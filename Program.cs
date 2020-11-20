using System;

namespace Aula_01
{
    class Program
    {
        static void Main(string[] args)
        {

            bool retornaAoInicio = true;

            Console.WriteLine("INFORME O PRIMEIRO NÚMERO:");
            decimal numero1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("INFORME O SEGUNDO NÚMERO:");
            decimal numero2 = Convert.ToDecimal(Console.ReadLine());



            while (retornaAoInicio)
            {
                // EX. 1 - CRIAR UM PROGRAMA QUE SIMULA UMA CALCULADORA.
                // DEVE INFORMAR AO USUARIO AS OPÇOES DISPONÍVELS, POR EXEMPLO:
                // 1 - SOMA
                // 2 - SUBTRACAO
                // 3 - DIVISAO
                // 4- MULTIPLICACAO

                //APOS O USUARIO INFORMAR A OPERACAO DESEJADA, SOLICITAR QUE INFORME DOIS NUMEROS PARA REALIZAR
                //A OPERACAO. APOS EXECUTAR, INFORMAR AO USUARIO O RESULTADO

                Console.WriteLine("INFORME A OPERAÇÃO DESEJADA:");
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("/");
                Console.WriteLine("*");
                string operacao = Console.ReadLine();

                switch (operacao)
                {
                    case "+":
                        Console.WriteLine(numero1 + numero2);
                        retornaAoInicio = false;
                        break;
                    case "-":
                        Console.WriteLine(numero1 - numero2);
                        retornaAoInicio = false;
                        break;
                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                } 
            }

        }
    }
}
