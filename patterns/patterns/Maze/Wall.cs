﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Wall:MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }
}
