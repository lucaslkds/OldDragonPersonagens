using OldDragonPersonagens.Models;
using OldDragonPersonagens.Services;

namespace OldDragonPersonagens.Strategies;

public class GeradorHeroico : IEstrategiaAtributos
{
    public string Nome => "Heroico";

    public string Descricao => "Rola 4d6, descarta o menor dado e permite distribuir os valores.";

    public Atributos GerarAtributos()
    {
        List<int> valores = new List<int>();

        for (int i = 0; i < 6; i++)
        {
            valores.Add(DadoService.Rolar4D6DescartandoMenor());
        }

        Console.WriteLine("\nValores gerados no modo Heroico:");
        Console.WriteLine(string.Join(", ", valores));

        return DistribuidorAtributosService.Distribuir(valores);
    }
}