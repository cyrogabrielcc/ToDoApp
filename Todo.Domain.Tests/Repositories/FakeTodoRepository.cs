using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        void ITodoRepository.Create(TodoItem todo)
        {


        }

        void ITodoRepository.Update(TodoItem todo)
        {

            
        }
    }
}