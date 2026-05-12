namespace OldDragonPersonagens.Models;

public class Druida : ClassePersonagem
{
    public override string Nome => "Druida";
    public override string Descricao => "Especialização ligada à natureza, animais, ermos e forças naturais.";
    public override int PvInicial => 8;
    public override string DadoDeVida => "1d8";
    public override string AtributoPrincipal => "Sabedoria";

    public override List<string> Caracteristicas => new()
    {
        "Especialização associada ao arquétipo do clérigo.",
        "Combina com personagens ligados à natureza.",
        "Descrição focada em ambiente selvagem e equilíbrio natural."
    };
}
