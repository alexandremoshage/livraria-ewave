using Livraria.AppServices.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Livraria.AppServices.ViewModel
{
    public class LivroViewModel : ViewModelBase
    {
        [Display(Name = "ID")]
        public int LivroId { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Obrigatório")]
        public string Titulo { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Obrigatório")]
        public string Genero { get; set; }

        [Display(Name = "Publicação")]
        [Required(ErrorMessage = "Obrigatório")]
        [DataType(DataType.Date)]
        public DateTime Publicacao { get; set; }

        [Display(Name = "Páginas")]
        [Required(ErrorMessage = "Obrigatório")]
        public int Paginas { get; set; }

        [Display(Name = "Autor")]
        [Required(ErrorMessage = "Obrigatório")]
        public string Autor { get; set; }

        [Display(Name = "Editora")]
        [Required(ErrorMessage = "Obrigatório")]
        public string Editora { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Obrigatório")]
        public string Descricao { get; set; }

    }
}
