using System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class MarkToDoAsDone : Notifiable, ICommand
    {
        public MarkToDoAsDone() { }

        public MarkToDoAsDone(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; }
        public void Validate()
        {
            new Contract()
                .Requires()
                .HasMinLen(User,6, "User", "Usuário Inválido!");
        }
    }
}