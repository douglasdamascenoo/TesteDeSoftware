# Testes de Software com ASP.NET
1. Criar diretório raiz da solução.
2. Criar arquivo de solução dentro do diretório..
```powershell
dotnet new sln
```
3. Criar projeto do tipo `classlib`.
```powershell
dotnet new classlib -o MeuProjeto
```
4. Criar projeto do tipo `xunit`
```powershell
dotnet new xunit -o MeuProjeto.Test
```