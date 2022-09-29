using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario pedro = new Funcionario("12345698", 2000);
pedro.Nome = "Pedro";
Console.WriteLine("Total de Funcionarios " + Funcionario.totalDeFuncionarios);

//Console.WriteLine("Nome: " + pedro.Nome);
//Console.WriteLine("CPF: " + pedro.Cpf);
//Console.WriteLine("Salário: " + pedro.Salario);

Diretor paula = new Diretor("1241661613", 5000);
paula.Nome = "Paula";

Console.WriteLine("Total de Funcionarios " + Funcionario.totalDeFuncionarios);

Funcionario andre = new Diretor("1241661613", 3000);
andre.Nome = "Andre";

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());
Console.WriteLine("Total de Funcionarios " + Funcionario.totalDeFuncionarios);

gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);

Console.WriteLine("Total de Bonificacao: " + gerenciador.getBonificacao());

andre.AumentarSalario();
Console.WriteLine("Novo salário do André: " + andre.Salario);

pedro.AumentarSalario();
Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);


Console.ReadKey();