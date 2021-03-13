using System;
namespace Banco.Entity.Exceptions
{
    public class DomainException : ApplicationException
    {

        public DomainException(string message) : base(message)
        {
        }
    }
}
