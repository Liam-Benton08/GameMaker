using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Threading;
using System.Media;


//Liam Benton 
//Pac Man
//March 24, 2025

namespace GameMaker
{
    public partial class GameScreen : UserControl
    {
        //Creates player
        Players playerOne;

        //Creates Ghosts
        Ghost Blinky;
        Ghost Pinky;
        Ghost Inky;
        Ghost Cylde;

        //Create Brushes
        #region Brushes
        Brush coinBrush = new SolidBrush(Color.Gold);
        Brush wallBrush;
        Brush ghostCandyBrush = new SolidBrush(Color.Indigo);
        #endregion

        //Creates Lists
        List<Rectangle> walls = new List<Rectangle>();
        List<Ibox> boxList = new List<Ibox>();
        List<Rectangle> coinList = new List<Rectangle>();
        List<Ghost> ghostList = new List<Ghost>();
        List<Rectangle> candyList = new List<Rectangle>();
        List<Players> playerList = new List<Players>();

        //Creates all other things
        //public static int screenWidth;
        //public static int screenHeight;

        bool leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, spaceKeyDown;

        public bool startGame, coinsCleared, ghostHit;

        int p1Score = 0;

        int ghostSpawnTimer;

        int SpawnDifference = 500;
        int SpawnAddition = 400;
        int lives;

        bool powerUp;
        int powerUpTimer;
        int multiplier = 1;

        public static bool blinkySpawn = true, pinkySpawn = true, inkySpawn = true, cyldeSpawn = true;

        bool bSpawn, pSpawn, iSpawn, cSpawn;

        string playerName;
        string wallColor;
        string difficulty;

        bool powerFlash;

        SoundPlayer Munch = new SoundPlayer(Properties.Resources.Munch);

        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();

            //Sets measurements of screen
            //screenWidth = this.Width;
            //screenHeight = this.Height;
        }

        public void InitializeGame()
        {
            //Clears list so no overlap
            playerList.Clear();
            ghostList.Clear();
            walls.Clear();
            boxList.Clear();

            ghostSpawnTimer = 0;

            gameTimer.Enabled = true;

            //Creates Player
            playerOne = new Players();
            playerList.Add(playerOne);

            //Creates ghosts
            Blinky = new Ghost(293, 178, Properties.Resources.Blinky, "Blinky");
            ghostList.Add(Blinky);

            Pinky = new Ghost(185, 178, Properties.Resources.Pinky, "Pinky");
            ghostList.Add(Pinky);

            Inky = new Ghost(185, 233, Properties.Resources.Inky, "Inky");
            ghostList.Add(Inky);

            Cylde = new Ghost(293, 233, Properties.Resources.Clyde, "Clyde");
            ghostList.Add(Cylde);

            //Sets up walls, coins, turns
            createWalls();
            createTurns();
            createCoins();

            startGame = true;

            //Takes values from menu screenv
            playerName = SelectModeScreen.p1Userame;
            wallColor = SelectModeScreen.p1Color;
            difficulty = SelectModeScreen.p1Difficulty;

            //Takes difficulty and sets lives depending
            if (difficulty == "Easy")
            {
                lives = 3;
            }
            else if (difficulty == "Medium")
            {
                lives = 2;
            }
            else
            {
                lives = 1;
            }

            if (wallColor == "Blue")
            {
                wallBrush = new SolidBrush(Color.Navy);
            }
            else if (wallColor == "Red")
            {
                wallBrush = new SolidBrush(Color.Red);
            }
            else if (wallColor == "Green")
            {
                wallBrush = new SolidBrush(Color.Green);
            }
            else if (wallColor == "Cyan")
            {
                wallBrush = new SolidBrush(Color.Cyan);
            }
            else if (wallColor == "Purple")
            {
                wallBrush = new SolidBrush(Color.Purple);
            }
            else
            {
                wallBrush = new SolidBrush(Color.Pink);
            }
            //this is for the starts after one game is completed
            resetPositions();
            Ghost.leave = false;
        }

