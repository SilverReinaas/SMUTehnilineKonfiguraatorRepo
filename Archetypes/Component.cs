﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Archetypes
{
    public class Component
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}