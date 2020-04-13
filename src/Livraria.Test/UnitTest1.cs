using Livraria.Domain.Entities;
using Livraria.Domain.Services;
using Livraria.Infra.Data.Context;
using Livraria.Infra.Data.Repositories;
using Livraria.Infra.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;

namespace Livraria.Test
{
    public class Tests
    {

        [Test]
        public void SalvarLivro()
        {
            var context = new DbContextOptions<LivrariaContext>();
            var livrariaContext = new LivrariaContext(context);
            var UnitOfWork = new UnitOfWork(livrariaContext);

            var livroRespositorio = new LivroRepository(livrariaContext);
            var Service = new LivroService(livroRespositorio, UnitOfWork);


            var livro = new Livro();
            livro.Autor = "Alexandre";
            livro.Titulo = "Prova Alexandre";
            livro.Descricao = "Descrição prova alexandre";
            livro.Editora = "Alexandre do alexandre";
            livro.Paginas =  99;
            livro.Publicacao = DateTime.Now;
            Service.Save(livro);

            
            Assert.AreEqual(true, livro.Valido, "Metodo salvar foi validado");
        }



        public void NaoSalvarInvalidosLivro()
        {
            var context = new DbContextOptions<LivrariaContext>();
            var livrariaContext = new LivrariaContext(context);
            var UnitOfWork = new UnitOfWork(livrariaContext);

            var livroRespositorio = new LivroRepository(livrariaContext);
            var Service = new LivroService(livroRespositorio, UnitOfWork);

            var livro = new Livro();
            livro.Autor = "";
            livro.Titulo = "";
            livro.Descricao = "";
            livro.Editora = "";
            livro.Paginas = 99;
            livro.Publicacao = DateTime.Now;
            Service.Save(livro);

            Assert.AreEqual(false, livro.Valido, "Metodo não salva livros inválidos");
        }



        public void DeletarLivros()
        {
            var context = new DbContextOptions<LivrariaContext>();
            var livrariaContext = new LivrariaContext(context);
            var UnitOfWork = new UnitOfWork(livrariaContext);

            var livroRespositorio = new LivroRepository(livrariaContext);
            var Service = new LivroService(livroRespositorio, UnitOfWork);

            var livro = livroRespositorio.GetAll().ToList().FirstOrDefault();
            Service.Delete(livro);

            Assert.AreEqual(false, livro.Valido, "Livro Excluido com sucesso");
        }
    }
}