        public void createWalls()
        {
            //Creates all outer walls
            #region Outer Walls
            //Draws Outside Walls
            Rectangle leftWall = new Rectangle(10, 10, 5, 366 / 2 - 35);
            Rectangle bottomLeftWall = new Rectangle(10, 366 / 2 + 25, 5, 366 / 2 - 40);
            walls.Add(leftWall);
            walls.Add(bottomLeftWall);
            Rectangle rightWall = new Rectangle(488 - 15, 10, 5, 366 / 2 - 35);
            Rectangle bottomRightWall = new Rectangle(488 - 15, 366 / 2 + 25, 5, 366 / 2 - 40);
            walls.Add(rightWall);
            walls.Add(bottomRightWall);
            Rectangle topWall = new Rectangle(10, 10, 488 / 2 - 35, 5);
            Rectangle rightTopWall = new Rectangle(488 / 2 + 25, 10, 488 / 2 - 40, 5);
            walls.Add(topWall);
            walls.Add(rightTopWall);
            Rectangle bottomWall = new Rectangle(10, 366 - 15, 488 / 2 - 35, 5);
            Rectangle rightBottomWall = new Rectangle(488 / 2 + 25, 366 - 15, 488 / 2 - 40, 5);
            walls.Add(bottomWall);
            walls.Add(rightBottomWall);

            //Draws Outside Catching Walls
            Rectangle leftSideTopCatch = new Rectangle(0, 366 / 2 - 30, 10, 5);
            Rectangle leftSideBottomCatch = new Rectangle(0, 366 / 2 + 25, 10, 5);
            walls.Add(leftSideTopCatch);
            walls.Add(leftSideBottomCatch);
            Rectangle rightSideTopCatch = new Rectangle(488 - 10, 366 / 2 - 30, 10, 5);
            Rectangle rightSideBottomCatch = new Rectangle(488 - 10, 366 / 2 + 25, 10, 5);
            walls.Add(rightSideTopCatch);
            walls.Add(rightSideBottomCatch);
            Rectangle topLeftSideCatch = new Rectangle(488 / 2 - 30, 0, 5, 10);
            Rectangle topRightSideCatch = new Rectangle(488 / 2 + 25, 0, 5, 10);
            walls.Add(topLeftSideCatch);
            walls.Add(topRightSideCatch);
            Rectangle bottomLeftSideCatch = new Rectangle(488 / 2 - 30, 366 - 10, 5, 10);
            Rectangle bottomRightSideCatch = new Rectangle(488 / 2 + 25, 366 - 10, 5, 10);
            walls.Add(bottomLeftSideCatch);
            walls.Add(bottomRightSideCatch);
            #endregion

            #region SecondLayer Walls
            Rectangle sTopSide = new Rectangle(60, 55, 488 - 120, 5);
            walls.Add(sTopSide);
            Rectangle sLeftSideTop = new Rectangle(60, 55, 5, 366 / 6);
            Rectangle sLeftSideBottom = new Rectangle(60, 366 / 6 + 105, 5, 100);
            walls.Add(sLeftSideTop);
            walls.Add(sLeftSideBottom);
            Rectangle sBottomSideLeft = new Rectangle(60, 366 - 55, 488 / 2 - 85, 5);
            Rectangle sBottomSideRight = new Rectangle(488 / 2 + 25, 366 - 55, 159, 5);
            walls.Add(sBottomSideLeft);
            walls.Add(sBottomSideRight);
            Rectangle sRightSideBottom = new Rectangle(488 - 65, 105, 5, 366 - 155);
            walls.Add(sRightSideBottom);
            #endregion

            #region ThirdLayerWalls
            Rectangle tLeftSide = new Rectangle(110, 105, 5, 210);
            walls.Add(tLeftSide);
            Rectangle tBottomSide = new Rectangle(160, 265, 219, 5);
            walls.Add(tBottomSide);
            Rectangle tRightSide = new Rectangle(488 - 115, 105, 5, 115);
            walls.Add(tRightSide);
            Rectangle tTopSide = new Rectangle(110, 105, 220, 5);
            walls.Add(tTopSide);
            #endregion

            #region BoxLayers
            //Techincally Fourth Layer
            Rectangle fLeftSide = new Rectangle(160, 155, 5, 110);
            walls.Add(fLeftSide);
            Rectangle fRightSide = new Rectangle(325, 155, 5, 115);
            walls.Add(fRightSide);
            Rectangle fTopRight = new Rectangle(270, 155, 55, 5);
            walls.Add(fTopRight);
            Rectangle fTopLeft = new Rectangle(165, 155, 55, 5);
            walls.Add(fTopLeft);

            Rectangle gLeftMiddleSide = new Rectangle(165, 210, 55, 5);
            walls.Add(gLeftMiddleSide);
            Rectangle gRightMiddleSide = new Rectangle(270, 210, 55, 5);
            walls.Add(gRightMiddleSide);
            Rectangle gTopLeftSide = new Rectangle(215, 155, 5, 15);
            walls.Add(gTopLeftSide);
            Rectangle gMiddleLeftSide = new Rectangle(215, 200, 5, 25);
            walls.Add(gMiddleLeftSide);
            Rectangle gBottomLeftSide = new Rectangle(215, 255, 5, 10);
            walls.Add(gBottomLeftSide);
            Rectangle hTopLeftSide = new Rectangle(270, 155, 5, 15);
            walls.Add(hTopLeftSide);
            Rectangle hMiddleLeftSide = new Rectangle(270, 200, 5, 25);
            walls.Add(hMiddleLeftSide);
            Rectangle hBottomLeftSide = new Rectangle(270, 255, 5, 10);
            walls.Add(hBottomLeftSide);

            #endregion
        }
        public void createTurns()
        {
            Ibox newBox;

            //Creates all invisible turns and puts them into Ibox class
            #region Outer Turns

            newBox = new Ibox(35, 366 - 35, true, false, false, true);
            boxList.Add(newBox);

            newBox = new Ibox(35, 366 / 6 + 80, true, true, false, true);
            boxList.Add(newBox);

            newBox = new Ibox(35, 366 - 80, true, true, false, true);
            boxList.Add(newBox);

            newBox = new Ibox(488 / 2 - (5 / 2), 30, true, false, true, true);
            boxList.Add(newBox);

            newBox = new Ibox(35, 30, false, true, false, true);
            boxList.Add(newBox);

            newBox = new Ibox(488 - 40, 30, false, true, true, false);
            boxList.Add(newBox);

            newBox = new Ibox(488 - 40, 80, true, true, true, false);
            boxList.Add(newBox);

            newBox = new Ibox(488 - 40, 366 - 35, true, false, true, false);
            boxList.Add(newBox);

            newBox = new Ibox(488 / 2 - (5 / 2), 366 - 35, true, true, true, true);
            boxList.Add(newBox);

            newBox = new Ibox(35, 366 / 2 - (5 / 2), true, true, true, false);
            boxList.Add(newBox);

            newBox = new Ibox(488 - 40, 366 / 2 - (5 / 2), true, true, false, true);
            boxList.Add(newBox);
            #endregion

            #region innerBox
            newBox = new Ibox(85, 80, false, true, false, true);
            boxList.Add(newBox);

            newBox = new Ibox(488 - 140, 80, false, true, true, true);
            boxList.Add(newBox);

            newBox = new Ibox(488 - 90, 80, false, true, true, true);
            boxList.Add(newBox);

            newBox = new Ibox(85, 366 / 6 + 80, true, true, true, false);
            boxList.Add(newBox);

            newBox = new Ibox(85, 366 - 80, true, false, true, false);
            boxList.Add(newBox);

            newBox = new Ibox(488 / 2 - (5 / 2), 366 - 80, false, true, true, true);
            boxList.Add(newBox);

            newBox = new Ibox(488 - 90, 366 - 80, true, false, true, false);
            boxList.Add(newBox);

            newBox = new Ibox(135, 366 - 80, true, false, false, true);
            boxList.Add(newBox);

            newBox = new Ibox(488 - 90, 366 - 125, true, true, true, false);
            boxList.Add(newBox);

            newBox = new Ibox(488 - 140, 366 - 125, true, false, false, true);
            boxList.Add(newBox);

            newBox = new Ibox(488 - 140, 130, true, true, true, false);
            boxList.Add(newBox);

            newBox = new Ibox(135, 130, false, true, false, true);
            boxList.Add(newBox);

            newBox = new Ibox(488 / 2 - (5 / 2), 130, false, true, true, true);
            boxList.Add(newBox);

            newBox = new Ibox(488 / 2 - (5 / 2), 240, true, false, false, false);
            boxList.Add(newBox);

            // newBox = new Ibox
            #endregion
        }
        public void createCoins()
        {
            //These values are used to change and make coins in the most efficent way
            int recX;
            int recY;
            int recsize = 5;

            //outer top side
            recX = 35;
            recY = 35;
            for (int i = 0; i < 22; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recX += 20;
            }
            //Outer bottom side
            recX = 35;
            recY = 366 - 35;
            for (int i = 0; i < 22; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recX += 20;
            }
            //Outer Left side
            recX = 35;
            recY = 55;
            for (int i = 0; i < 14; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recY += 20;
            }
            //Outer Right Side
            recX = 488 - 35;
            recY = 55;
            for (int i = 0; i < 14; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recY += 20;
            }
            //inner top side p1
            recX = 85;
            recY = 80;
            for (int i = 0; i < 7; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recX += 20;
            }
            //inner top side p2
            recX = 280;
            for (int i = 0; i < 8; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recX += 21;
            }
            //inner left side
            recX = 85;
            recY = 100;
            for (int i = 0; i < 11; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recY += 19;
            }
            //inner right side
            recX = 488 - 90;
            recY = 100;
            for (int i = 0; i < 11; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recY += 19;
            }
            //inner bottom side
            recX = 135;
            recY -= 19;
            for (int i = 0; i < 13; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recX += 20;
            }
            //center left side
            recX = 135;
            recY = 130;
            for (int i = 0; i < 8; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recY += 20;
            }
            //center top side
            recX = 135;
            recY = 130;
            for (int i = 0; i < 10; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recX += 21;
            }
            //center right side
            recX = 488 - 140;
            recY = 100;
            for (int i = 0; i < 8; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recY += 20;
            }
            //Inner Sqaure
            recX = 488 / 2 - (5 / 2);
            recY = 155;
            for (int i = 0; i < 4; i++)
            {
                Rectangle rec = new Rectangle(recX, recY, recsize, recsize);
                coinList.Add(rec);

                recY += 20;
            }

            Rectangle candy = new Rectangle(488 / 2 - 4, 235, 8, 8);
            candyList.Add(candy);


            //Inbetween doors coins
            Rectangle extraRec = new Rectangle(60, 366 - 75, 5, 5);
            coinList.Add(extraRec);
            Rectangle extraRec2 = new Rectangle(60, 135, 5, 5);
            coinList.Add(extraRec2);
            Rectangle extraRec3 = new Rectangle(488 - 115, 366 - 125, 5, 5);
            coinList.Add(extraRec3);
            Rectangle extraRec4 = new Rectangle(488 / 2 - (5 / 2), 366 - 55, 5, 5);
            coinList.Add(extraRec4);

        }

