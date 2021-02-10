using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       // getter readonly dir .Readonly yapılar consructorda set edilebilir.
        public Result(bool success, string message):this(success)//this result anlamaına gelir (classın kendisi)
        {
            Message = message;
           // Success = success;
        }
        public Result(bool success)//Overloading 
        {
            
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
