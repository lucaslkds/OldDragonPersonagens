namespace OldDragonPersonagens.Models;

public class Atributos
{
    public int Forca { get; set; }
    public int Destreza { get; set; }
    public int Constituicao { get; set; }
    public int Inteligencia { get; set; }
    public int Sabedoria { get; set; }
    public int Carisma { get; set; }

    public int CalcularModificador(int valor)
    {
        if (valor <= 3) return -3;
        if (valor <= 5) return -2;
        if (valor <= 8) return -1;
        if (valor <= 12) return 0;
        if (valor <= 14) return 1;
        if (valor <= 16) return 2;
        if (valor <= 18) return 3;
        return 4;
    }

    public int ModificadorForca() => CalcularModificador(Forca);
    public int ModificadorDestreza() => CalcularModificador(Destreza);
    public int ModificadorConstituicao() => CalcularModificador(Constituicao);
    public int ModificadorInteligencia() => CalcularModificador(Inteligencia);
    public int ModificadorSabedoria() => CalcularModificador(Sabedoria);
    public int ModificadorCarisma() => CalcularModificador(Carisma);

    public void Exibir()
    {
        ExibirLinha("Força", Forca, ModificadorForca());
        ExibirLinha("Destreza", Destreza, ModificadorDestreza());
        ExibirLinha("Constituição", Constituicao, ModificadorConstituicao());
        ExibirLinha("Inteligência", Inteligencia, ModificadorInteligencia());
        ExibirLinha("Sabedoria", Sabedoria, ModificadorSabedoria());
        ExibirLinha("Carisma", Carisma, ModificadorCarisma());
    }

    private static void ExibirLinha(string nome, int valor, int modificador)
    {
        string sinal = modificador >= 0 ? "+" : "";
        Console.WriteLine($"{nome}: {valor} | Modificador: {sinal}{modificador}");
    }
}