        public void resetPositions()
        {
            //Resets all x and y after each reset
            playerOne.p1X = 488 / 2 - playerOne.size / 2;
            playerOne.p1Y = 75;

            Blinky.x = 293;
            Blinky.y = 178;

            Cylde.x = 293;
            Cylde.y = 233;

            Inky.x = 185;
            Inky.y = 233;

            Pinky.x = 185;
            Pinky.y = 178;

            //Stops ghost directions
            Blinky.direction = "";
            Pinky.direction = "";
            Inky.direction = "";
            Cylde.direction = "";

            //Makes them have their spawn movement available
            cyldeSpawn = true;
            blinkySpawn = true;
            pinkySpawn = true;
            inkySpawn = true;

            powerUp = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //runs code for everything, but put into methods
            playerOne.MovePlayer();

            foreach (Ghost g in ghostList)
            {
                g.MoveGhost();
            }

            movingConditions();

            losingLives();

            coinCollision();

            turnsCollision();

            ghostSpawnTimer++;

            Refresh();
        }

        private void losingLives()
        {
            foreach (Ghost g in ghostList)
            {
                if (playerOne.GhostCollision(g))
                {
                    //If the player has the powerup on
                    if (powerUp == true)
                    {
                        //Find which ghost it is and reset positions
                        if (g.name == "Blinky")
                        {
                            g.x = 293;
                            g.y = 178;
                            bSpawn = true;
                            g.direction = "";
                        }
                        else if (g.name == "Pinky")
                        {
                            g.x = 185;
                            g.y = 178;
                            pSpawn = true;
                            g.direction = "";
                        }
                        else if (g.name == "Inky")
                        {
                            g.x = 185;
                            g.y = 233;
                            iSpawn = true;
                            g.direction = "";
                        }
                        else
                        {
                            g.x = 293;
                            g.y = 233;
                            cSpawn = true;
                            g.direction = "";
                        }

                        //Adds score but if multiple ghost get eaten in one powerup score the score multiplies
                        p1Score += 100 * multiplier;
                        multiplier++;
                    }
                    else
                    {
                        Thread.Sleep(1000);

                        //resets positions and make sure the game can run again
                        playerOne.direction = "";
                        resetPositions();
                        Ghost.leave = true;
                        gameOverLabel.Visible = true;
                        ghostHit = true;
                        lives--;
                    }
                }

                if (powerUp == false)
                {
                    //Once powerup turns off and a ghost has been eaten make them move again
                    if (bSpawn == true)
                    {
                        blinkySpawn = true;
                        bSpawn = false;
                    }
                    else if (pSpawn == true)
                    {
                        pinkySpawn = true;
                        pSpawn = false;
                    }
                    else if (iSpawn == true)
                    {
                        inkySpawn = true;
                        iSpawn = false;
                    }
                    else if (cSpawn == true)
                    {
                        cyldeSpawn = true;
                        cSpawn = false;
                    }
                }
            }

            if (spaceKeyDown == true && ghostHit == true)
            {
                //this code starts the game again after being eaten
                ghostHit = false;
                gameOverLabel.Visible = false;
                playerOne.direction = "right";
                Ghost.leave = false;

                ghostSpawnTimer = 0;
            }

            if (lives == 0)
            {
                //changes screen when game is over
                gameTimer.Enabled = false;
                Form1.ChangeScreen(this, new EndScreen());
            }

            //Updates all score
            p1LivesLabel.Text = $"Lives: {lives}";
            p1ScoreTracker.Text = $"Score: {p1Score}";
            nameLabel.Text = $"{playerName}";
        }

