// See https://aka.ms/new-console-template for more information
using OperacoesMatematicas;

Console.WriteLine("Operações Matematicas!");

Operacoes operacoes = new Operacoes();
Console.WriteLine("Soma = " + operacoes.Soma.soma(2, 2));
Console.WriteLine("Subtrção = " + operacoes.Subtracao.subtracao(4, 2));
Console.WriteLine("Divisão = " + operacoes.Divisao.divisao(2, 2));
Console.WriteLine("Multiplicacao = " + operacoes.Multiplicacao.multiplicacao(2, 2));

Console.ReadKey();
