﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianLanderExercise
{
    public class Rover
    {
        public string name { get; set; }
        public int xLimit { get; set; }
        private int yLimit { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public char heading { get; set; }

        public Rover(string name, int x, int y, char heading, int limX, int limY)
        {
            this.name = name;
            this.posX = x;
            this.posY = y;
            this.heading = heading;
            this.xLimit = limX;
            this.yLimit = limY;
        }

        public void interpretInstruction(char[] ins)
        {
            Console.WriteLine("\nInstruction for {0} is: {1}", this.name, new string(ins));
            foreach (char c in ins)
            {
                if (c == 'L')
                {
                    turnLeft();
                    Console.WriteLine("Turned Left, now facing {0}", this.heading);

                }
                if (c == 'R')
                {
                    turnRight();
                    Console.WriteLine("Turned Right, now facing {0}", this.heading);

                }
                if (c == 'M')
                {
                    move();
                    Console.WriteLine("Moved to {0} {1}, now facing {2}", this.posX, this.posY, this.heading);

                }
            }
        }

        public bool turnLeft()
        {
            bool turned = false;
            if (this.heading == 'N')
            {
                this.heading = 'W';
                turned = true;
                return turned;
            }
            else if (this.heading == 'E')
            {
                this.heading = 'N';
                turned = true;
                return turned;
            }
            else if (this.heading == 'S')
            {
                this.heading = 'E';
                turned = true;
                return turned;
            }
            else if (this.heading == 'W')
            {
                this.heading = 'S';
                turned = true;
                return turned;
            }
            return turned;
        }

        public bool turnRight()
        {
            bool turned = false;
            if (this.heading == 'N')
            {
                this.heading = 'E';
                turned = true;
                return turned;
            }
            if (this.heading == 'E')
            {
                this.heading = 'S';
                turned = true;
                return turned;
            }
            if (this.heading == 'S')
            {
                this.heading = 'W';
                turned = true;
                return turned;
            }
            if (this.heading == 'W')
            {
                this.heading = 'N';
                turned = true;
                return turned;
            }
            Console.WriteLine("Wrong Direction information!");
            return turned;
        }

        public Boolean move()
        {
            bool moved = false;
            if (this.heading == 'N' && posY <= this.yLimit)
            {
                this.posY++;
                moved = true;
                return moved;
            }
            if (this.heading == 'E' && posX <= this.xLimit)
            {
                this.posX++;
                moved = true;
                return moved;
            }
            if (this.heading == 'S' && posY >= 0)
            {
                this.posY--;
                moved = true;
                return moved;
            }
            if (this.heading == 'W' && posX >= 0)
            {
                this.posX--;
                moved = true;
                return moved;
            }
            Console.WriteLine("Wrong Direction information!");
            return moved;
        }
    }
}
