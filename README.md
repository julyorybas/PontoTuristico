# PontoTuristico
<h>Projeto teste realizado utilizando:</h5>
  <h6>Visual Studio 2022</h6>
  <h6>.Net6</h6>
  <h6>MVC</h6>
<h5>Utilizado os pacotes:</h5>
  <h6>Microsoft.EntityFrameworkCore Versão="6.0.10"</h6>
  <h6>Microsoft.EntityFrameworkCore.SqlServer Versão="6.0.10"</h6>
  <h6>Microsoft.EntityFrameworkCore.Tools Versão="6.0.10"</h6>
  
# Configuração
 <h5>Realizar o clone do projeto do github no visual studio</h5>
 <h5>Logo após que o projeto estiver clonado no Visual Studio realizar os seguintes passos:</h5>
   <h6>Verificar se esta com todas as dependências instalada, caso não esteja instalar as mesma que estiverem faltado atraves do 'Gerenciar pacotes do NuGet...'</h6>
   <h6>Acessar o arquivo 'Program.cs'e modificar a string de conexão para o seu banco de dados, a string de conexão esta na linha 10 do arquivo. </h6>
   <h6>Verificar se as migrations esta no projeto, caso não estaja executar os seguintes procedimentos:</h6>
       <h6>Na aba do Visual Studio ir em 'Ferramentas', 'Gerenciador de Pacotes do NuGet', 'Console do Gerenciador de Pacotes' e digitar os sequintes comandos: </h6>
       <h6>Add-Migration Inicial-Criacao -Context Conexao</h6>
       <h6>Update-database -Context Conexao</h6>
  <h5>Caso no projeto ja esteja com as Migrations executar somente esse procedimentos</h5>
      <h6>Na aba do Visual Studio ir em 'Ferramentas', 'Gerenciador de Pacotes do NuGet', 'Console do Gerenciador de Pacotes' e digitar os sequintes comandos: </h6>
      <h6>Update-database -Context Conexao</h6>
    <h6>Logo apos a execução desse comando sera criado a base de dados no banco de dados. </h6>
     <h6>Finalizado todos esses procedimentos o projeto já esta configurado para ser executado.</h6>
       
       
  
