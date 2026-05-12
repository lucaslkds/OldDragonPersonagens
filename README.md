# Criador de Personagens - Old Dragon

Framework net10.0

Projeto em C# para criação de personagens inspirado no processo de criação de personagens do sistema de RPG **Old Dragon**.

## Integrantes

- Lucas Kauan Santos
- Alessandro dos Santos Cardoso

## Estrutura do projeto

OldDragonPersonagens/
├── Program.cs
├── OldDragonPersonagens.csproj
├── Models/
│   ├── Personagem.cs
│   ├── Atributos.cs
│   ├── ClassePersonagem.cs
│   ├── Guerreiro.cs
│   ├── Barbaro.cs
│   ├── Paladino.cs
│   ├── Clerigo.cs
│   ├── Academico.cs
│   ├── Druida.cs
│   ├── Ladrao.cs
│   ├── Bardo.cs
│   ├── Ranger.cs
│   ├── Mago.cs
│   ├── Ilusionista.cs
│   └── Necromante.cs
├── Services/
│   ├── DadoService.cs
│   ├── EntradaService.cs
│   └── PersonagemArquivoService.cs
├── Strategies/
│   ├── IEstrategiaAtributos.cs
│   ├── GeradorClassico.cs
│   ├── GeradorAventureiro.cs
│   └── GeradorHeroico.cs
├── Factories/
│   ├── ClasseFactory.cs
│   └── EstrategiaAtributosFactory.cs
└── Docs/
    └── DiagramaDoProjeto.md
