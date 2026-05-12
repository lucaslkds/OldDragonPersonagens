using OldDragonPersonagens.Strategies;

namespace OldDragonPersonagens.Factories;

public static class EstrategiaAtributosFactory
{
    public static void ExibirMetodosDisponiveis()
    {
        Console.WriteLine("Escolha a forma de geração dos atributos:");
        Console.WriteLine("1 - Clássico: 3d6 em ordem");
        Console.WriteLine("2 - Aventureiro: 3d6 seis vezes e distribui como quiser");
        Console.WriteLine("3 - Heroico: 4d6 descartando o menor e distribui como quiser");
    }

    public static IEstrategiaAtributos CriarEstrategia(int opcao)
    {
        return opcao switch
        {
            1 => new GeradorClassico(),
            2 => new GeradorAventureiro(),
            3 => new GeradorHeroico(),
            _ => throw new ArgumentException("Opção inválida. Escolha um método existente no menu.")
        };
    }
}
