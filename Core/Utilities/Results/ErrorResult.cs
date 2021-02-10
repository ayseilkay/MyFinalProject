using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message)//burada  base dediği result sınıfıdır
        {

        }
        public ErrorResult() : base(false)//base in tek parametreli olanını calıstır 
        {

        }
    }
}
