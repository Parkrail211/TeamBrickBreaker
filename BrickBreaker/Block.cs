﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    public class Block
    {
        public int width;
        public int height;

        public int x;
        public int y; 
        public int hp;
        public Color colour;

        public static Random rand = new Random();

        public Block()
        {

        }
    }
}
