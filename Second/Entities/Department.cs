﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Second.Entities
{
    class Department
    {
        public String Name { get; set; }

        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
