using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevInDocuments.Entities.Exceptions
{
    public class OpcaoInexistenteException: ApplicationException
    {
        public OpcaoInexistenteException(string mensagem)
        {
            Console.WriteLine ("==================================================================================\n"+
            mensagem);
        }
        
    }
}