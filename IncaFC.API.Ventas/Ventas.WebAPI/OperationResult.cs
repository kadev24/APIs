using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.WebAPI
{
    public class OperationResult
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object Value { get; set; }

    }
}
