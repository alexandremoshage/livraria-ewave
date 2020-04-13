using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces.Repositories;
using Livraria.Infra.Data.Context;
using Livraria.Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Livraria.Infra.Data.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {

        public LivroRepository(LivrariaContext context)
            : base(context)
        { }

        public IEnumerable<Livro> GetAll()
        {
            var dados = _Context.Livro.ToList();
            return dados;
        }

        public IEnumerable<Livro> GetByFilter(string filtro)
        {
            var dados = _Context.Livro.Where(x => x.Titulo.Contains(filtro) || x.Genero.Contains(filtro)|| x.Autor.Contains(filtro) || x.Editora.Contains(filtro));
            return dados;
        }

        public Livro GetById(int livroId)
        {
            var dados = _Context.Livro.FirstOrDefault(p => p.LivroId == livroId);
            return dados;
        }

    }
}
