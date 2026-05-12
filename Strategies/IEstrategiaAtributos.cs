using OldDragonPersonagens.Models;

namespace OldDragonPersonagens.Strategies;

public interface IEstrategiaAtributos
{
    string Nome { get; }
    string Descricao { get; }
    Atributos GerarAtributos();

}
