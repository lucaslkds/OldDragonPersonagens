using OldDragonPersonagens.Models;

namespace OldDragonPersonagens.Services;

public static class PersonagemArquivoService
{
    private const string NomePasta = "PersonagensSalvos";

    public static string ObterPastaDePersonagens()
    {
        return Path.Combine(Directory.GetCurrentDirectory(), NomePasta);
    }

    public static string Salvar(Personagem personagem)
    {
        string pasta = ObterPastaDePersonagens();
        Directory.CreateDirectory(pasta);

        string nomeArquivo = MontarNomeArquivoSeguro(personagem.Nome);
        string caminhoCompleto = Path.Combine(pasta, nomeArquivo);

        File.WriteAllText(caminhoCompleto, personagem.GerarFichaTexto());

        return caminhoCompleto;
    }

    public static void EscolherPersonagemSalvo()
    {
        Console.Clear();
        List<FileInfo> arquivos = ListarPersonagensSalvos();

        if (arquivos.Count == 0)
        {
            Console.WriteLine("Nenhum personagem salvo foi encontrado.");
            Console.WriteLine($"Pasta pesquisada: {ObterPastaDePersonagens()}");
            EntradaService.AguardarEnter();
            return;
        }

        Console.WriteLine("=== PERSONAGENS SALVOS ===");
        Console.WriteLine();

        for (int i = 0; i < arquivos.Count; i++)
        {
            string nomeSemExtensao = Path.GetFileNameWithoutExtension(arquivos[i].Name);
            Console.WriteLine($"{i + 1} - {nomeSemExtensao}");
        }

        Console.WriteLine("0 - Voltar ao menu inicial");
        Console.WriteLine();

        int opcao = EntradaService.LerInteiro("Escolha o personagem salvo: ");

        if (opcao == 0)
        {
            return;
        }

        if (opcao < 1 || opcao > arquivos.Count)
        {
            Console.WriteLine("Opção inválida.");
            EntradaService.AguardarEnter();
            return;
        }

        FileInfo personagemEscolhido = arquivos[opcao - 1];
        EscolherAcaoDoPersonagem(personagemEscolhido);
    }

    private static void EscolherAcaoDoPersonagem(FileInfo arquivo)
    {
        while (true)
        {
            Console.Clear();
            string nomePersonagem = Path.GetFileNameWithoutExtension(arquivo.Name);

            Console.WriteLine($"Personagem selecionado: {nomePersonagem}");
            Console.WriteLine();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Usar / visualizar personagem");
            Console.WriteLine("2 - Excluir personagem");
            Console.WriteLine("0 - Voltar ao menu inicial");
            Console.WriteLine();

            int opcao = EntradaService.LerInteiro("Opção: ");

            switch (opcao)
            {
                case 1:
                    UsarPersonagem(arquivo);
                    return;

                case 2:
                    ExcluirPersonagem(arquivo);
                    return;

                case 0:
                    return;

                default:
                    Console.WriteLine("Opção inválida. Escolha 1, 2 ou 0.");
                    EntradaService.AguardarEnter();
                    break;
            }
        }
    }

    private static void UsarPersonagem(FileInfo arquivo)
    {
        Console.Clear();
        Console.WriteLine("=== PERSONAGEM ESCOLHIDO ===");
        Console.WriteLine();
        Console.WriteLine(File.ReadAllText(arquivo.FullName));
        EntradaService.AguardarEnter();
    }

    private static void ExcluirPersonagem(FileInfo arquivo)
    {
        Console.WriteLine();
        Console.WriteLine($"Tem certeza que deseja excluir '{Path.GetFileNameWithoutExtension(arquivo.Name)}'?");
        Console.WriteLine("1 - Sim, excluir");
        Console.WriteLine("2 - Não, voltar ao menu inicial");

        int confirmacao = EntradaService.LerInteiro("Opção: ");

        if (confirmacao == 1)
        {
            File.Delete(arquivo.FullName);
            Console.WriteLine("Personagem excluído com sucesso.");
        }
        else
        {
            Console.WriteLine("Exclusão cancelada.");
        }

        Console.WriteLine("Você será levado de volta ao menu inicial.");
        EntradaService.AguardarEnter();
    }

    private static List<FileInfo> ListarPersonagensSalvos()
    {
        string pasta = ObterPastaDePersonagens();

        if (!Directory.Exists(pasta))
        {
            return new List<FileInfo>();
        }

        return new DirectoryInfo(pasta)
            .GetFiles("*.txt")
            .OrderBy(arquivo => Path.GetFileNameWithoutExtension(arquivo.Name))
            .ToList();
    }

    private static string MontarNomeArquivoSeguro(string nomePersonagem)
    {
        string nomeLimpo = nomePersonagem.Trim();

        foreach (char caractereInvalido in Path.GetInvalidFileNameChars())
        {
            nomeLimpo = nomeLimpo.Replace(caractereInvalido, '_');
        }

        if (string.IsNullOrWhiteSpace(nomeLimpo))
        {
            nomeLimpo = "Personagem";
        }

        return $"{nomeLimpo}.txt";
    }
}
