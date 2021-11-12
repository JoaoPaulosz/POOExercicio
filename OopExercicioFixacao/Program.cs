using System;
using System.Globalization;

namespace OopExercicioFixacao {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta = new ContaBancaria();

            Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            Console.WriteLine();
            char verifica = char.Parse(Console.ReadLine());
            if (verifica == 's' || verifica == 'S') {
                Console.Write("Entre com o Valor do depósito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nomeTitular, numConta, valor);
                }
            else if (verifica != 's' && verifica != 'S' && verifica != 'n' && verifica != 'N') {
                Console.WriteLine("Está não fou uma resposta valida");
                }
            else {
                conta = new ContaBancaria(nomeTitular, numConta);
                }
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta);
            }
        }
    }
