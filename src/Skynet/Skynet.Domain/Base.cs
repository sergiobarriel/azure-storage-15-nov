using System;

namespace Skynet.Domain
{
    public abstract class Base
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }

        protected Base()
        {
            Id = GetId();
            Created = DateTime.UtcNow;
        }

        private static Guid GetId() => Guid.NewGuid();
    }
}
