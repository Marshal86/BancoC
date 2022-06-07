using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    class Conta
    {
        
        public int _numero_Conta;
        public string Nome_Titular { get; set; }
        private double _valor_Inicial;

        public Conta(int numero_Conta, string nome_Titular)
        {
            _numero_Conta = numero_Conta;
            Nome_Titular = nome_Titular;
        }

        public int Numero_Conta
        {
            get { return _numero_Conta; }
            set
            {
                
                do
                {
                    if (_numero_Conta == 0000)
                    {
                        _numero_Conta = value;

                    }
                    else { 
                        Console.WriteLine("Não podemos alterar o valor da conta");
                          };
                   } while (!true);         
            }
        }
        public double Valor_inicial
        {
            get {return _valor_Inicial; }

            set
            {
                if (value >= 0.0)
                {
                    _valor_Inicial = value;
                } else
                {
                   
                       
                  Console.WriteLine("Valor Informado não é maior que zero, favor informar novo valor");
                    
                    
                }
            }
        }

        public double Deposito (double deposito)
        {
            return Valor_inicial += deposito;
        }


        public double Saque (double saque)
        {
             Valor_inicial -= saque;
            return Valor_inicial=Valor_inicial - 5;
            
        }

        public override string ToString()
        {
            return "O Numero da conta é " + Numero_Conta + ", O Nome do Titular é: " + Nome_Titular + " e o valor inicial é: "+ Valor_inicial;
        }


    }
}
