﻿using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool success, string message = null)
        {
            Success = success;
            Message = message;
            
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
