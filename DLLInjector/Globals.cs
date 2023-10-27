﻿using DLLInjector.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLInjector
{
    public static class Globals
    {
        public static ThemeManager? ThemeManager { get; set; }

        public static void Initialize()
        {
            ThemeManager = new();
        }
    }
}