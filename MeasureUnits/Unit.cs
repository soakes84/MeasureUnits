﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureUnits
{
    public class Unit
    {
        private string _uom;
        private string _type;

        public string UOM
        {
            get { return _uom; }
            set { _uom = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

    }
}