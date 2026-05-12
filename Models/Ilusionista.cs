namespace OldDragonPersonagens.Models;

public class Ilusionista : ClassePersonagem
{
    public override string Nome => "Ilusionista";
    public override string Descricao => "Especialização ligada a ilusões, truques arcanos, engano e manipulação sensorial.";
    public override int PvInicial => 4;
    public override string DadoDeVida => "1d4";
    public override string AtributoPrincipal => "Inteligência";

    public override List<string> Caracteristicas => new()
    {
        "Especialização associada ao arquétipo do mago.",
        "Combina com personagens astutos e criativos.",
        "Descrição focada em ilusões e manipulação da percepção."
    };
}
