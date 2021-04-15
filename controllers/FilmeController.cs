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
        

        

        public bool ExcluirFilme(int id)
        {
            try
            {
          
            Filme model=repository.BuscarPorId(id);
            repository.ExcluirRegistro(id);
            return true;
            }
            catch 
            {
                
              return false;
            }
           

           
            
        }

        public bool AtualizarFilme(string nome, int escolha, string descricao, int ano,int id)
        {
               Filme filme;
               filme=null;
               Genero genero=(Genero) escolha;
               filme=new Filme(nome,genero,descricao,ano);
               if(repository.AtualizarRegistro(filme, id))
               {
                   return true;
               }
               else { 
                   return false;
               }
        }

        public string SalvarFilme(string nome, int escolha, string descricao, int ano)
        {
             string msg= "";
           try
           {
              
               Filme filme;
               filme=null;
              
               Genero genero=(Genero) escolha;
             
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

        public Filme BuscarFilme(int id)
        {
            try
            {
                
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