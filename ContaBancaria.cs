using System;

class ContaBancaria
{
    private string nome;
    private int numeroConta;
    private decimal saldo;

    public ContaBancaria(string nome, int numeroConta, decimal saldoInicial)
    {
        this.nome = nome;
        this.numeroConta = numeroConta;
        this.saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        if (valor >= 1)
        {
            saldo += valor;
            Console.WriteLine("depósito realizado");
        }
        else
        {
            Console.WriteLine("depósito mínimo é 1 real");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine("saque realizado");
        }
        else
        {
            Console.WriteLine("saldo insuficiente");
        }
    }

    public void ExibirDados()
    {
        Console.WriteLine("Dados da Conta");
        Console.WriteLine("Titular: " + nome);
        Console.WriteLine("Conta: " + numeroConta);
        Console.WriteLine("Saldo: R$" + saldo.ToString("F2"));
    }
}
