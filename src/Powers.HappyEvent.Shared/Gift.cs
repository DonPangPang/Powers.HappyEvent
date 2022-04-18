using Powers.HappyEvent.Abstracts;
using Powers.HappyEvent.Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.HappyEvent.Shared
{
    public class Gift : EntityBase, IEnableMark, IDeleteMark
    {
        public decimal Price { get; set; }
        public int PickCount { get; set; }
        public bool EnableMark { get; set; } = true;
        public bool DeleteMark { get; set; } = false;
    
        public Guid? HappyActiveEventId { get; set; }
        public HappyActiveEvent? HappyActiveEvent { get; set; }

        public ICollection<PickRecord>? PickRecords { get; set; }
    }
}
