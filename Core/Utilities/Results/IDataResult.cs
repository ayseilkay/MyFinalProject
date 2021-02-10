using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //bir interface başka bir interface i mplemnte ediyorsa implemente ettiği interfacein (onun) özelliklerini almıs gibi davranır
    public interface IDataResult<T>:IResult
    {
        T Data { get; }

    }
}
