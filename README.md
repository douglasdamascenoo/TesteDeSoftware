# Testes de Software com ASP.NET
O projeto foi construído durante o treinamento realizado no curso ***Dominando os Testes de Software*** do portal [Desenvolvedor.io](https://desenvolvedor.io/).

Primeiramente será necessário criar a estrutura base do projeto com uma pasta, no meu caso nomeei-a de *TestesSoftware*. Após dentro da referida pasta criei um arquivo de `solution` de mesmo nome com o seguinte comando `dotnet new sln`.

### 1. Teste de Unidade
1.1 Criar projeto do tipo `classlib`.
```powershell
dotnet new classlib -o TesteUnidade
```
1.4 Criar projeto do tipo `xunit`
```powershell
dotnet new xunit -o TesteUnidade.Test
```
