﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Second_Example
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}