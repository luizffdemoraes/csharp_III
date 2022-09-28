using bytebank_ADM.Funcionarios;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

Funcionario pedro = new Funcionario();
pedro.Nome = "João";
pedro.Cpf = "12345698";
pedro.Salario = 2000;

Console.WriteLine("Bonificação: " + pedro.getBonificacao());