        private void movingConditions()
        {
            //Make sure that you can only move opposite direction as going
            if (leftArrowDown == true && (playerOne.direction == "right" || playerOne.direction == "still"))
            {
                playerOne.direction = "left";
            }
            if (rightArrowDown == true && (playerOne.direction == "left" || playerOne.direction == "still"))
            {
                playerOne.direction = "right";
            }

            if (downArrowDown == true && (playerOne.direction == "up" || playerOne.direction == "still"))
            {
                playerOne.direction = "down";
            }

            if (upArrowDown == true && (playerOne.direction == "down" || playerOne.direction == "still"))
            {
                playerOne.direction = "up";
            }
        }

        private void turnsCollision()
        {
            foreach (Ibox ib in boxList)
            {
                if (playerOne.CanTurn(ib))
                {
                    //If not allowed to go a direction it wont let them move that direction
                    if ((ib.up == false && playerOne.direction == "up") || (ib.right == false && playerOne.direction == "right") || (ib.down == false && playerOne.direction == "down") || (ib.left == false && playerOne.direction == "left"))
                    {
                        if (playerOne.direction == "left")
                        {
                            playerOne.pacImage = Properties.Resources.pacman_left;
                        }
                        else if (playerOne.direction == "right")
                        {
                            playerOne.pacImage = Properties.Resources.pacman;
                        }
                        else if (playerOne.direction == "down")
                        {
                            playerOne.pacImage = Properties.Resources.pacman_Down;
                        }
                        else
                        {
                            playerOne.pacImage = Properties.Resources.pacman_Up;
                        }

                        playerOne.direction = "still";
                        playerOne.p1X = ib.x - (playerOne.size / 3);
                        playerOne.p1Y = ib.y - (playerOne.size / 3);
                    }

                    //Multi Option Turn
                    if (ib.left == true && (playerOne.direction == "up" || playerOne.direction == "down") && leftArrowDown == true)
                    {
                        playerOne.direction = "left";
                        playerOne.p1Y = ib.y - (playerOne.size / 3);
                    }
                    else if (ib.right == true && (playerOne.direction == "up" || playerOne.direction == "down") && rightArrowDown == true)
                    {
                        playerOne.direction = "right";
                        playerOne.p1Y = ib.y - (playerOne.size / 3);
                    }
                    else if (ib.up == true && (playerOne.direction == "left" || playerOne.direction == "right") && upArrowDown == true)
                    {
                        playerOne.direction = "up";
                        playerOne.p1X = ib.x - (playerOne.size / 3);
                    }
                    else if (ib.down == true && (playerOne.direction == "left" || playerOne.direction == "right") && downArrowDown == true)
                    {
                        playerOne.direction = "down";
                        playerOne.p1X = ib.x - (playerOne.size / 3);
                    }

                }

                //Moves blinky
                Blinky.TurnMoveGhost(Blinky, ib);

                //Spawn moves blinky once
                if (blinkySpawn == true)
                {
                    Blinky.SpawnMove(Blinky, blinkySpawn);

                    if (Blinky.direction == "up")
                    {
                        blinkySpawn = false;
                    }
                }

                
                if (ghostSpawnTimer > SpawnDifference)
                {
                    //Spawn moves Pinky once then perma moves him
                    Pinky.TurnMoveGhost(Pinky, ib);

                    if (pinkySpawn == true)
                    {
                        Pinky.SpawnMove(Pinky, pinkySpawn);
                        if (Pinky.direction == "up")
                        {
                            pinkySpawn = false;
                        }
                    }
                }
                if (ghostSpawnTimer > SpawnDifference + SpawnAddition)
                {
                    //Spawn moves Inky once then perma moves him
                    Inky.TurnMoveGhost(Inky, ib);

                    if (inkySpawn == true)
                    {
                        Inky.SpawnMove(Inky, inkySpawn);
                        if (Inky.direction == "up")
                        {
                            inkySpawn = false;
                        }
                    }
                }
                if (ghostSpawnTimer > SpawnAddition + SpawnAddition + SpawnAddition / 2)
                {
                    //Spawn move clyde then perma moves cylde after
                    Cylde.TurnMoveGhost(Cylde, ib);

                    if (cyldeSpawn == true)
                    {
                        Cylde.SpawnMove(Cylde, cyldeSpawn);
                        if (Cylde.direction == "up")
                        {
                            cyldeSpawn = false;
                        }
                    }
                }

            }
        }

