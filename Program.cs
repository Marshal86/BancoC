using System;
using System.Globalization;


namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)


        {

            Conta conta = new Conta(0000, "Cliente");
            Console.WriteLine("informe o numero da conta");
            conta.Numero_Conta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("informe o nome do titular da conta");
            conta.Nome_Titular = Console.ReadLine();

            Console.WriteLine("informe o valor da conta");
            conta.Valor_inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          

            Console.WriteLine(conta);


            Console.WriteLine("Entre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizada: ");
            Console.WriteLine(conta);


            Console.WriteLine("Entre um valor para Saque ");
            conta.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizada: ");
            Console.WriteLine(conta);


        }
    }
}
