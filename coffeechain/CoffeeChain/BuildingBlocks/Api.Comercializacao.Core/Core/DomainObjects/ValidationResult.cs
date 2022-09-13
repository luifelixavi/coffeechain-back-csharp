using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Core.DomainObjects
{
    public class ValidationResult : FluentValidation.Results.ValidationResult
    {
        public ValidationResult()
        {
        }

        public ValidationResult(IEnumerable<ValidationFailure> failures)
        {
            foreach(var e in failures)
            {
                this.Errors.Add(e);
            }
          
        }
        public int TransactionId { get; set; }
       
    }
}
