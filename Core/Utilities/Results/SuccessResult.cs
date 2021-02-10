using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message)//burada  base dediği result sınıfıdır
        {

        }
        public SuccessResult() : base(true)//base in tek parametreli olanını calıstır 
        {

        }
    }
}
