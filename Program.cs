using OldDragonPersonagens.Factories;
using OldDragonPersonagens.Models;
using OldDragonPersonagens.Services;
using OldDragonPersonagens.Strategies;

Console.OutputEncoding = System.Text.Encoding.UTF8;

bool continuar = true;

while (continuar)
{
    Console.Clear();
    ExibirCabecalho();
    ExibirMenuInicial();

    int opcaoInicial = EntradaService.LerInteiro("Opção: ");

    switch (opcaoInicial)
    {
        case 1:
            CriarNovoPersonagem();
            break;

        case 2:
            PersonagemArquivoService.EscolherPersonagemSalvo();
            break;

        case 0:
            Console.WriteLine("Programa encerrado.");
            continuar = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Escolha 1, 2 ou 0.");
            EntradaService.AguardarEnter();
            break;
    }
}

static void ExibirCabecalho()
{
    Console.WriteLine("========================================");
    Console.WriteLine("   CRIADOR DE PERSONAGENS OLD DRAGON    ");
    Console.WriteLine("========================================");
    Console.WriteLine();
}

static void ExibirMenuInicial()
{
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Criar novo personagem");
    Console.WriteLine("2 - Escolher personagem salvo");
    Console.WriteLine("0 - Sair");
    Console.WriteLine();
}

static void CriarNovoPersonagem()
{
    Console.Clear();
    Console.WriteLine("=== CRIAÇÃO DE NOVO PERSONAGEM ===");
    Console.WriteLine();

    string nome = EntradaService.LerTextoObrigatorio("Digite o nome do personagem: ");

    Console.WriteLine();
    EstrategiaAtributosFactory.ExibirMetodosDisponiveis();
    int opcaoMetodo = EntradaService.LerInteiro("Opção: ");

    IEstrategiaAtributos estrategia;

    try
    {
        estrategia = EstrategiaAtributosFactory.CriarEstrategia(opcaoMetodo);
    }
    catch (ArgumentException erro)
    {
        Console.WriteLine(erro.Message);
        EntradaService.AguardarEnter();
        return;
    }

    Console.WriteLine();
    Console.WriteLine($"Método escolhido: {estrategia.Nome}");
    Console.WriteLine(estrategia.Descricao);
    Console.WriteLine();

    Atributos atributos = estrategia.GerarAtributos();

    Console.WriteLine();
    ClasseFactory.ExibirClassesDisponiveis(atributos);
    int opcaoClasse = EntradaService.LerInteiro("Opção: ");

    ClassePersonagem classe;

    try
    {
        classe = ClasseFactory.CriarClasse(opcaoClasse);
    }
    catch (ArgumentException erro)
    {
        Console.WriteLine(erro.Message);
        EntradaService.AguardarEnter();
        return;
    }

    Personagem personagem = new(nome, atributos, classe);

    Console.Clear();
    personagem.ExibirFicha();

    string caminho = PersonagemArquivoService.Salvar(personagem);

    Console.WriteLine();
    Console.WriteLine("Personagem criado e salvo com sucesso.");
    Console.WriteLine($"Arquivo salvo em: {caminho}");
    Console.WriteLine();
    Console.WriteLine("Você será levado de volta ao menu inicial.");
    EntradaService.AguardarEnter();
}
