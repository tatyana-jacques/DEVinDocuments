using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevInDocuments.Entities.Exceptions
{
    public class UsuarioNaoIdentificadoException: ApplicationException
    {
        public UsuarioNaoIdentificadoException()
        {
           Console.WriteLine("Insira uma identidade válida.");
        }
    }
    
}