using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

// CarcularBonificacao();
UsarSistema();

void CarcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer pedro = new Designer("83.222.048-39");
    pedro.Nome = "Pedro";

    Desenvolvedor samya = new Desenvolvedor("33.111.048-39");
    samya.Nome = "Samya";

    Diretor paula = new Diretor("159.753.398-04");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("981.198.778-53");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("326.985.628-89");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(samya);

    Console.WriteLine("Total de Bonificação: "+ gerenciador.getBonificacao());
}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("326.985.628-89");
    ursula.Nome = "Ursula";
    ursula.Senha = "321";

    Funcionario pedro = new Designer("326.985.628-89");
    pedro.Nome = "Pedro";
    //pedro.Senha = "321";

    sistemaInterno.Logar(roberta, "123");
    sistemaInterno.Logar(ursula, "321");
    //sistemaInterno.Logar(pedro, "321");
}

Console.ReadKey();