using OldDragonPersonagens.Models;

namespace OldDragonPersonagens.Factories;

public static class ClasseFactory
{
    public static void ExibirClassesDisponiveis(Atributos atributos)
    {
        Console.WriteLine("Antes de escolher a classe, veja os atributos gerados e seus modificadores:");
        Console.WriteLine();
        atributos.Exibir();
        Console.WriteLine();

        Console.WriteLine("Escolha a classe do personagem:");
        Console.WriteLine("Cada opção mostra um mini resumo, o PV inicial, o dado de vida e o modificador do atributo principal.");
        Console.WriteLine();

        ExibirOpcao(1, new Guerreiro(), atributos);
        ExibirOpcao(2, new Barbaro(), atributos);
        ExibirOpcao(3, new Paladino(), atributos);
        ExibirOpcao(4, new Clerigo(), atributos);
        ExibirOpcao(5, new Academico(), atributos);
        ExibirOpcao(6, new Druida(), atributos);
        ExibirOpcao(7, new Ladrao(), atributos);
        ExibirOpcao(8, new Bardo(), atributos);
        ExibirOpcao(9, new Ranger(), atributos);
        ExibirOpcao(10, new Mago(), atributos);
        ExibirOpcao(11, new Ilusionista(), atributos);
        ExibirOpcao(12, new Necromante(), atributos);
    }

    public static void ExibirClassesDisponiveis()
    {
        Console.WriteLine("Escolha a classe do personagem:");
        Console.WriteLine("1  - Guerreiro");
        Console.WriteLine("2  - Bárbaro");
        Console.WriteLine("3  - Paladino");
        Console.WriteLine("4  - Clérigo");
        Console.WriteLine("5  - Acadêmico");
        Console.WriteLine("6  - Druida");
        Console.WriteLine("7  - Ladrão");
        Console.WriteLine("8  - Bardo");
        Console.WriteLine("9  - Ranger");
        Console.WriteLine("10 - Mago");
        Console.WriteLine("11 - Ilusionista");
        Console.WriteLine("12 - Necromante");
    }

    public static ClassePersonagem CriarClasse(int opcao)
    {
        return opcao switch
        {
            1 => new Guerreiro(),
            2 => new Barbaro(),
            3 => new Paladino(),
            4 => new Clerigo(),
            5 => new Academico(),
            6 => new Druida(),
            7 => new Ladrao(),
            8 => new Bardo(),
            9 => new Ranger(),
            10 => new Mago(),
            11 => new Ilusionista(),
            12 => new Necromante(),
            _ => throw new ArgumentException("Opção inválida. Escolha uma classe existente no menu.")
        };
    }

    private static void ExibirOpcao(int numero, ClassePersonagem classe, Atributos atributos)
    {
        int modificadorAtributoPrincipal = ObterModificadorAtributoPrincipal(classe, atributos);
        string sinal = modificadorAtributoPrincipal >= 0 ? "+" : "";

        Console.WriteLine($"{numero,2} - {classe.Nome}");
        Console.WriteLine($"     Resumo: {classe.Descricao}");
        Console.WriteLine($"     PV inicial: {classe.PvInicial} | Dado de vida: {classe.DadoDeVida}");
        Console.WriteLine($"     Atributo principal sugerido: {classe.AtributoPrincipal} | Modificador do atributo principal: {sinal}{modificadorAtributoPrincipal}");
        Console.WriteLine();
    }

    private static int ObterModificadorAtributoPrincipal(ClassePersonagem classe, Atributos atributos)
    {
        return classe.AtributoPrincipal.ToLower() switch
        {
            "força" or "forca" => atributos.ModificadorForca(),
            "destreza" => atributos.ModificadorDestreza(),
            "constituição" or "constituicao" => atributos.ModificadorConstituicao(),
            "inteligência" or "inteligencia" => atributos.ModificadorInteligencia(),
            "sabedoria" => atributos.ModificadorSabedoria(),
            "carisma" => atributos.ModificadorCarisma(),
            _ => 0
        };
    }
}
