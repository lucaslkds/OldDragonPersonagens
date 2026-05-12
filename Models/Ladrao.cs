namespace OldDragonPersonagens.Models;

public class Ladrao : ClassePersonagem
{
    public override string Nome => "Ladrão";
    public override string Descricao => "Especialista em furtividade, exploração, armadilhas e ações precisas.";
    public override int PvInicial => 6;
    public override string DadoDeVida => "1d6";
    public override string AtributoPrincipal => "Destreza";

    public override List<string> Caracteristicas => new()
    {
        "Classe voltada para agilidade e exploração.",
        "Combina com personagens furtivos e habilidosos.",
        "Indicado para lidar com perigos de masmorras, armadilhas e infiltração."
    };
}
