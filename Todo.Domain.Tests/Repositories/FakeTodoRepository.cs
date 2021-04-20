using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        void ITodoRepository.Create(TodoItem todo)
        {


        }

        TodoItem ITodoRepository.GetById(Guid id, string user)
        {
            throw new NotImplementedException();
        }

        void ITodoRepository.Update(TodoItem todo)
        {

            
        }
    }
}