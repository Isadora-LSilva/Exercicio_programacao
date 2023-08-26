// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");

Console.WriteLine("Olá, qual seu nome?");
    string nome = Console.ReadLine();
repete:
Console.WriteLine("Olá " + nome + " ,como deseja simular seu empréstimo?");

Console.WriteLine("Temos duas simulações, \n 1- Pelo valor da parcela \n 2- Pelo valor total desejado");
int seletor = int.Parse(Console.ReadLine());
int quantidadeparcelas = 0;
double valortotal = 0;
int valorparcela = 0;
switch (seletor)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Por favor informe a quantidade de parcelas do seu empréstimo:");
        quantidadeparcelas = int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor informe o valor que deseja pagar na parcela:");
        valorparcela = int.Parse(Console.ReadLine());

        valortotal = quantidadeparcelas* valorparcela;

        Console.WriteLine("Você receberá um empréstimo de "+valortotal+". Ele será pago em \r\n"+quantidadeparcelas+" meses em parcelas de "+valorparcela);
        
        break;
    case 2:
        Console.Clear();
        Console.WriteLine("Por favor informe a quantidade de parcelas do seu empréstimo:");
        quantidadeparcelas = int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor informe o valor total que deseja receber:");
        valorparcela = int.Parse(Console.ReadLine());

        valortotal = quantidadeparcelas * valorparcela;

        Console.WriteLine("Você receberá um empréstimo de " + valortotal + ". Ele será pago em \r\n" + quantidadeparcelas + " meses em parcelas de " + valorparcela);
        break;
    default:
        Console.WriteLine("Erro na digitação, repita o processo..");
        Console.ReadLine();
        Console.Clear();
        goto repete;
        break;
}