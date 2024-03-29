﻿using System.Threading.Tasks;
using FluentValidation.Results;
using Core.Messages;


namespace Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<ValidationResult> EnviarComando<T>(T comando) where T : Command;

        Task<Core.DomainObjects.ValidationResult> EnviarComandoReturnId<T>(T comando) where T : CommandReturnId;
    }
 }