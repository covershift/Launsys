using Launsys.Data.Operations;
using Launsys.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launsys.Business
{
    public class ServicioBL
    {
        ServicioDL servicioDL = new ServicioDL();

        public Task<List<ServicioBE>> ConsultarLista()
        {
            return servicioDL.ConsultarLista();
        }
    }
}
