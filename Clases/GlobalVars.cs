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
        private static int _GlobalDocumento;
        private static string _GlobalUserLogged;

        public static int GlobalId
        {
            get { return _GlobalId; }
            set { _GlobalId = value; }
        }

        public static int GlobalDocumento
        {
            get { return _GlobalDocumento; }
            set { _GlobalDocumento = value; }
        }

        public static string GlobalUserLogged
        {
            get { return _GlobalUserLogged; }
            set { _GlobalUserLogged = value; }
        }
    }
}
