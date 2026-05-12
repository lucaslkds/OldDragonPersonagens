namespace OldDragonPersonagens.Models;

public abstract class ClassePersonagem
{
    public abstract string Nome { get; }
    public abstract string Descricao { get; }
    public abstract int PvInicial { get; }
    public abstract string DadoDeVida { get; }
    public abstract string AtributoPrincipal { get; }
    public abstract List<string> Caracteristicas { get; }

    public virtual int CalcularPontosDeVida(Atributos atributos)
    {
        int pv = PvInicial + atributos.ModificadorConstituicao();

        if (pv < 1)
        {
            return 1;
        }

        return pv;
    }

    public virtual void ExibirCaracteristicas()
    {
        Console.WriteLine($"Classe: {Nome}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"PV inicial: {PvInicial}");
        Console.WriteLine($"Dado de vida: {DadoDeVida}");
        Console.WriteLine($"Atributo principal sugerido: {AtributoPrincipal}");
        Console.WriteLine("Características:");

        foreach (string caracteristica in Caracteristicas)
        {
            Console.WriteLine($"- {caracteristica}");
        }
    }
}
