using System.Text;

namespace OldDragonPersonagens.Models;

public class Personagem
{
    public string Nome { get; set; }
    public Atributos Atributos { get; set; }
    public ClassePersonagem Classe { get; set; }
    public int PontosDeVida { get; set; }

    public Personagem(string nome, Atributos atributos, ClassePersonagem classe)
    {
        Nome = nome;
        Atributos = atributos;
        Classe = classe;
        PontosDeVida = classe.CalcularPontosDeVida(atributos);
    }

    public void ExibirFicha()
    {
        Console.WriteLine(GerarFichaTexto());
    }

    public string GerarFichaTexto()
    {
        StringBuilder ficha = new();

        ficha.AppendLine();
        ficha.AppendLine("========================================");
        ficha.AppendLine("          FICHA DO PERSONAGEM           ");
        ficha.AppendLine("========================================");
        ficha.AppendLine($"Nome: {Nome}");
        ficha.AppendLine($"Classe: {Classe.Nome}");
        ficha.AppendLine($"Pontos de vida: {PontosDeVida}");

        ficha.AppendLine();
        ficha.AppendLine("ATRIBUTOS");
        ficha.AppendLine(MontarLinhaAtributo("Força", Atributos.Forca, Atributos.ModificadorForca()));
        ficha.AppendLine(MontarLinhaAtributo("Destreza", Atributos.Destreza, Atributos.ModificadorDestreza()));
        ficha.AppendLine(MontarLinhaAtributo("Constituição", Atributos.Constituicao, Atributos.ModificadorConstituicao()));
        ficha.AppendLine(MontarLinhaAtributo("Inteligência", Atributos.Inteligencia, Atributos.ModificadorInteligencia()));
        ficha.AppendLine(MontarLinhaAtributo("Sabedoria", Atributos.Sabedoria, Atributos.ModificadorSabedoria()));
        ficha.AppendLine(MontarLinhaAtributo("Carisma", Atributos.Carisma, Atributos.ModificadorCarisma()));

        ficha.AppendLine();
        ficha.AppendLine("CARACTERÍSTICAS DA CLASSE");
        ficha.AppendLine($"Classe: {Classe.Nome}");
        ficha.AppendLine($"Descrição: {Classe.Descricao}");
        ficha.AppendLine($"PV inicial: {Classe.PvInicial}");
        ficha.AppendLine($"Dado de vida: {Classe.DadoDeVida}");
        ficha.AppendLine($"Atributo principal sugerido: {Classe.AtributoPrincipal}");
        ficha.AppendLine("Características:");

        foreach (string caracteristica in Classe.Caracteristicas)
        {
            ficha.AppendLine($"- {caracteristica}");
        }

        ficha.AppendLine("========================================");

        return ficha.ToString();
    }

    private static string MontarLinhaAtributo(string nome, int valor, int modificador)
    {
        string sinal = modificador >= 0 ? "+" : "";
        return $"{nome}: {valor} | Modificador: {sinal}{modificador}";
    }

}
