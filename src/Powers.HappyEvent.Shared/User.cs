using Powers.HappyEvent.Abstracts;
using Powers.HappyEvent.Abstracts.Interfaces;
using System;

namespace Powers.HappyEvent.Shared
{
    public class User: EntityBase, IEnableMark, IDeleteMark
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; } = false;
        public bool EnableMark { get; set; } = true;
        public bool DeleteMark { get; set; } = false;
    }
}
