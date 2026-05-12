namespace OldDragonPersonagens.Services;

public class DadoService
{
    private readonly Random _random = new();

    public int RolarD6()
    {
        return _random.Next(1, 7);
    }

    public int Rolar3D6()
    {
        return RolarD6() + RolarD6() + RolarD6();
    }

    public int Rolar4D6DescartandoMenor()
    {
        List<int> dados = new()
        {
            RolarD6(),
            RolarD6(),
            RolarD6(),
            RolarD6()
        };

        dados.Sort();

        // Depois do Sort, o menor valor fica na posição 0.
        // Somamos as posições 1, 2 e 3, descartando o menor dado.
        return dados[1] + dados[2] + dados[3];
    }
}
