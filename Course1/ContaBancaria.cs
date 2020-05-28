﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course1
{
    class ContaBancaria
    {
        public int Numero { get; private set;} // o número da conta não poderá ser alterado por isso o private
        public string Titular { get; set; }
        public double Saldo { get;  private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo ) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(Double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", Titular: "
            + ", Saldo: $"
            + Saldo.ToString("F2");
        }
    }
}
