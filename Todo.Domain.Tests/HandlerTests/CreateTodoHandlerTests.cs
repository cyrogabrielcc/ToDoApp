using System.Net.Mail;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateTodoHandlerTests
    {

        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("","",DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Title","name",DateTime.Now);
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
        private GenericCommandResult _result = new GenericCommandResult();

        public CreateTodoHandlerTests()
        {

        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Sucess, false);
            Assert.Fail();
        }
  
        [TestMethod]
            public void Dado_um_comando_valido()
        {
            _result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(_result.Sucess, false);

        }
    }
}