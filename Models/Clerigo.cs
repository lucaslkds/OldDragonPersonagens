namespace OldDragonPersonagens.Models;

public class Clerigo : ClassePersonagem
{
    public override string Nome => "Clérigo";
    public override string Descricao => "Personagem ligado à fé, proteção, cura e poderes divinos.";
    public override int PvInicial => 8;
    public override string DadoDeVida => "1d8";
    public override string AtributoPrincipal => "Sabedoria";

    public override List<string> Caracteristicas => new()
    {
        "Classe voltada para poderes divinos e suporte.",
        "Possui boa resistência quando comparada a classes mais frágeis.",
        "Indicado para personagens ligados à religião, templos ou divindades."
    };
}
