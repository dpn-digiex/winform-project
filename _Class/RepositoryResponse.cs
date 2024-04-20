using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu._Class
{
    internal class RepositoryResponse
    {
        public string Message { get; set; }
        public bool Status { get; set; }

        public RepositoryResponse() { }
        public RepositoryResponse(string message, bool status)
        {
            Message = message;
            Status = status;
        }
    }
}
