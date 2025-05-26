# Encriptador e Desencriptador

## Visão Geral

Esta aplicação Windows Forms em C# permite encriptar e desencriptar mensagens utilizando três cifras distintas: **Cifra de César**, **Código Morse** e **Tap Code**.

O objetivo é permitir que utilizadores escolham uma cifra, insiram texto e cifrem ou decifrem de acordo com a sua vontade. Também suporta leitura e escrita de ficheiros `.txt`.

---

## Funcionalidades

* Encriptação e desencriptação de texto com:

  * Cifra de César
  * Código Morse
  * Tap Code
* Preserva quebras de linha durante a cifragem/decifragem
* Interface intuitiva com Windows Forms
* Leitura de ficheiros `.txt` para input
* Escrita de ficheiros `.txt` com o output

![Cifras](/Resources/Cipher.png)
![César](/assets/images/Caesar.png)
![Conversão](/assets/images/Conv.png)

---

## Estrutura da Solução

```c#
Encriptador e Desencriptador/
│
├── Core/
│   ├── Cifras/
│   │   ├── Caesar.cs             // Implementação da cifra de César
│   │   ├── Morse.cs              // Implementação de Morse
│   │   └── Tap.cs                // Implementação do Tap Code
│   ├── FileHandlers/
│   │   ├── FileProcessor.cs      // Auxilia na gestão de ficheiros
│   │   └── FileRW.cs             // Leitura e escrita de ficheiros
│   ├── Interface/
│   │   └── ICipher.cs            // Interface comum a todas as cifras
│   └── Utils/
│       ├── TextUtils.cs          // Remove acentos e normaliza texto
│       └── Variables.cs          // Variáveis globais
│
├── Forms/
│   ├── CaesarShiftForm.cs        // Define deslocamento da Cifra de César
│   ├── CipherSelectionForm.cs    // Seleção da cifra desejada
│   ├── ConversionForm.cs         // Ecrã principal de conversão
│   ├── LayoutForm.cs             // Layout da aplicaçãom, que contém os outros (form pai)
│   └── MainMenuForm.cs           // Ecrã inicial com Iniciar/Sair
│
├── Resources/                    // Recursos como ícones ou imagens
├── Program.cs                    // Ponto de entrada
├── App.config                    // Configurações da aplicação
└── README.md                     // Documentação do projeto
```

---

## Fluxo de Navegação (Forms)

```c#
[LayoutForm]
   └➔ [MainForm]
         └➔ Clicar "Iniciar"
               └➔ [CipherSelectionForm]
                      └➔ Escolher cifra:
                             └➔ Se "César" ➔ [CaesarKeyForm] ➔ Definir deslocamento
                             └➔ Todas ➔ [ConversionForm]
                                    └➔ Inserir texto ou carregar ficheiro
                                    └➔ Encriptar / Desencriptar
                                    └➔ Salvar resultado
```

---

## Lógica da Aplicação

A aplicação segue uma arquitetura baseada em Forms, sendo que todos os formulários são controlados a partir de um LayoutForm principal. O utilizador escolhe a cifra desejada e insere texto manualmente ou por ficheiro, podendo depois encriptar ou desencriptar.

Cada cifra implementa a interface `ICipher`, garantindo que todas as operações de encriptação e desencriptação sigam o mesmo formato.

As quebras de linha são preservadas durante a conversão, utilizando separadores personalizados (ex: `//` no Morse). O resultado pode ser guardado num ficheiro `.txt`. Ainda existe a opção de copiar e colar texto no ecrã de conversão.

---

## Lógica das Cifras

- **Cifra de César:** Desloca cada letra do alfabeto um número fixo de posições. O deslocamento é configurável num form dedicado. Letras fora do alfabeto são ignoradas nas conversões e mantidas.
```c#
//Exemplo
Input: "gato"
Deslocamento: 3

Output: "jdwr"
```

- **Código Morse:** Converte letras para pontos e traços. São suportados os caractéres presentes na [Wikipédia](https://pt.wikipedia.org/wiki/C%C3%B3digo_Morse#Letras,_n%C3%BAmeros,_pontua%C3%A7%C3%B5es_e_sinais_especiais).
```c#
//Exemplo
Input:"gato
cão"

Output: "--. .- - --- // -.-. .- ---"
```

- **Tap Code:** Baseado numa grelha 5x5 de letras, onde as letras `C` e `K` ocupam o mesmo espaço. Cada letra é representada por uma coordenada `linha,coluna`. As linhas são separadas por `//`.
```c#
//Exemplo
Input:"gato"

Output: "2,2 1,1 4,4 3,4"
```
---

## Como correr a aplicação

---

## Como testar a aplicação

1. Executar a aplicação
2. Clicar em "Iniciar"
3. Escolher uma cifra
4. (Se escolher a cifra de César) Definir deslocamento
5. Inserir texto na textbox de entrada ou carregar ficheiro
6. Clicar em "Encriptar" ou "Desencriptar"
7. Ver resultado na textbox de saída
8. Guardar em ficheiro se desejar

---

## Requisitos

* .NET Framework 4.7+ (ou equivalente)
* Visual Studio 2019+ recomendado

---

## Licença

Projeto de caráter académico. Uso pessoal e educativo apenas.

---

## Sobre

Este projeto foi desenvolvido como trabalho académico no ensino secundário na disciplina de API. O interesse em tentar implementar algumas destas cifras fez com que este projeto nascesse e fosse apresentado como trabalho da disciplina, sendo o objetivo deste o desenvolvimento de aplicações gráficas com Windows Forms em C#.

---