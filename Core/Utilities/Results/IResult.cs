using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        //get sadece okunabilir.
        //set yazmak için
        bool Success { get; } //basarılı yada basarısız
        string Message { get; } //işlem hakında bilgi veren mesaj
    }
}