        private void coinCollision()
        {
            for (int i = 0; i < coinList.Count; i++)
            {
                if (playerOne.Collisions(coinList[i]))
                {
                    //If player hits a coin

                    //Removes coin
                    coinList.Remove(coinList[i]);

                    //Adds score
                    p1Score++;
                    startGame = false;

                    //change picture to make it seem like hes eating
                    playerOne.pacImage = Properties.Resources.pacmanClosed;
                    Munch.Play();
                }
            }

            if (coinList.Count == 0 && startGame == false)
            {
                //IF coin list in empty
                Thread.Sleep(1000);
                
                //Reset everything
                createCoins();
                playerOne.direction = "";
                Ghost.leave = true;
                resetPositions();

                gameOverLabel.Visible = true;
                coinsCleared = true;
                startGame = true;
            }

            if (spaceKeyDown == true && coinsCleared == true)
            {
                //if space is clicked start game again
                gameOverLabel.Visible = false;
                playerOne.direction = "right";
                coinsCleared = false;
                Ghost.leave = false;

                ghostSpawnTimer = 0;
            }

            for (int i = 0; i < candyList.Count; i++)
            {
                //if hits a candy turn power up on
                if (playerOne.CandyCollision(candyList[i]))
                {
                    candyList.Remove(candyList[i]);
                    powerUp = true;

                    foreach (Ghost g in ghostList)
                    {
                        g.ghostImage = Properties.Resources.Vunerable_Ghost;
                    }
                }
            }

            if (powerUp == true)
            {
                powerUpTimer++;

                if(powerUpTimer > 300)
                {
                    //If powerup almost done flash so user knows
                    if (powerFlash == true)
                    {
                        Blinky.ghostImage = Properties.Resources.Blinky;
                        Pinky.ghostImage = Properties.Resources.Pinky;
                        Inky.ghostImage = Properties.Resources.Inky;
                        Cylde.ghostImage = Properties.Resources.Clyde;
                        powerFlash = false;
                    }
                    else if (powerFlash == false)
                    {
                        foreach (Ghost g in ghostList)
                        {
                            g.ghostImage = Properties.Resources.Vunerable_Ghost;
                        }
                    }
                }
                

                if (powerUpTimer > 400)
                {
                    //When timer is up turnpower off
                    powerUpTimer = 0;
                    powerUp = false;
                    multiplier = 1;

                    Blinky.ghostImage = Properties.Resources.Blinky;
                    Pinky.ghostImage = Properties.Resources.Pinky;
                    Inky.ghostImage = Properties.Resources.Inky;
                    Cylde.ghostImage = Properties.Resources.Clyde;
                }
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Space:
                    spaceKeyDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Space:
                    spaceKeyDown = false;
                    break;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < walls.Count; i++)
            {
                //Paint walls depending on wall colour
                e.Graphics.FillRectangle(wallBrush, walls[i].X, walls[i].Y, walls[i].Width, walls[i].Height);               
            }

            //paint all coins
            if (coinsCleared == false)
            {
                for (int i = 0; i < coinList.Count; i++)
                {
                    e.Graphics.FillRectangle(coinBrush, coinList[i].X, coinList[i].Y, coinList[i].Width, coinList[i].Height);
                }
            }

            //Paint candy 
            for (int i = 0; i < candyList.Count; i++)
            {
                e.Graphics.FillRectangle(ghostCandyBrush, candyList[i].X, candyList[i].Y, 8, 8);
            }

            //Paint ghosts
            foreach (Ghost g in ghostList)
            {
                e.Graphics.DrawImage(g.ghostImage, g.x, g.y, g.size, g.size);
            }

           //Paints player
            e.Graphics.DrawImage(playerOne.pacImage, playerOne.p1X, playerOne.p1Y, playerOne.size, playerOne.size);
        }

    }
}
