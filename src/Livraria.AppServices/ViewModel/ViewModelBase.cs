using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.AppServices.ViewModel.Base
{
    public class ViewModelBase
    {
        public List<string> ListaErros { get; set; }
        public bool IsInvalid { get; set; }
        public bool IsValid { get; set; }
    }
}
