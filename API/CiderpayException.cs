using System;
using ciderpaysample.API.Dto;

namespace ciderpaysample.API
{
    public class CiderpayException : Exception
    {
        public CpResponseError Error { get; }

        public CiderpayException(CpResponseError error)
        {
            Error = error;
        }
    }
}
