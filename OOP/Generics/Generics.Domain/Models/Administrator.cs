﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Administrator : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
