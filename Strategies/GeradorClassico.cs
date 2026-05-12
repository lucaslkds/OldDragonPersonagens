using OldDragonPersonagens.Models;
using OldDragonPersonagens.Services;

namespace OldDragonPersonagens.Strategies;

public class GeradorClassico : IEstrategiaAtributos
{
    private readonly DadoService _dadoService = new();

    public string Nome => "Estilo Clássico";
    public string Descricao => "Rola 3d6 seis vezes e distribui em ordem: Força, Destreza, Constituição, Inteligência, Sabedoria e Carisma.";

    public Atributos GerarAtributos()
    {
        Atributos atributos = new()
        {
            Forca = _dadoService.Rolar3D6(),
            Destreza = _dadoService.Rolar3D6(),
            Constituicao = _dadoService.Rolar3D6(),
            Inteligencia = _dadoService.Rolar3D6(),
            Sabedoria = _dadoService.Rolar3D6(),
            Carisma = _dadoService.Rolar3D6()
        };

        Console.WriteLine("Distribuição do modo Clássico:");
        Console.WriteLine($"Força: {atributos.Forca}");
        Console.WriteLine($"Destreza: {atributos.Destreza}");
        Console.WriteLine($"Constituição: {atributos.Constituicao}");
        Console.WriteLine($"Inteligência: {atributos.Inteligencia}");
        Console.WriteLine($"Sabedoria: {atributos.Sabedoria}");
        Console.WriteLine($"Carisma: {atributos.Carisma}");

        return atributos;
    }
    
}
