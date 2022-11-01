using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevInDocuments.Entities.Exceptions
{
    public class CampoNuloException: ApplicationException
    {
        public CampoNuloException(string message): base(message)
        {
            
        }
    }
}