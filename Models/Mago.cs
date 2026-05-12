namespace OldDragonPersonagens.Models;

public class Mago : ClassePersonagem
{
    public override string Nome => "Mago";
    public override string Descricao => "Conjurador arcano que utiliza estudo, grimórios e conhecimento mágico.";
    public override int PvInicial => 4;
    public override string DadoDeVida => "1d4";
    public override string AtributoPrincipal => "Inteligência";

    public override List<string> Caracteristicas => new()
    {
        "Classe voltada para magia arcana.",
        "Possui baixo PV inicial, mas grande potencial mágico.",
        "Indicado para personagens estudiosos e dependentes de magia."
    };
}
