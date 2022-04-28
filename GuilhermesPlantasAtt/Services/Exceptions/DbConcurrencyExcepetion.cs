using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuilhermesPlantasAtt.Services.Exceptions
{
    public class DbConcurrencyExcepetion : ApplicationException
    {
        public DbConcurrencyExcepetion(string message) : base(message)
        {

        }
    }
}
