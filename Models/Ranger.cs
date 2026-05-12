namespace OldDragonPersonagens.Models;

public class Ranger : ClassePersonagem
{
    public override string Nome => "Ranger";
    public override string Descricao => "Especialização ligada a rastreamento, sobrevivência, exploração e vida nos ermos.";
    public override int PvInicial => 6;
    public override string DadoDeVida => "1d6";
    public override string AtributoPrincipal => "Destreza";

    public override List<string> Caracteristicas => new()
    {
        "Especialização associada ao arquétipo do ladrão.",
        "Combina com personagens exploradores e rastreadores.",
        "Descrição focada em sobrevivência e deslocamento em ambientes selvagens."
    };
}
