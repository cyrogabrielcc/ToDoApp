using System;

namespace Todo.Domain.Entities
{
    //entidade base, abstrata e não referenciada
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        /* gerando hash de id -> não depende do banco pra geração de índice */
        public Guid Id { get; private set; }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }
}