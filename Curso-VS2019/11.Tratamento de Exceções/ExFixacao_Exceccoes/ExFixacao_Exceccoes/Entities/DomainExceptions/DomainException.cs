using System; 

namespace ExFixacao_Exceccoes.Entities.DomainExceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
