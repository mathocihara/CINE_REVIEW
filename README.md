# Cine Review


Cine Review é uma API GraphQL inspirado nos sites e fóruns voltados para o mercado de Cinema, para você que é um cinéfolo de carteirinha, poder gravar suas próprias críticas e informações gerais de um filme específico. Sem precisar se preocupar com o armazenamento cheio!!

----------

### Como iniciar a API:  💻

1.  Clonar repositório  [https://github.com/mathocihara/API_CINEMA](https://github.com/carolsaint/cineDev.git)
2.  Instalar os pacotes necessários utilizando a plataforma de gerenciamento Nuget ou o Console Nuget;

3. Fazer a sua conexão com o SQLServer e ajustar a string de conexão no  arquivo "Program.cs"

4. Clicar no "Gerenciador de Pacotes do NuGet" que se localiza dentro na aba superior, no botão "Ferramentas"

5. Entrar no "Console do Gerenciador de Pacotes" e criar o tabela do Banco de dados no SQL Server, pelo seguinte comando:
- Update-database -Context Conexao.

6.  Iniciar o servidor por meio do depurador 



### Entidades existentes

-   Filmes
-   Preço
 - Crítica 


### Dependências para desenvolvimento:  📋

Dependências necessárias para o ambiente de desenvolvimento

1. Clique no botão "Ferramentas", que se localiza na aba superior

2. Abra sua lista de ferramentas e clique no "Gerenciador de Pacotes do NuGet"

3. Clique e se abra o " Gerenciador Pacotes do NuGet para a Solução..."

4. Na página que abrir clique no "Procurar" na aba superior

5. Instale os seguintes pacotes, e aceite os termos:
- Install-Package Microsoft.EntityFrameworkCore 
- Install-Package Microsoft.EntityFrameworkCore.Design 
- Install-Package Microsoft.EntityFrameworkCore.SqlServer

6. Após isso já está pronto para ser usado em seu códigos, lembre-se de referencia-los nas paginas que for usar sua função, exemplo:
[ILUSTRAR IMAGE]
----------

### Tecnologias usadas:  💻

-   C#
-   ASP NET 
-   SQL Server
-   ENTIFY FRAMEWORK CORE

### Documentação:  📖


-   [Minimal API](https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-6.0&tabs=visual-studio)


----------
