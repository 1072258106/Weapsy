﻿using System.Threading.Tasks;
using Weapsy.Infrastructure.Domain;

namespace Weapsy.Infrastructure.Commands
{
    public interface ICommandSender
    {
        void Send<TCommand>(TCommand command, bool publishEvents = true)
            where TCommand : ICommand;

        void Send<TCommand, TAggregate>(TCommand command, bool publishEvents = true) 
            where TCommand : ICommand 
            where TAggregate : IAggregateRoot;

        Task SendAsync<TCommand>(TCommand command, bool publishEvents = true)
            where TCommand : ICommand;

        Task SendAsync<TCommand, TAggregate>(TCommand command, bool publishEvents = true)
            where TCommand : ICommand
            where TAggregate : IAggregateRoot;
    }
}
