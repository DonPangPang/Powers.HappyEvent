using Powers.HappyEvent.Abstracts;
using Powers.HappyEvent.Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.HappyEvent.Shared
{
    public class PickRecord : EntityBase, IEnableMark, IDeleteMark
    {
        public bool EnableMark { get; set; } = true;
        public bool DeleteMark { get; set; } = false;

        public Guid GiftId { get; set; }
        public Gift? Gift { get; set; }
    }
}
