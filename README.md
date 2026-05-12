# Criador de Personagens - Old Dragon

TargetFramework: `net10.0`

Projeto em C# para criação de personagens inspirado no processo de criação de personagens do sistema de RPG **Old Dragon**.

## Integrantes

Substitua pelos nomes da equipe:

- Integrante 1
- Integrante 2
- Integrante 3
- Integrante 4
- Integrante 5

## Requisitos implementados

- Criação de personagem com nome, atributos, classe e pontos de vida.
- Menu inicial em loop para criar personagem, escolher personagem salvo ou sair.
- Ao escolher personagem salvo, é possível selecionar um arquivo e decidir entre usar/visualizar ou excluir.
- Após excluir um personagem salvo, o programa volta ao menu inicial.
- Salvamento automático da ficha em arquivo `.txt` na pasta `PersonagensSalvos`.
- O arquivo salvo usa somente o nome do personagem, por exemplo `Arthos.txt`, sem data/hora ou números adicionais.
- Três formas de geração de atributos:
  - Clássico: rola 3d6 em ordem e mostra claramente qual valor foi para Força, Destreza, Constituição, Inteligência, Sabedoria e Carisma.
  - Aventureiro: rola 3d6 seis vezes e permite distribuir os valores.
  - Heroico: rola 4d6, descarta o menor dado e permite distribuir os valores.
- Cálculo dos modificadores de atributos.
- Classe abstrata `ClassePersonagem`.
- Classes específicas herdando de `ClassePersonagem`.
- Factory para limitar a criação apenas às classes existentes no menu.
- Cálculo dos pontos de vida com base no PV inicial da classe + modificador de Constituição.
- Tratamento para garantir mínimo de 1 ponto de vida.

## Fontes utilizadas

- SRD Old Dragon - Atributos: https://olddragon.com.br/livros/srd/capitulos/atributos
- SRD Old Dragon - Classes: https://olddragon.com.br/livros/srd/capitulos/classe
- SRD Old Dragon - Personagem: https://olddragon.com.br/livros/srd/capitulos/personagem

## Padrões e conceitos usados

### Orientação a Objetos

- `Personagem` representa a ficha completa.
- `Atributos` representa os valores de Força, Destreza, Constituição, Inteligência, Sabedoria e Carisma.
- `ClassePersonagem` representa uma classe abstrata base.
- `Guerreiro`, `Mago`, `Clerigo`, `Ladrao` e demais classes herdam de `ClassePersonagem`.

### Herança

As classes específicas, como `Guerreiro`, `Mago`, `Clerigo` e `Ladrao`, herdam de `ClassePersonagem`.

### Polimorfismo

O programa trabalha com o tipo abstrato `ClassePersonagem`, mas em tempo de execução pode receber um objeto `Guerreiro`, `Mago`, `Clerigo`, `Ladrao` etc.

### Strategy

As formas de geração de atributos implementam a interface `IEstrategiaAtributos`:

- `GeradorClassico`
- `GeradorAventureiro`
- `GeradorHeroico`

### Factory

A classe `ClasseFactory` cria apenas classes válidas a partir de um número escolhido no menu.

A classe `EstrategiaAtributosFactory` cria apenas métodos válidos de geração de atributos.

## Como executar

No terminal, dentro da pasta do projeto:

```bash
dotnet run
```

## Estrutura do projeto

```text
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
```
