using bytebank_ADM.Funcionarios;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

Funcionario pedro = new Funcionario(1);
pedro.Nome = "João";
pedro.Cpf = "12345698";
pedro.Salario = 2000;

Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine("CPF: " + pedro.Cpf);
Console.WriteLine("Salário: " + pedro.Salario);
Console.WriteLine("Bonificação: " + pedro.getBonificacao());

Console.ReadKey();