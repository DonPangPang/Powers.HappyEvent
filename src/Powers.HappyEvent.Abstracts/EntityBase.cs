using System;

namespace Powers.HappyEvent.Abstracts
{
    public class EntityBase
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public Guid? CreateUserId { get; set; }
        public string? CreateUserName { get; set; }
        public Guid? ModifyUserId { get; set; }
        public string? ModifyUserName { get; set; }
    }
}
