using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.HappyEvent.Shared
{
    public class ReturnDto
    {
        public StatueCode Code { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
    }

    public enum StatueCode
    {
        Success = 200,
        Fail = 400
    }
}
