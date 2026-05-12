namespace OldDragonPersonagens.Services;

public static class EntradaService
{
    public static int LerInteiro(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int valor))
            {
                return valor;
            }

            Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        }
    }

    public static string LerTextoObrigatorio(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            string? entrada = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(entrada))
            {
                return entrada.Trim();
            }

            Console.WriteLine("Entrada inválida. O texto não pode ser vazio.");
        }
    }

    public static int EscolherValorDaLista(List<int> valores, string nomeAtributo)
    {
        while (true)
        {
            Console.WriteLine($"Valores disponíveis: {string.Join(", ", valores)}");
            int escolhido = LerInteiro($"Escolha o valor para {nomeAtributo}: ");

            if (valores.Contains(escolhido))
            {
                valores.Remove(escolhido);
                return escolhido;
            }

            Console.WriteLine("Valor inválido. Escolha um dos valores disponíveis.");
        }
    }

    public static void AguardarEnter(string mensagem = "Pressione ENTER para voltar ao menu inicial...")
    {
        Console.WriteLine();
        Console.Write(mensagem);
        Console.ReadLine();
    }
}
