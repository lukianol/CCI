﻿using System;

namespace CrackingCodingInterview
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class ReferenceAttribute : Attribute
    {
        public string Number { get; set; }
        public int Page { get; set; }
        public string Description { get; set; }
    }
}
