# Projeto_VeiculosVenda

Foi usado banco de dados SQL SERVER MANAGMENT STUDIO 2022: 
https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

SQLEXPRESS 2022:
https://www.microsoft.com/en-us/sql-server/sql-server-downloads

Abra o Console do Gerenciador de Pacotes e execute os seguintes comandos Migration para criação dos objetos de banco:
Add-Migration Criacao-Inicial -Context Contexto
Update-database -Context Contexto

Pacotes instalados
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.SqlServer

Utilizado .NET 6.0
