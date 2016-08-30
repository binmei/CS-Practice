using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianLanderExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover r1 = new Rover(1, 2, 'N');
            Rover r2 = new Rover(3, 4, 'E');


        }
    }

    public class Rover
    {
        private int xLimit { get; set; }
        private int yLimit { get; set; }
        private int posX { get; set; }
        private int posY { get; set; }
        private char heading { get; set; }

        public Rover(int x, int y, char heading)
        {
            this.posX = x;
            this.posY = y;
            this.heading = heading;
        }

        public void interpretInstruction(char[] ins)
        {
            foreach (char c in ins)
            {
                if (c == 'L')
                {
                    this.turnLeft();
                }
                if (c == 'R')
                {
                    this.turnRight();
                }
                if(c == 'M')
                {
                    this.move();
                }
            }
        }

        public bool turnLeft()
        {
            bool turned = false;
            if(this.heading == 'N')
            {
                this.heading = 'W';
                turned = true;
            }
            if (this.heading == 'E')
            {
                this.heading = 'N';
                turned = true;
            }
            if (this.heading == 'S')
            {
                this.heading = 'E';
                turned = true;
            }
            if (this.heading == 'W')
            {
                this.heading = 'S';
                turned = true;
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
            }
            if (this.heading == 'E')
            {
                this.heading = 'S';
                turned = true;
            }
            if (this.heading == 'S')
            {
                this.heading = 'W';
                turned = true;
            }
            if (this.heading == 'W')
            {
                this.heading = 'N';
                turned = true;
            }
            return turned;
        }

        public Boolean move()
        {
            bool moved = false;
            if (this.heading == 'N' && posY < this.yLimit) 
            {
                this.posY++;
                moved = true;
            }
            if (this.heading == 'E' && posX < this.xLimit)
            {
                this.posX++;
                moved = true;
            }
            if (this.heading == 'S' && posY > 0)
            {
                this.posY--;
                moved = true;
            }
            if (this.heading == 'W' && posX > 0)
            {
                this.posX--;
                moved = true;
            }
            return moved;
        }
    }
}
