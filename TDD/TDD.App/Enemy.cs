﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.App
{
    public abstract class Enemy
    {
        private string _name = "Default Name";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}

