namespace OldDragonPersonagens.Models;

public class Paladino : ClassePersonagem
{
    public override string Nome => "Paladino";
    public override string Descricao => "Especialização ligada à honra, dever, proteção e combate contra forças malignas.";
    public override int PvInicial => 10;
    public override string DadoDeVida => "1d10";
    public override string AtributoPrincipal => "Força";

    public override List<string> Caracteristicas => new()
    {
        "Especialização associada ao arquétipo do guerreiro.",
        "Combina combate físico com temática sagrada.",
        "Descrição focada em honra, proteção e dever."
    };
}
