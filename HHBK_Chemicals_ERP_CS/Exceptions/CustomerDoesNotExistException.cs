using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHBK_Chemicals_ERP_CS.Exceptions
{
    public class CustomerDoesNotExistException:ApplicationException
    {
        public CustomerDoesNotExistException() : base() { }
        public CustomerDoesNotExistException(string message) : base(message) { }
        public CustomerDoesNotExistException(string message, Exception ex) : base(message, ex) { }
    }
}
