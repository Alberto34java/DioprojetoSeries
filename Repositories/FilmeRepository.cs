using System.Collections.Generic;
using System.Linq;
using data;
using Microsoft.EntityFrameworkCore;
using Models;
using Repositories.Contracts;

namespace Repositories
{
    public class FilmeRepository : IRepository<Filme>
    {
        private DataContext _context= new DataContext();
        public bool AtualizarRegistro(Filme model, int id)
        {
           

            try
            {

                 model.Id = id;
                _context.Entry<Filme>(model).State= EntityState.Modified;
                _context.SaveChanges();
                return true;
                
            }
            catch
            {
                 // TODO
                 return false;
            }
        }

        public Filme BuscarPorId(int id)
        {
            var filme= _context.Filmes.Find(id);
            return filme;
        }

        public void ExcluirRegistro(int id)
        {
            var filme= _context.Filmes.Find(id);
            _context.Remove(filme);
            _context.SaveChanges();
        }

        public List<Filme> Listar()
        {
            return _context.Filmes.ToList();
        }

        public bool Salvar(Filme model)
        {
           

            try
            {
                 _context.Filmes.Add(model);
                 _context.SaveChanges();
                 return true;
                
            }
            catch
            {
                 // TODO
                 return false;
            }
        }
    }
}