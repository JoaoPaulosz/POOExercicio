using System;
using System.Globalization;

namespace OopExercicioFixacao {
    class ContaBancaria {
        public string Titular { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria() {

        }

        public ContaBancaria(string titular, int numero) {
            Titular = titular;
            Numero = numero;
        }

        public ContaBancaria(string titular, int numero, double depositoInicial) : this(titular, numero) {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= saque + 5.0;
        }
        public override string ToString() {
            return "Conta " + Numero +
                ", " + "Titular: " + Titular +
                ", " + "Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
