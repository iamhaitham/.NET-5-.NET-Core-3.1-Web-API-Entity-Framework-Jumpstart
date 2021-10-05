using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section_1___Introduction___.NET_5.Models
{
    public class ServiceResponse<T>
    {
        public T Data { set; get; }
        public bool Success { set; get; } = true;
        public string Message { set; get; } = null;
    }
}