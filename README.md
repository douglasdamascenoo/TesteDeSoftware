# Testes de Software com ASP.NET
O projeto foi construído durante o treinamento do curso ***Dominando os Testes de Software*** realizado no portal [Desenvolvedor.io](https://desenvolvedor.io/).

Para elaboração do projeto, primeiramente criei uma pasta para servir de base da estrutura da solução, nomeei-a de *TestesSoftware*. Após, dentro da referida pasta criei um arquivo de `solution` de mesmo nome com o seguinte comando `dotnet new sln`.

### 1. Teste de Unidade
> Criação do primeiros testes de unidade.

1.1 Criar um pasta de nome *1 - TesteUnidade* para armazenar os projetos de Testes de Unidade.
1.2 Criar dentro da pasta *1 - TesteUnidade* o projeto do tipo `classlib` para servir de fonte de teste. Projeto de *TesteBasico*.
```powershell
dotnet new classlib -o TesteBasico
```
1.3 Após, também dentro da pasta *1 - TesteUnidade*, criar um projeto do tipo `xunit` para armazenamento dos testes. Projeto de *TesteBasico.Test*.
```powershell
dotnet new xunit -o TesteBasico.Test
```

### 2. Fixtures
> Apresentação de Features

2.1 Traits
