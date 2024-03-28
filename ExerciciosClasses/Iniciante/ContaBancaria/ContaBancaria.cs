using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsharpFundamentos.ExerciciosClasses.Iniciante.ContaBancaria
{
    public class ContaBancaria
    {
        //dados para a conta bancaria
        private int numeroDaConta;
        private string? nomeDoTitular;
        private double saldo;

        //construtor da classe para receber os dados
        public ContaBancaria(int numeroDaConta, string? nomeDoTitular)
        {
            this.numeroDaConta = numeroDaConta;
            this.nomeDoTitular = nomeDoTitular;
            this.saldo = 0.0;
        }

        //metodo para depositar
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                Console.WriteLine($"Deposito de R${valor} efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor do depósito inválido!");
            }
        }

        //metodo para sacar dinheiro da conta
        public void Sacar(double valor)
        {
            if (valor > 0 && saldo >= valor)
            {
                this.saldo -= valor;
                Console.WriteLine($"Saque de R${valor} efetuado com sucesso!");
                Console.WriteLine($"Seu saldo atual é de R${this.ObterSaldo()}");
            }else{
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        //metodo para retornar/obter o saldo da conta
        public double ObterSaldo() => this.saldo;
    }
}