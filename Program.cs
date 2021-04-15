using System;
using controllers;
using ValueObjects;

namespace digitalSeries_Projeto
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.WriteLine("Teste Inicial do Programa: ");
            try
            {
                 var controller= new FilmeController();
                string opcao=LerOpcaoUsuario().ToUpper();
            while (opcao.ToUpper() != "S")
            {
                switch (opcao)
                {
                    case "1":
                    //LISTAGEM
                        break;
                      
                    case "2":
                    //BUSCA POR FILME
                    BuscarFilme();
                    break;
                    case "3":
                    //CADASTRAR NOVO FILME
                
                    Salvar();
                    break;
                    case "4":
                    //ATUALIZAR CASO ERRO DE CADASTRO ,EXEMPLO NOME DIGITADO ERRADO
                    Atualizar();
                    break;
                    case "5":
                    //EXCLUSÃO DE FILMES 
                    ExcluirRegistro();
                    break;
                    case "L":
                    //LIMPAR A TELA 
                    Console.Clear();
                    break;    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao=LerOpcaoUsuario();
                
            }
            Console.WriteLine("Obrigado por Utilizar Nosso Programa: ");
            Console.ReadKey();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        private static void Atualizar()
        {
               Console.WriteLine("Digite o Id do Filme: ");
               int id=Int32.Parse(Console.ReadLine());
               Console.WriteLine("Digite o Nome Do Filme: ?");
               string nome=Console.ReadLine();
               foreach (int i in Enum.GetValues(typeof(Genero)))
               {
                  Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));   
               }
               Console.WriteLine("Digite O Genero entre as Opções acima: ");
               int escolha=Int32.Parse(Console.ReadLine());
               Genero genero=(Genero) escolha;
               Console.WriteLine("Digite a Descrição: ");
               string descricao=Console.ReadLine();
               Console.WriteLine("Digite o Ano de Lancemento do Filme: ");
               int ano=Int32.Parse(Console.ReadLine());
               var controle=new FilmeController();
               if(controle.AtualizarFilme(nome,escolha,descricao,ano,id))
               {
                   Console.WriteLine("Atualizado: ");
               }
               else {
                   Console.WriteLine("Erro ao Atualizar: ");
               }
        }

        private static void ExcluirRegistro()
        {
            Console.WriteLine("Digite o Id do Filme:");
           int id=Int32.Parse(Console.ReadLine());
           var controller=new FilmeController();
           if(controller.ExcluirFilme(id))
           {
               Console.WriteLine("Removido com Sucesso: ");
           }
           else{

               Console.WriteLine("Erro ao Remover: ");

           }
        }

        private static void BuscarFilme()
        {
                      Console.WriteLine("Informe o Id?");
                     int id=Int32.Parse(Console.ReadLine());
                     var controller=new FilmeController();
                     controller.BuscarFilme(id);
        }
        private static void Salvar()
        {

               Console.WriteLine("Digite o Nome Do Filme: ?");
               string nome=Console.ReadLine();
               foreach (int i in Enum.GetValues(typeof(Genero)))
               {
                  Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));   
               }
               Console.WriteLine("Digite O Genero entre as Opções acima: ");
               int escolha=Int32.Parse(Console.ReadLine());
                 Console.WriteLine("Digite a Descrição: ");
               string descricao=Console.ReadLine();
               Console.WriteLine("Digite o Ano de Lancemento do Filme: ");
               int ano=Int32.Parse(Console.ReadLine());
               var c=new FilmeController();
               c.SalvarFilme(nome,escolha,descricao,ano);


        }
         private static string LerOpcaoUsuario()
        {
            Console.WriteLine("Bem vindo(a) a Digital Filmes :");
            Console.WriteLine("Digite a opcao desejada:");
            Console.WriteLine("1=> Para Listar Filmes:");
            Console.WriteLine("2=> Para Buscar Filme");
            Console.WriteLine("3=> Para Cadastrar Novo Filme:");
            Console.WriteLine("4=> Para Atualizar Filme:");
            Console.WriteLine("5=> Para Remover Filme:");
            Console.WriteLine("L=> Para Limpar a Tela:");
            Console.WriteLine("S=> Para Sair do Sistema:");
            string opcao= Console.ReadLine().ToUpper();
            return opcao;
        }
    }

    
}
