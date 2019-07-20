using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace APICRUDCoreRegister.Presentation.WebAPI.Models
{
    public class BusinessException : Exception
    {
        public IList<ValidationFailure> ErrorList { get; set; }

        public BusinessException(IList<ValidationFailure> errors) : base()
        {
            ErrorList = errors;
        }
    }
}
