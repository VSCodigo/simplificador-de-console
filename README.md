# Simplificador de Console 🚀

[![License: GPL v3](https://shields.io)](https://gnu.org)
![.NET Version](https://shields.io)

O **Simplificador de Console** é uma biblioteca utilitária (Class Library) desenvolvida em C# para abstrair, estender e otimizar os recursos nativos de manipulação de dados e fluxos no console do .NET. 

O projeto nasceu focado em melhorar a **DX (Developer Experience)**, trazendo inteligência para a captura de dados enquanto replica facilidades de linguagens de script como o `input()` do Python.

---

## 🛠️ Funcionalidades Principais

* **Receptor de Entrada Alternativo (`Recebedor`):** Captura entradas do usuário e valida se a entrada tem o tipo de dado requisitado (dispensando do fluxo principal o uso do `ReadLine`).
* **Gerenciamento Dinâmico de Linha:** Capacidade de zerar e limpar a linha atual do console de forma segura, adaptando-se automaticamente à largura da janela (`Console.WindowWidth`).
* **Empacotamento Modular:** Estrutura preparada para distribuição via pacotes locais do NuGet (`.nupkg`), garantindo versionamento semântico (`SemVer`).

---

## 📦 Estrutura da Solução (Monorepo)

A solução está organizada de forma modular debaixo do mesmo teto, seguindo boas práticas de arquitetura reutilizável:

```text
📂 SimplificadorDeConsole
│
├── 📦 AmbienteDeTeste (Aplicativo de Console / Ambiente de Validação)
│   ├── 📄 Program.cs (Cenários de teste e demonstração das funções)
│   └── 📄 AmbienteDeTeste.csproj
|
├── 📦 RecebedoresDeEntrada (Biblioteca de Classes / O pacote NuGet)
│   ├── 📄 Recebedor.cs (Lógica de captura e manipulação do console)
│   └── 📄 RecebedoresDeEntrada.csproj
│
└── 📄 SimplificadorDeConsole.sln (Arquivo de Solução que unifica os projetos)
```

---

## 🚀 Como Executar o Projeto

Você pode utilizar este projeto de duas formas: testando a solução completa ou instalando o pacote gerado.

### Pré-requisitos
* [.NET SDK 8.0](https://microsoft.com) ou superior.
* IDE de sua preferência (Visual Studio 2022 ou VS Code).

### Opção A: Rodando a Solução Completa (Para Desenvolvimento/Testes)
Se você deseja baixar o código-fonte para analisar a implementação ou rodar o projeto de testes de console:

1. Clone o repositório e abra o arquivo `SimplificadorDeConsole.sln` no Visual Studio.
2. Defina o projeto `AmbienteDeTeste` como projeto de inicialização.
3. Aperte `F5` para rodar o ambiente de demonstração no terminal.

### Opção B: Instalação via Pacote NuGet (Para uso em outros projetos)
Se você deseja apenas consumir as ferramentas desta biblioteca em um novo sistema (.NET), instale o pacote oficial diretamente do repositório público do NuGet:

1. Abra o seu projeto de destino no Visual Studio.
2. Acesse o menu **Tools** > **NuGet Package Manager** > **Package Manager Console**.
3. Execute o comando de instalação:
   ```bash
   Install-Package VSCodigo.Utilitarios
   ```
*Nota: Você também pode buscar por `VSCodigo.Utilitarios` utilizando a interface gráfica do NuGet Package Manager clicando com o botão direito em seu projeto e selecionando "Manage NuGet Packages...".*
---

## 💻 Exemplo de Código

Veja como é simples utilizar o receptor de entrada para capturar dados e limpar a linha após o fluxo:

```csharp
using VSCodigo.Utilitarios;

// Exemplo de chamada simples do componente receptor
string dados = Recebedor.CapturarEntrada("Digite o comando: ");

// A biblioteca gerencia o cursor de volta à posição correta,
// limpa a linha antiga usando a largura da janela e segue o fluxo limpo.
```

---

## ⚖️ Licença

Este projeto está licenciado sob a **GNU General Public License v3.0 (GPL-3.0)**. Isso significa que este código é livre para uso, modificação e distribuição, desde que qualquer projeto derivado também mantenha seu código aberto sob a mesma licença. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

## 🧑‍💻 Autor

Desenvolvido por **Vinícius da S. Jordão** (VSCodigo).
<br>Conecte-se comigo através das minhas redes profissionais:

* **GitHub:** [@VSCodigo](https://github.com/vscodigo)
* **LinkedIn:** [://linkedin.com](https://://linkedin.com)
