﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_Lab8.Model
{
    interface Comparable<T>
    {
        bool isGreaterThan(T element);
    }
}
