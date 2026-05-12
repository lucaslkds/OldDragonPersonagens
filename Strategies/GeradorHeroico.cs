using OldDragonPersonagens.Models;
using OldDragonPersonagens.Services;

namespace OldDragonPersonagens.Strategies;

public class GeradorHeroico : IEstrategiaAtributos
{
    private readonly DadoService _dadoService = new();

    public string Nome => "Estilo Heroico";
    public string Descricao => "Rola 4d6, descarta o menor dado, soma os outros três e permite distribuir os valores livremente.";

    public Atributos GerarAtributos()
    {
        List<int> valores = new();

        for (int i = 0; i < 6; i++)
        {
            valores.Add(_dadoService.Rolar4D6DescartandoMenor());
        }

        Console.WriteLine();
        Console.WriteLine("Distribua os valores gerados entre os atributos.");

        return DistribuirManualmente(valores);
    }

    private static Atributos DistribuirManualmente(List<int> valores)
    {
        return new Atributos
        {
            Forca = EntradaService.EscolherValorDaLista(valores, "Força"),
            Destreza = EntradaService.EscolherValorDaLista(valores, "Destreza"),
            Constituicao = EntradaService.EscolherValorDaLista(valores, "Constituição"),
            Inteligencia = EntradaService.EscolherValorDaLista(valores, "Inteligência"),
            Sabedoria = EntradaService.EscolherValorDaLista(valores, "Sabedoria"),
            Carisma = EntradaService.EscolherValorDaLista(valores, "Carisma")
        };
    }
}
