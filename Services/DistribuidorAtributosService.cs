using OldDragonPersonagens.Models;

namespace OldDragonPersonagens.Services;

public static class DistribuidorAtributosService
{
    public static Atributos Distribuir(List<int> valores)
    {
        Atributos atributos = new Atributos();

        Console.WriteLine("\nDistribua os valores entre os atributos.");

        atributos.Forca = EscolherValor("Força", valores);
        atributos.Destreza = EscolherValor("Destreza", valores);
        atributos.Constituicao = EscolherValor("Constituição", valores);
        atributos.Inteligencia = EscolherValor("Inteligência", valores);
        atributos.Sabedoria = EscolherValor("Sabedoria", valores);
        atributos.Carisma = EscolherValor("Carisma", valores);

        return atributos;
    }

    private static int EscolherValor(string nomeAtributo, List<int> valores)
    {
        while (true)
        {
            Console.WriteLine($"\nValores disponíveis: {string.Join(", ", valores)}");
            Console.Write($"Escolha o valor para {nomeAtributo}: ");

            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int valorEscolhido))
            {
                Console.WriteLine("Valor inválido. Digite um número.");
                continue;
            }

            if (!valores.Contains(valorEscolhido))
            {
                Console.WriteLine("Esse valor não está disponível ou já foi usado.");
                continue;
            }

            valores.Remove(valorEscolhido);
            return valorEscolhido;
        }
    }
}