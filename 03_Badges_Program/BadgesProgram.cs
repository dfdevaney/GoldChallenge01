﻿using _03_Badges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges_Program
{
    class BadgesProgram
    {
        static void Main(string[] args)
        {
            IConsole console = new RealConsole();
            ProgramUI ui = new ProgramUI(console);
            ui.Run();
        }
    }
}
