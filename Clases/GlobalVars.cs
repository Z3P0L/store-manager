﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO.Clases
{
    internal class GlobalVars
    {
        private static int _GlobalId;

        public static int GlobalId
        {
            get { return _GlobalId; }
            set { _GlobalId = value; }
        }
    }
}
