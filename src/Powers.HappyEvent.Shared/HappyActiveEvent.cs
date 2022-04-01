using Powers.HappyEvent.Abstracts;
using Powers.HappyEvent.Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.HappyEvent.Shared
{
    public class HappyActiveEvent : EntityBase, IEnableMark, IDeleteMark
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool EnableMark { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool DeleteMark { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
