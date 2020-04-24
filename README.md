# FastShop.BackOffice

# Execução aplicação

**Visual Studio**

>>**1** Abrir solução, definir o projeto FastShop.BackOffice.Web como Set as StartUp Project.

>>**2** Alterar ConnectionStrings string no arquivo FastShop.BackOffice.Web/appsettings.json.

>>**3** Alterar ConnectionStrings string no arquivo FastShop.BackOffice.Repository/appsettings.json.

>>**4** No console do gerenciador Nuget executar o comando Update-Database no projeto FastShop.BackOffice.Repository.

>>**5** Dar start no projeto (F5)

**Terminal**:

>>**1** Alterar ConnectionStrings string no arquivo FastShop.BackOffic.Web/appsettings.json.

>>**2** Alterar ConnectionStrings string no arquivo FastShop.BackOffic.Repository/appsettings.json.

>>**3** Navegar até a pasta do projeto FastShop.BackOffic.Repository e executar o comando dotnet ef database update

>>**4** Navegar até a pasta do projeto FastShop.BackOffic.Web e executar o comando dotnet run.

