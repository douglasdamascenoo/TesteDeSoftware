# Testes de Software com ASP.NET

## 1. Teste de Unidade
1.1 Criar diretório raiz da solução.
1.2 Criar arquivo de solução dentro do diretório..
```powershell
dotnet new sln
```
1.3 Criar projeto do tipo `classlib`.
```powershell
dotnet new classlib -o MeuProjeto
```
1.4 Criar projeto do tipo `xunit`
```powershell
dotnet new xunit -o MeuProjeto.Test
```
