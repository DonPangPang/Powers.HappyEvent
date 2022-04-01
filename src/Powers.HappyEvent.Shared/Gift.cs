using Powers.HappyEvent.Abstracts;
using Powers.HappyEvent.Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.HappyEvent.Shared
{
    public class Gift : EntityBase, IEnableMark, IDeleteMark
    {
        public float Price { get; set; }
        public int PickCount { get; set; }
        public bool EnableMark { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool DeleteMark { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    
        public Guid? HappyActiveEventId { get; set; }
    }
}
