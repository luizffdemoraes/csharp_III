using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "12345698";
pedro.Salario = 2000;

//Console.WriteLine("Nome: " + pedro.Nome);
//Console.WriteLine("CPF: " + pedro.Cpf);
//Console.WriteLine("Salário: " + pedro.Salario);

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "1241661613";
paula.Salario = 5000;

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());

gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);

Console.WriteLine("Total de Bonificacao:" + gerenciador.getBonificacao());

Console.ReadKey();