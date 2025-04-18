﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.LinkLabel;

namespace GameMaker
{
    internal class Ghost
    {
        public int x, y;
        public int size = 15;
        public int speed = 4;
        public int innerSize = 5;

        public string direction;
        public int turnTimer;

        Random randGen = new Random();
        int randNum;

        public static bool leave;

        public Rectangle ghostRec;
        public Image ghostImage;
        public string name;

        public Ghost(int _x, int _y, Image _image, string _name) 
        {
            x = _x;
            y = _y;
            ghostImage = _image;
            name = _name;
        }

        public bool CanTurn(Ibox ib)
        {
            Rectangle innerGhostRec = new Rectangle(x + 5, y + 5, innerSize, innerSize);

            if (innerGhostRec.IntersectsWith(ib.boxRec))
            {
                return true;
            }

            return false;
        }

        public void TurnMoveGhost(Ghost g, Ibox ib)
        {
                if (g.CanTurn(ib))
                {
                    if (g.turnTimer > 100)
                    {
                        randNum = randGen.Next(1, 5);

                        if (randNum == 1)
                        {
                            if (ib.up == true)
                            {
                                g.x = ib.x - (g.size / 3);
                                g.direction = "up";
                                g.turnTimer = 0;
                            }
                            else
                            {
                                g.direction = "";
                                randNum = randGen.Next(1, 5);
                            }
                        }
                        else if (randNum == 2)
                        {
                            if (ib.down == true)
                            {
                                g.x = ib.x - (g.size / 3);
                                g.direction = "down";
                                g.turnTimer = 0;
                            }
                            else
                            {
                                g.direction = "";
                                randNum = randGen.Next(1, 5);
                            }
                        }
                        else if (randNum == 3)
                        {
                            if (ib.left == true)
                            {
                                g.y = ib.y - (g.size / 3);
                                g.direction = "left";
                                g.turnTimer = 0;
                            }
                            else
                            {
                                g.direction = "";
                                randNum = randGen.Next(1, 5);
                            }
                        }
                        else
                        {
                            if (ib.right == true)
                            {
                                g.y = ib.y - (g.size / 3);
                                g.direction = "right";
                                g.turnTimer = 0;
                            }
                            else
                            {
                                g.direction = "";
                                randNum = randGen.Next(1, 5);
                            }
                        }
                    }
                }

                g.turnTimer++;
            
        }

        public void MoveGhost()
        {
            if (direction == "right")
            {
                x += speed;
            }
            else if (direction == "left")
            {
                x -= speed;
            }
            else if (direction == "down")
            {
                y += speed;
            }
            else if (direction == "up")
            {
                y -= speed;
            }

            //if goes through the side put it on other side 
            if (x < -20)
            {
                x = 488 + 15;
            }
            else if (y < -20)
            {
                y = 366 + 15;
            }
            else if (y > 366 + 20)
            {
                y = -15;
            }
            else if (x > 488 + 20)
            {
                x = -15;
            }
        }

        public void SpawnMove(Ghost g, bool spawned)
        {
            if (spawned == true)
            {
                if (leave == false)
                {
                    if (g.x </* GameScreen.screenWidth*/ 488 / 2)
                    {
                        g.direction = "right";
                    }
                    else
                    {
                        g.direction = "left";
                    }
                    leave = true;
                }

                if (g.x == /*GameScreen.screenWidth*/488 / 2 - g.size / 2)
                {
                    g.direction = "up";
                    leave = false;
                    
                }
            }
        }


    }
}
