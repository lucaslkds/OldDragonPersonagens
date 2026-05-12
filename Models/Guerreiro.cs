namespace OldDragonPersonagens.Models;

public class Guerreiro : ClassePersonagem
{
    public override string Nome => "Guerreiro";
    public override string Descricao => "Combatente especializado no uso de armas, armaduras e combate físico.";
    public override int PvInicial => 10;
    public override string DadoDeVida => "1d10";
    public override string AtributoPrincipal => "Força";

    public override List<string> Caracteristicas => new()
    {
        "Classe voltada para combate direto.",
        "Boa resistência por possuir maior PV inicial.",
        "Indicado para personagens focados em armas e armaduras."
    };
}
