﻿using System;

namespace MockInterview.Domain.Commons
{
    public class Auditable
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
