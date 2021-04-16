using System.Collections.Generic;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Handlers.Contracts
{
    //sempre será IHandler T desde que IHandler seja Icommand
    public interface IHandler<T> where T : ICommand
    {
         ICommandResult Handle(T command);
    }
}