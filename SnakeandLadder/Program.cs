﻿using System;
using System.Xml.Linq;

namespace SnakeandLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder Problem !!");
            Snake snake = new Snake();
            snake.player();
        }
    }
}
