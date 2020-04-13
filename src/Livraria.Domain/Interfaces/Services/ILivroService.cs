using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Domain.Interfaces.Services
{
    public interface ILivroService : IServiceBase<Livro>
    {
        IEnumerable<Livro> FiltrarTitulo(string filtro);
        IEnumerable<Livro> ObertTodos();
        Livro GetById(int LivroId);

    }
}
