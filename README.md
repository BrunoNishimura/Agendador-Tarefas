<h1 align="center"> 
	:date: Agenda de Tarefas com .NET CORE MVC :date:
</h1>

<p align="center">	  
  <img alt="Repository size" src="https://img.shields.io/github/repo-size/BrunoNishimura/Agendador-Tarefas">
  
  <a href="https://github.com/BrunoNishimura/Agendador-Tarefas/commits/master">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/BrunoNishimura/Agendador-Tarefas">
  </a>

  <img alt="License" src="https://img.shields.io/badge/license-MIT-brightgreen">   
</p>

<p align="center">
  <a href="#-projeto">Projeto</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#rocket-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#information_source-como-usar">Como usar</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-license">License</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="https://www.youtube.com/watch?v=-qEFiPfeBq8&list=PLTESsx8-vfPkhuSMZ9AeM3R9xNeBoqMBa">
    Playlist
  </a>
</p>

## 💻 Projeto

Criação de um agendador de tarefas com .NET CORE MVC.

### Tópicos

<details open>
  <summary><b>Aula 1: </b>Configuração Ambiente e Criação da Model - :heavy_check_mark:</summary>
  
   - [x] Criação do Projeto no Visual Studio: ASP.NET Core Web Application (MVC);
   - [x] Criação da primeira Model: Com o botão direito, adicionar novo item (Tarefa.cs);
   - [x]  Criação dos Campos da Tarefa: TarefaId; Nome; Data; Horario;
   - [x] Criação dos DataAnnotations: Personalização e Regras dos dados/campos;
</details>

<details>
  <summary><b>Aula 2: </b>Instalação de Libs, Criação do Contexto e Criação do Banco de Dados. - :heavy_check_mark:</summary>
  
  - [x] Instalação de 4 Bibliotecas 'Microsoft.EntityFrameworkCore' através do 'Manage NuGet Packages' , observar no arquivo AgendaTarefas.csproj;
  - [x] Configuração do ConnectionString no arquivo appsettings.json;
  - [x] Criação e configuração do Startup.cs;
  - [x] Configuração do Program.cs para adaptação do Startup.cs;
  - [x] Criando uma Migrations e nomeando ele através do 'Package Manager Console', com o comando:</br>
  `add-migrations criacaoBD`
  - [x] Criando um banco de dados através do 'Package Manager Console', com o comando:</br>
  `update-database`
  - [x] Checar e Visualizar o Banco criado em: 'SQL Server Object Explorer';
</details>

<details>
  <summary><b>Aula 3: </b>Criação de uma Model e do seu Controller - :heavy_check_mark:</summary>
  
   - [x] Criação do arquivo DatasViewModel.cs para nos auxiliar na manipulação das Datas;
     - Datas
     - Identificadores
   - [x] Criação do arquivo TarefasController.cs com Lógica e o Algoritmos necessários;
</details>

<details>
  <summary><b>Aula 4: </b>Criação da View, os primeiros componentes da tela - :heavy_check_mark:</summary>
  
   - [x] Foi criado dentro da Pasta View utilizando o Add Razor View:
     - View name: Index;
     - Template: List;
     - Model class: Tarefa (Agenda.Tarefas.Models);
     - Data context class: Contexto (AgendaTarefas.Models);
     - Options: Somente o 'Use a layout page';
   - [x] Refatoração do Accordion do Bootstrap v4 para o Bootstrap v5;
   - [x] Fix DateTime.Now (linha 37), arquivo TarefasController.cs;
</details>

<details>
  <summary><b>Aula 5: </b>Criação da ViewComponent - :heavy_check_mark:</summary>
  
   - [x] Foi criado a Pasta ViewComponents:
     - Dentro desta pasta foi criada uma class que herdar o ViewComponent;
   - [x] Dentro da Pasta Shared foi criado um novo diretório Components e dentro o diretório com ListaTarefas;
     - Dentro da Pasta ListaTarefas criada, foi adiciona uma nova View(Default.cshtml), utilizando o Add Razor View - Empty;
     - Foi criado o design deste componente;
   - [x] Foi adicionado uma font nova no projeto através do font-awesome cdn:
     - Link adicionado em Shared > _Layout.cshtml
</details>

<details>
  <summary><b>Aula 6: </b>Criação de uma Tarefa - :heavy_check_mark:</summary>
  
   - [x] Foi realizado o algoritmo e a lógica para CriarTarefa no arquivo 'TarefasController.cs'
     - Utilizando os [HttpGet] e o [HttpPost];
</details>

<details>
  <summary><b>Aula 7: </b>Criação e Customização de uma View para Criação de Tarefas - :heavy_check_mark:</summary>
  
   - [x] Foi criado uma View para a lógica de Criação de Tarefas realizado na Aula 6
     - View > CriarTarefa.cshtml;
</details>

<details>
  <summary><b>Aula 8: </b>Atualizando uma Tarefa - :heavy_check_mark:</summary>
  
   - [x] Foi realizado o algoritmo e a lógica para AtualizarTarefa no arquivo 'TarefasController.cs'
     - Utilizando os [HttpGet] e o [HttpPost];
</details>

<details>
  <summary><b>Aula 9: </b>Criação de uma View para a tela de Atualizar Tarefas - :heavy_check_mark:</summary>
  
   - [x] Foi criado a tela para a atualização da tarefa no arquivo 'AtualizarTarefa.cshtml';
</details>

<details>
  <summary><b>Aula 10: </b>Exclusão de tarefas - :heavy_check_mark:</summary>
  
   - [x] Foi criado a lógica e o algoritmo para exclusão das tarefas selecionadas;
   - [x] Foi criado uma modal através do bootstrap v5;
   - [x] Arquivos alterados:
   - View:
      - Tarefas
        - Index.cshtml
  - Shared:
      - Default.cshtml
  - Controllers:
      - TarefasController
</details>

## :rocket: Tecnologias

Este projeto foi desenvolvido com as seguintes tecnologias:

- [C#][csharp]


## :information_source: Como usar

Para clonar e executar esta aplicação, será necessário ter instalado em seu computador o [Git](https://git-scm.com) e o [Visual Studio][visual-studio].

Utilizar o BASH para executar o Git a partir da linha de comando:

### Install

```bash
# Clone this repository
$ git clone https://github.com/BrunoNishimura/Agendador-Tarefas
```

## :memo: License

This project is under the MIT license. See the [LICENSE](https://github.com/DanielObara/NLW-1.0/blob/master/LICENSE) for details.

[csharp]: https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/
[visual-studio]: https://visualstudio.microsoft.com/pt-br/
