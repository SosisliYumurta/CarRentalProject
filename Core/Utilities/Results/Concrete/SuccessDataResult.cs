using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message = null) : base(data, true, message)
        {
            
        }
        public SuccessDataResult(string message = null) : base(default,true, message)
        {
            
        }
        public SuccessDataResult() : base(default, true)
        {
            
        }

    }
}
