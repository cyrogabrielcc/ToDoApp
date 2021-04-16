using System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class UpdateToDoCommand : Notifiable, ICommand
    {
        public UpdateToDoCommand() { }

        public UpdateToDoCommand(Guid id, string title, string user)
        {
            this.Id = id;
            this.Title = title;
            this.User = user;

        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string User { get; set; }
        public void Validate()
        {
            new Contract()
                .Requires()
                .HasMinLen(User, 6, "User", "Usuário Inválido!")
                .HasMinLen(Title, 3, "Title", "Descreva melhor essa Tabela");
        }
    }
}