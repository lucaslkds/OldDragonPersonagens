namespace OldDragonPersonagens.Models;

public class Barbaro : ClassePersonagem
{
    public override string Nome => "Bárbaro";
    public override string Descricao => "Especialização ligada à força bruta, instinto, vigor e sobrevivência em ambientes hostis.";
    public override int PvInicial => 10;
    public override string DadoDeVida => "1d10";
    public override string AtributoPrincipal => "Força";

    public override List<string> Caracteristicas => new()
    {
        "Especialização associada ao arquétipo do guerreiro.",
        "Combina com personagens resistentes e agressivos.",
        "Descrição focada em vigor físico e sobrevivência."
    };
}
