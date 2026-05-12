namespace OldDragonPersonagens.Models;

public class Necromante : ClassePersonagem
{
    public override string Nome => "Necromante";
    public override string Descricao => "Especialização ligada à morte, energia sombria, espíritos e necromancia.";
    public override int PvInicial => 4;
    public override string DadoDeVida => "1d4";
    public override string AtributoPrincipal => "Inteligência";

    public override List<string> Caracteristicas => new()
    {
        "Especialização associada ao arquétipo do mago.",
        "Combina com personagens ligados a temas sombrios e ocultos.",
        "Descrição focada em morte, energia negativa e mistérios arcanos."
    };
}
