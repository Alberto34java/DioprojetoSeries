using System;
using System.Collections.Generic;
using Models;
using Repositories;
using ValueObjects;

namespace controllers
{
    public class FilmeController
    {
        private FilmeRepository repository = new FilmeRepository();
        private List<Filme> filmes=new List<Filme>();
        

        public void Processos()
        {
            string opcao=LerOpcaoUsuario().ToUpper();
            while (opcao.ToUpper() != "S")
            {
                switch (opcao)
                {
                    case "1":
                    //LISTAGEM
                        break;
                        ListarFilmes();
                    case "2":
                    //BUSCA POR FILME
                    BuscarFilme();
                    break;
                    case "3":
                    //CADASTRAR NOVO FILME
                    SalvarFilme();
                    break;
                    case "4":
                    //ATUALIZAR CASO ERRO DE CADASTRO ,EXEMPLO NOME DIGITADO ERRADO
                    AtualizarFilme();
                    break;
                    case "5":
                    //EXCLUSÃO DE FILMES 
                    ExcluirFilme();
                    break;
                    case "L":
                    //LIMPAR A TELA 
                    Console.Clear();
                    break;    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                
            }
        }

        public bool ExcluirFilme()
        {
            try
            {
            Console.WriteLine("Digite o Id do Filme:");
            int id=Int32.Parse(Console.ReadLine());
            Filme model=repository.BuscarPorId(id);
            repository.ExcluirRegistro(id);
            return true;
            }
            catch 
            {
                
              return false;
            }
           

           
            
        }

        public string AtualizarFilme()
        {
               Filme filme;
               filme=null;
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
               filme=new Filme(nome,genero,descricao,ano);
               if(repository.AtualizarRegistro(filme, id))
               {
                   return "Ok";
               }
               else { 
                   return "Not Update";
               }
        }

        public string SalvarFilme()
        {
             string msg= "";
           try
           {
              
               Filme filme;
               filme=null;
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
               filme=new Filme(nome,genero,descricao,ano);
               if(repository.Salvar(filme))
                { msg=" Salvo com Sucesso!!"; 
                   return msg;
                }
                else {
                    Console.WriteLine("Erro :");
                }
           }
           catch 
           {
               msg=" Erro ao Salvar!!";
               
               return msg;
           }

            return msg;
        }

        public Filme BuscarFilme()
        {
            try
            {
                Console.WriteLine("Informe o Id?");
                int id=Int32.Parse(Console.ReadLine());
                var filme=repository.BuscarPorId(id);

                return filme;
            }
            catch (System.Exception)
            {
                
                return null;
            }
        }

        public List<Filme> ListarFilmes()
        {
           try
           {
               filmes=repository.Listar();
               return filmes;
           }
           catch 
           {
               
              return null;
           }
        }

        private string LerOpcaoUsuario()
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