using System;

namespace SaleWebMvc.Services.Exceptions
{
    public class IntegrityExcemption:ApplicationException
    {
        public IntegrityExcemption(string message):base(message)
        {

        }
    }
}
