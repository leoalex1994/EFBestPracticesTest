﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreServices.Services.Interfaces
{
    public interface ITestService
    {
        public IEnumerable<string> getTest();
    }
}
