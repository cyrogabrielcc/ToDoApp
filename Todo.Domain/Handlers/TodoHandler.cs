using System;
using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoHandler : 
                    Notifiable, 
                    IHandler<CreateTodoCommand>, 
                    IHandler<UpdateTodoCommand>,
                    IHandler<MarkTodoAsUndoneCommand>,
                    IHandler<MarkTodoAsDoneCommand>
    {
        private readonly ITodoRepository _repository;
        public TodoHandler(ITodoRepository repository)
        {
              _repository = repository;
        }
        public ICommandResult Handle(CreateTodoCommand command)
        {
            //validação
            command.Validate();
            if(command.Invalid) return new GenericCommandResult(false,"Ops, parece que sua tarefa está errada!", command.Notifications);

            //criar TodoItem
            var todo = new TodoItem(command.Title, command.User, command.Date);
        
            //criar todo no repositorio
            _repository.Create(todo);

            return new GenericCommandResult(true, "tarefa salva", todo);
        }

        public ICommandResult Handle(UpdateTodoCommand command)
        {
            if(command.Invalid) return new GenericCommandResult(false, "Ops, a tarefa está errada!", command.Notifications);

            var todo = _repository.GetById(command.Id, command.User);

            todo.UpdateTitle(command.Title);

            _repository.Update(todo);
            return new GenericCommandResult(true,"Saved",DateTime.Now);
        }

        public ICommandResult Handle(MarkTodoAsDoneCommand command)
        {
            var todo = _repository.GetById(command.Id, command.User);

            todo.MarkAsDone();

            _repository.Update(todo);

            return new GenericCommandResult(true,"Saved",DateTime.Now);
        }

        public ICommandResult Handle(MarkTodoAsUndoneCommand command)
        {
            var todo = _repository.GetById(command.Id, command.User);

            todo.MarkAsUndone();

            _repository.Update(todo);
            
            return new GenericCommandResult(true,"Saved",DateTime.Now);
        }

    
    }
}








