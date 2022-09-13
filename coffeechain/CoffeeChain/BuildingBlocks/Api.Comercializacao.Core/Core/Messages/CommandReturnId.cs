using System;
using System.Text.Json.Serialization;
using Core.Core.DomainObjects;
using MediatR;

namespace Core.Messages
{
    public abstract class CommandReturnId : Message, IRequest<ValidationResult>
    {
        [JsonIgnore]
        public DateTime Timestamp { get; private set; }
        [JsonIgnore]
        public ValidationResult ValidationResult { get; set; }

        protected CommandReturnId()
        {
            Timestamp = DateTime.Now;
        }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
