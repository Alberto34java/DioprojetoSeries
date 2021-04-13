Implementacao do Projeto Cadastro de Series 
será adicionado os pacotes 
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.0-preview.3.21201.2
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.0-preview.3.21201.2
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.0-preview.3.21201.2

Para criação do projeto será abordado o Code First junto com o padrão Repository Pattern.
também foi adicionado uma pasta controller contendo a classe responsável pelos métodos 
de acesso a dados .
Essa Classe não é o padrão Web Mvc que herda da Classe Controller ,
 será criada apenas para 
Controlar as operações realizadas na Tela 
Foi criado uma pasta ValueObjects para separar o arquivo de enum do projeto
que será utilizado dentro da classe de modelo do banco 
