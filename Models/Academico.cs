namespace OldDragonPersonagens.Models;

public class Academico : ClassePersonagem
{
    public override string Nome => "Acadêmico";
    public override string Descricao => "Especialização ligada ao estudo, conhecimento, interpretação e pesquisa.";
    public override int PvInicial => 8;
    public override string DadoDeVida => "1d8";
    public override string AtributoPrincipal => "Sabedoria";

    public override List<string> Caracteristicas => new()
    {
        "Especialização associada ao arquétipo do clérigo.",
        "Combina com personagens estudiosos e analíticos.",
        "Descrição focada em conhecimento e investigação."
    };
}
