using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Domain.Entities.Base
{
    public class EntityBase
    {
        public EntityBase()
        {
            this.ListaErros = new List<string>();
        }

        public List<string> ListaErros { get; set; }

        public void AdicionaErro(string erro) => this.ListaErros.Add(erro);

        public bool Valido { get => this.ListaErros.Count > 0; }
    }
}
