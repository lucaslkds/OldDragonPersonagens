# Diagrama intuitivo do projeto

```text
Usuário
  |
  | escolhe entre criar novo personagem, abrir salvo ou sair
  |
  | se escolher criar novo:
  | informa nome
  | escolhe método de atributos
  | escolhe classe do personagem
  v
Program.cs
  |
  | usa
  v
EstrategiaAtributosFactory
  |
  | cria uma Strategy
  v
IEstrategiaAtributos
  |---------------------------|
  |                           |
  v                           v
GeradorClassico        GeradorAventureiro        GeradorHeroico
  |                     |                         |
  | usa                 | usa                     | usa
  v                     v                         v
DadoService            DadoService                DadoService
  |                     |                         |
  | gera valores        | gera valores            | gera valores
  |                     |                         |
  |---------------------|-------------------------|
                        v
                    Atributos
                        |
                        | possui
                        v
        Força, Destreza, Constituição,
        Inteligência, Sabedoria e Carisma

Program.cs
  |
  | usa
  v
ClasseFactory
  |
  | cria apenas classes existentes
  v
ClassePersonagem [abstract]
  |
  | herança
  |---------------------------------------------------------------|
  |          |          |          |          |                  |
  v          v          v          v          v                  v
Guerreiro  Clérigo    Ladrão     Mago      Bárbaro ...      Necromante

Atributos + ClassePersonagem + Nome
  |
  v
Personagem
  |
  | calcula PV usando:
  | PV inicial da classe + modificador de Constituição
  v
Ficha final exibida no console
  |
  v
PersonagemArquivoService
  |
  | salva a ficha em .txt na pasta PersonagensSalvos
  | com o nome do personagem, sem data/hora no arquivo
  v
Arquivo do personagem

Usuário escolhe personagem salvo
  |
  v
PersonagemArquivoService
  |
  | lista arquivos salvos
  | permite selecionar um personagem
  | oferece opções: usar/visualizar ou excluir
  v
Volta ao menu inicial
```

## Relações principais

```text
Personagem TEM Atributos.
Personagem TEM uma ClassePersonagem.
Guerreiro É uma ClassePersonagem.
Mago É uma ClassePersonagem.
Clérigo É uma ClassePersonagem.
Ladrão É uma ClassePersonagem.
GeradorClassico É uma IEstrategiaAtributos.
GeradorAventureiro É uma IEstrategiaAtributos.
GeradorHeroico É uma IEstrategiaAtributos.
ClasseFactory CONTROLA quais classes podem ser criadas.
```

## Por que a Factory existe?

A `ClasseFactory` impede que o usuário crie uma classe inexistente.

Exemplo: se o usuário digitar uma opção que não existe, como `99`, o sistema mostra erro.

Ela só cria classes cadastradas no menu:

```text
1  - Guerreiro
2  - Bárbaro
3  - Paladino
4  - Clérigo
5  - Acadêmico
6  - Druida
7  - Ladrão
8  - Bardo
9  - Ranger
10 - Mago
11 - Ilusionista
12 - Necromante
```

## Alterações recentes

```text
- O menu inicial agora fica em loop até o usuário escolher sair.
- Ao criar e salvar um personagem, o programa volta ao menu inicial.
- Arquivos de personagens são salvos apenas com o nome do personagem, por exemplo: Arthos.txt.
- A opção de personagens salvos permite selecionar um personagem e escolher entre usar/visualizar ou excluir.
- Ao excluir um personagem, o programa volta ao menu inicial.
- O modo Clássico mostra na tela a distribuição na ordem: Força, Destreza, Constituição, Inteligência, Sabedoria e Carisma.
```
