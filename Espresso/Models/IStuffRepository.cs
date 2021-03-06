﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public interface IStuffRepository
    {
        IEnumerable<Stuff> GetAllStuff();

        Stuff GetAllStuffById(int stuffId);
    }
}
