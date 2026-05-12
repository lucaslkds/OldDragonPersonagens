using OldDragonPersonagens.Models;
using OldDragonPersonagens.Services;

namespace OldDragonPersonagens.Strategies;

public class GeradorAventureiro : IEstrategiaAtributos
{
    public string Nome => "Aventureiro";

    public string Descricao => "Rola 3d6 seis vezes e permite distribuir os valores.";

    public Atributos GerarAtributos()
    {
        List<int> valores = new List<int>();

        for (int i = 0; i < 6; i++)
        {
            valores.Add(DadoService.Rolar3D6());
        }

        Console.WriteLine("\nValores gerados no modo Aventureiro:");
        Console.WriteLine(string.Join(", ", valores));

        return DistribuidorAtributosService.Distribuir(valores);
    }
}