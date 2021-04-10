using System;

namespace Services.Shared.Domain.Entities
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
