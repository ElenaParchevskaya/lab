﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal partial class Watch : Good
    {
        public override string ToString()
        {
            return ($"Type : Watch, Name : {name}, Price : {price}");
        }
    }
}
