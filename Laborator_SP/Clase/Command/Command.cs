﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    public interface Command
    {
        public void execute();
        public void unexecute();
    }
}
