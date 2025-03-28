using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMaker
{
    internal class Players
    {
        public int p1X, p1Y;
        public int size = 15;
        public int speed = 4;
        public string direction = "right";

        public int innerSize = 5;
        public Image pacImage = Properties.Resources.pacman;

        public Players()
        {
            p1X = GameScreen.screenWidth / 2 - (size / 2);
            p1Y = 75;
        }

        public bool Collisions(Rectangle coins)
        {
            Rectangle coinRec = new Rectangle(coins.X, coins.Y, coins.Width, coins.Height);
            Rectangle playerRec = new Rectangle(p1X, p1Y, size, size);

            if (playerRec.IntersectsWith(coinRec))
            {
                return true;
            }

            return false;
        }

        public bool CanTurn(Ibox ib)
        {
            Rectangle innerPlayerRec = new Rectangle(p1X + 5, p1Y + 5, innerSize, innerSize);

            if (innerPlayerRec.IntersectsWith(ib.boxRec))
            {
                return true;
            }

            return false;
        }

        public bool GhostCollision(Ghost g)
        {
            Rectangle playerRec = new Rectangle(p1X, p1Y, size, size);
            Rectangle ghostRec = new Rectangle(g.x, g.y, g.size, g.size);

            if (playerRec.IntersectsWith(ghostRec))
            {
                return true;
            }

            return false;
        }

        public bool CandyCollision(Rectangle candys)
        {
            Rectangle playerRec = new Rectangle(p1X, p1Y, size, size);
            Rectangle candyRec = new Rectangle(candys.X, candys.Y, size, size);

            if (playerRec.IntersectsWith(candyRec))
            {
                return true;
            }

            return false;
        }

        public void MovePlayer()
        {
            if (direction == "right")
            {
                p1X += speed;
                pacImage = Properties.Resources.pacman;
            }
            else if (direction == "left")
            {
                p1X -= speed;
                pacImage = Properties.Resources.pacman_left;
            }
            else if (direction == "down")
            {
                p1Y += speed;
                pacImage = Properties.Resources.pacman_Down;
            }
            else if (direction == "up")
            {
                p1Y -= speed;
                pacImage = Properties.Resources.pacman_Up;
            }

            //if goes through the side put it on other side 
            if (p1X < -20)
            {
                p1X = GameScreen.screenWidth + 15;
            }
            else if (p1Y < -20)
            {
                p1Y = GameScreen.screenHeight + 15;
            }
            else if (p1Y > GameScreen.screenHeight + 20)
            {
                p1Y = -15;
            }
            else if (p1X > GameScreen.screenWidth + 20)
            {
                p1X = -15;
            }
        }

    }
}
