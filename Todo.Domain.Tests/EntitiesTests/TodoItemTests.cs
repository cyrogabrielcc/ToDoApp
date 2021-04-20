using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
namespace Todo.Domain.Tests.EntitiesTests
{


    public class TodoItemTests
    {
        private readonly TodoItem _validTodo = new TodoItem("Titulo", "nomedapessoa", DateTime.Now);
        private readonly TodoItem _invalidTodo = new TodoItem("", "", DateTime.Now);
        public void Dado_Todo_inconcluivel()
        {
            Assert.AreEqual(_invalidTodo.Done, false);
        }
        
    }
}