using System;
using Repositories;

namespace controllers
{
    public class FilmeController
    {
        private FilmeRepository repository = new FilmeRepository();
        

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
                        //ListarFilmes();
                    case "2":
                    //BUSCA POR FILME
                    break;
                    case "3":
                    //CADASTRAR NOVO FILME
                    break;
                    case "4":
                    //ATUALIZAR CASO ERRO DE CADASTRO ,EXEMPLO NOME DIGITADO ERRADO
                    break;
                    case "5":
                    //EXCLUSÃO DE FILMES 
                    break;
                    case "L":
                    //LIMPAR A TELA 
                    break;    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                
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