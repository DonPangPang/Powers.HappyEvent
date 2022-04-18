using System;
using System.Collections.Generic;
using System.Text;

namespace Powers.HappyEvent.Shared.Responses
{
    public class ResponseModel
    {
        public int Code { get; set; } = 400;
        public string? Message { get; set; }
        public object? Data { get; set; }
    }
}
