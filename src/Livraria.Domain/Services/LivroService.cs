using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces.Repositories;
using Livraria.Domain.Interfaces.Services;
using Livraria.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Domain.Services
{
    public class LivroService : ILivroService
    {

        private readonly ILivroRepository _livroRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LivroService(ILivroRepository livroRepository, IUnitOfWork unitOfWork)
        {
            _livroRepository = livroRepository;
            _unitOfWork = unitOfWork;
        }

        public Livro Save(Livro entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valido)
            {
                _livroRepository.Save(entity);
                _unitOfWork.Commit();
            }
            return entity;
        }

        public Livro Update(Livro entity)
        {
            if (!entity.Validar())
                return entity;
            if (entity.Valido)
            {
                _livroRepository.Update(entity);
                _unitOfWork.Commit();
            }

            return entity;
        }

        public bool Delete(Livro entity)
        {

            _livroRepository.Delete(entity);
            _unitOfWork.Commit();

            return _unitOfWork.Sucesso();
        }

        public Livro GetById(int LivroId)
        {
            return _livroRepository.GetById(LivroId);
        }

        public IEnumerable<Livro> ObertTodos()
        {
            return _livroRepository.GetAll();
        }

        public IEnumerable<Livro> FiltrarTitulo(string filtro)
        {
            return _livroRepository.GetByFilter(filtro);
        }


        public void Dispose()
        {
            _livroRepository.Dispose();
        }

    }
}
