using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "12345698";
pedro.Salario = 2000;
Console.WriteLine("Total de Funcionarios " + Funcionario.totalDeFuncionarios);

//Console.WriteLine("Nome: " + pedro.Nome);
//Console.WriteLine("CPF: " + pedro.Cpf);
//Console.WriteLine("Salário: " + pedro.Salario);

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "1241661613";
paula.Salario = 5000;
Console.WriteLine("Total de Funcionarios " + Funcionario.totalDeFuncionarios);

Funcionario andre = new Diretor();
pedro.Nome = "Andre";
pedro.Salario = 3000;

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());
Console.WriteLine("Total de Funcionarios " + Funcionario.totalDeFuncionarios);

gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);

Console.WriteLine("Total de Bonificacao: " + gerenciador.getBonificacao());

Console.ReadKey();