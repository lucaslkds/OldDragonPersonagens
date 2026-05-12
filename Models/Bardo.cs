namespace OldDragonPersonagens.Models;

public class Bardo : ClassePersonagem
{
    public override string Nome => "Bardo";
    public override string Descricao => "Especialização ligada às artes, performance, cultura, influência social e conhecimento popular.";
    public override int PvInicial => 6;
    public override string DadoDeVida => "1d6";
    public override string AtributoPrincipal => "Carisma";

    public override List<string> Caracteristicas => new()
    {
        "Especialização associada ao arquétipo do ladrão.",
        "Combina com personagens comunicativos e criativos.",
        "Descrição focada em arte, influência e presença social."
    };
}
