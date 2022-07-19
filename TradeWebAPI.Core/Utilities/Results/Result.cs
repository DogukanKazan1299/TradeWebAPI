﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeWebAPI.Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool Success,string message):this(Success)
        {
            Message = message;
        }

        public Result(bool success)
        {
                Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
        

    }
}
